using System;

namespace OfficeItemRentalApp.Models
{
    public sealed class RentalRecord
    {
        public RentalRecord()
        {
            RecordId = string.Empty;
            ItemId = string.Empty;
            BorrowerName = string.Empty;
            RentalDate = DateTime.Today;
            DueDate = DateTime.Today;
            ReturnDate = null;
        }

        public RentalRecord(
            string recordId,
            string itemId,
            string borrowerName,
            DateTime rentalDate,
            DateTime dueDate,
            DateTime? returnDate)
        {
            RecordId = recordId;
            ItemId = itemId;
            BorrowerName = borrowerName;
            RentalDate = rentalDate.Date;
            DueDate = dueDate.Date;
            ReturnDate = returnDate.HasValue ? returnDate.Value.Date : (DateTime?)null;
        }

        public string RecordId { get; set; }

        public string ItemId { get; set; }

        public string BorrowerName { get; set; }

        public DateTime RentalDate { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime? ReturnDate { get; set; }
    }
}
