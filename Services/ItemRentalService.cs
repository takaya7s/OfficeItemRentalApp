using System;
using System.Collections.Generic;
using System.Linq;
using OfficeItemRentalApp.Models;

namespace OfficeItemRentalApp.Services
{
    internal sealed class ItemRentalService
    {
        private readonly RentalDatabase database;
        private readonly JsonDataStore store;

        public ItemRentalService(RentalDatabase database, JsonDataStore store)
        {
            this.database = database;
            this.store = store;
        }

        public bool HasItems
        {
            get { return database.Items.Count > 0; }
        }

        public RegisterItemResult RegisterItem(string id, string name, ItemCategory category)
        {
            if (FindItem(id) != null)
            {
                return new RegisterItemResult(RegisterItemStatus.DuplicateId);
            }

            database.Items.Add(new Item(id, name, category));
            Save();

            return new RegisterItemResult(RegisterItemStatus.Success);
        }

        public RentItemResult RentItem(string itemId, string borrowerName, DateTime rentalDate, DateTime dueDate)
        {
            var item = FindItem(itemId);
            if (item == null)
            {
                return new RentItemResult(RentItemStatus.ItemNotFound);
            }

            var currentRental = FindCurrentRental(item.Id);
            if (currentRental != null)
            {
                return new RentItemResult(RentItemStatus.AlreadyRented, currentRental);
            }

            if (dueDate.Date < rentalDate.Date)
            {
                return new RentItemResult(RentItemStatus.DueDateBeforeRentalDate);
            }

            database.Rentals.Add(new RentalRecord(
                Guid.NewGuid().ToString("N"),
                item.Id,
                borrowerName,
                rentalDate,
                dueDate,
                null));

            Save();

            return new RentItemResult(RentItemStatus.Success);
        }

        public ReturnItemResult ReturnItem(string itemId, DateTime returnDate)
        {
            var item = FindItem(itemId);
            if (item == null)
            {
                return new ReturnItemResult(ReturnItemStatus.ItemNotFound);
            }

            var currentRental = FindCurrentRental(item.Id);
            if (currentRental == null)
            {
                return new ReturnItemResult(ReturnItemStatus.NotRented, item, null);
            }

            if (returnDate.Date < currentRental.RentalDate.Date)
            {
                return new ReturnItemResult(ReturnItemStatus.ReturnDateBeforeRentalDate, item, currentRental);
            }

            currentRental.ReturnDate = returnDate.Date;
            Save();

            return new ReturnItemResult(ReturnItemStatus.Success, item, currentRental);
        }

        public Item FindItem(string id)
        {
            return database.Items.FirstOrDefault(item =>
                string.Equals(item.Id, id, StringComparison.OrdinalIgnoreCase));
        }

        public RentalRecord FindCurrentRental(string itemId)
        {
            return database.Rentals.FirstOrDefault(rental =>
                string.Equals(rental.ItemId, itemId, StringComparison.OrdinalIgnoreCase)
                && !rental.ReturnDate.HasValue);
        }

        public IReadOnlyList<ItemListItem> GetItemList(DateTime today)
        {
            return database.Items
                .OrderBy(item => item.Id, StringComparer.OrdinalIgnoreCase)
                .Select(item =>
                {
                    var currentRental = FindCurrentRental(item.Id);
                    return new ItemListItem(item, currentRental, IsOverdue(currentRental, today));
                })
                .ToList();
        }

        public IReadOnlyList<BorrowerRentalItem> GetCurrentRentalsByBorrower(string borrowerKeyword, DateTime today)
        {
            return database.Rentals
                .Where(rental => !rental.ReturnDate.HasValue)
                .Where(rental => rental.BorrowerName.IndexOf(borrowerKeyword, StringComparison.OrdinalIgnoreCase) >= 0)
                .OrderBy(rental => rental.DueDate)
                .Select(rental => new BorrowerRentalItem(
                    FindItem(rental.ItemId),
                    rental,
                    IsOverdue(rental, today)))
                .ToList();
        }

        public ItemHistoryResult GetItemHistory(string itemId)
        {
            var item = FindItem(itemId);
            if (item == null)
            {
                return new ItemHistoryResult(ItemHistoryStatus.ItemNotFound, null, null);
            }

            var histories = database.Rentals
                .Where(rental => string.Equals(rental.ItemId, item.Id, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(rental => rental.RentalDate)
                .ThenByDescending(rental => rental.DueDate)
                .ToList();

            return new ItemHistoryResult(ItemHistoryStatus.Success, item, histories);
        }

        private static bool IsOverdue(RentalRecord rental, DateTime today)
        {
            return rental != null && !rental.ReturnDate.HasValue && rental.DueDate.Date < today.Date;
        }

        private void Save()
        {
            store.Save(database);
        }
    }

    internal sealed class ItemListItem
    {
        public ItemListItem(Item item, RentalRecord currentRental, bool isOverdue)
        {
            Item = item;
            CurrentRental = currentRental;
            IsOverdue = isOverdue;
        }

        public Item Item { get; private set; }

        public RentalRecord CurrentRental { get; private set; }

        public bool IsOverdue { get; private set; }
    }

    internal sealed class BorrowerRentalItem
    {
        public BorrowerRentalItem(Item item, RentalRecord rental, bool isOverdue)
        {
            Item = item;
            Rental = rental;
            IsOverdue = isOverdue;
        }

        public Item Item { get; private set; }

        public RentalRecord Rental { get; private set; }

        public bool IsOverdue { get; private set; }
    }

    internal enum RegisterItemStatus
    {
        Success,
        DuplicateId
    }

    internal sealed class RegisterItemResult
    {
        public RegisterItemResult(RegisterItemStatus status)
        {
            Status = status;
        }

        public RegisterItemStatus Status { get; private set; }
    }

    internal enum RentItemStatus
    {
        Success,
        ItemNotFound,
        AlreadyRented,
        DueDateBeforeRentalDate
    }

    internal sealed class RentItemResult
    {
        public RentItemResult(RentItemStatus status)
            : this(status, null)
        {
        }

        public RentItemResult(RentItemStatus status, RentalRecord existingRental)
        {
            Status = status;
            ExistingRental = existingRental;
        }

        public RentItemStatus Status { get; private set; }

        public RentalRecord ExistingRental { get; private set; }
    }

    internal enum ReturnItemStatus
    {
        Success,
        ItemNotFound,
        NotRented,
        ReturnDateBeforeRentalDate
    }

    internal sealed class ReturnItemResult
    {
        public ReturnItemResult(ReturnItemStatus status)
            : this(status, null, null)
        {
        }

        public ReturnItemResult(ReturnItemStatus status, Item item, RentalRecord rental)
        {
            Status = status;
            Item = item;
            Rental = rental;
        }

        public ReturnItemStatus Status { get; private set; }

        public Item Item { get; private set; }

        public RentalRecord Rental { get; private set; }
    }

    internal enum ItemHistoryStatus
    {
        Success,
        ItemNotFound
    }

    internal sealed class ItemHistoryResult
    {
        public ItemHistoryResult(ItemHistoryStatus status, Item item, IReadOnlyList<RentalRecord> rentals)
        {
            Status = status;
            Item = item;
            Rentals = rentals;
        }

        public ItemHistoryStatus Status { get; private set; }

        public Item Item { get; private set; }

        public IReadOnlyList<RentalRecord> Rentals { get; private set; }
    }
}
