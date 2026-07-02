using System;
using System.Collections.Generic;
using OfficeItemRentalApp.Models;
using OfficeItemRentalApp.Services;

namespace OfficeItemRentalApp.ConsoleUI
{
    internal sealed class ItemRentalConsoleApp
    {
        private readonly ItemRentalService rentalService;

        public ItemRentalConsoleApp(ItemRentalService rentalService)
        {
            this.rentalService = rentalService;
        }

        public void Run()
        {
            while (true)
            {
                ShowMenu();
                var selected = ConsoleInput.ReadRequiredText("番号を選択してください: ");
                Console.WriteLine();

                switch (selected)
                {
                    case "1":
                        RegisterItem();
                        break;
                    case "2":
                        RentItem();
                        break;
                    case "3":
                        ReturnItem();
                        break;
                    case "4":
                        ShowItemList();
                        break;
                    case "5":
                        ShowRentalsByBorrower();
                        break;
                    case "6":
                        ShowItemHistory();
                        break;
                    case "7":
                        Console.WriteLine("終了します。");
                        return;
                    default:
                        Console.WriteLine("1～7の番号を入力してください。");
                        break;
                }

                ConsoleInput.WaitForEnter();
            }
        }

        private static void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("===== 備品貸出管理システム =====");
            Console.WriteLine("1. 備品登録");
            Console.WriteLine("2. 貸出処理");
            Console.WriteLine("3. 返却処理");
            Console.WriteLine("4. 備品一覧表示");
            Console.WriteLine("5. 社員別貸出状況の確認");
            Console.WriteLine("6. 備品別の貸出履歴表示");
            Console.WriteLine("7. 終了");
        }

        private void RegisterItem()
        {
            Console.WriteLine("--- 備品登録 ---");

            var id = ConsoleInput.ReadRequiredText("備品ID: ");
            var existingItem = rentalService.FindItem(id);
            if (existingItem != null)
            {
                Console.WriteLine(
                    string.Format(
                        "同じ備品IDがすでに登録されています。登録済み備品: {0} / {1}",
                        existingItem.Id,
                        existingItem.Name));
                return;
            }

            var name = ConsoleInput.ReadRequiredText("備品名: ");
            var category = ConsoleInput.ReadCategory();

            var result = rentalService.RegisterItem(id, name, category);
            switch (result.Status)
            {
                case RegisterItemStatus.Success:
                    Console.WriteLine("備品を登録しました。");
                    break;
                case RegisterItemStatus.DuplicateId:
                    Console.WriteLine("同じ備品IDがすでに登録されています。");
                    break;
            }
        }

        private void RentItem()
        {
            Console.WriteLine("--- 貸出処理 ---");

            if (!rentalService.HasItems)
            {
                Console.WriteLine("備品が登録されていません。先に備品登録を行ってください。");
                return;
            }

            var itemId = ConsoleInput.ReadRequiredText("貸し出す備品ID: ");
            var item = rentalService.FindItem(itemId);
            if (item == null)
            {
                Console.WriteLine("指定された備品IDは登録されていません。");
                return;
            }

            var existingRental = rentalService.FindCurrentRental(item.Id);
            if (existingRental != null)
            {
                Console.WriteLine(
                    string.Format(
                        "この備品は現在貸出中です。借主: {0}, 返却予定日: {1}",
                        existingRental.BorrowerName,
                        DisplayFormatter.Date(existingRental.DueDate)));
                return;
            }

            var borrowerName = ConsoleInput.ReadRequiredText("借りる人の名前: ");
            var today = DateTime.Today;
            var rentalDate = ConsoleInput.ReadDateOrDefault("貸出日（空欄で本日）: ", today);
            var dueDate = ConsoleInput.ReadDate("返却予定日: ");

            while (dueDate.Date < rentalDate.Date)
            {
                Console.WriteLine("返却予定日は貸出日以降の日付を入力してください。");
                dueDate = ConsoleInput.ReadDate("返却予定日: ");
            }

            var result = rentalService.RentItem(itemId, borrowerName, rentalDate, dueDate);
            switch (result.Status)
            {
                case RentItemStatus.Success:
                    Console.WriteLine("貸出を登録しました。");
                    break;
                case RentItemStatus.ItemNotFound:
                    Console.WriteLine("指定された備品IDは登録されていません。");
                    break;
                case RentItemStatus.AlreadyRented:
                    Console.WriteLine(
                        string.Format(
                            "この備品は現在貸出中です。借主: {0}, 返却予定日: {1}",
                            result.ExistingRental == null ? "-" : result.ExistingRental.BorrowerName,
                            result.ExistingRental == null ? "-" : DisplayFormatter.Date(result.ExistingRental.DueDate)));
                    break;
                case RentItemStatus.DueDateBeforeRentalDate:
                    Console.WriteLine("返却予定日は貸出日以降の日付を入力してください。");
                    break;
            }
        }

        private void ReturnItem()
        {
            Console.WriteLine("--- 返却処理 ---");

            var itemId = ConsoleInput.ReadRequiredText("返却する備品ID: ");
            var item = rentalService.FindItem(itemId);
            if (item == null)
            {
                Console.WriteLine("指定された備品IDは登録されていません。");
                return;
            }

            var currentRental = rentalService.FindCurrentRental(item.Id);
            if (currentRental == null)
            {
                Console.WriteLine("この備品は現在貸出中ではありません。");
                return;
            }

            Console.WriteLine(
                string.Format(
                    "備品: {0} / 借主: {1} / 返却予定日: {2}",
                    item.Name,
                    currentRental.BorrowerName,
                    DisplayFormatter.Date(currentRental.DueDate)));

            var today = DateTime.Today;
            var returnDate = ConsoleInput.ReadDateOrDefault("返却日（空欄で本日）: ", today);

            while (returnDate.Date < currentRental.RentalDate.Date)
            {
                Console.WriteLine("返却日は貸出日以降の日付を入力してください。");
                returnDate = ConsoleInput.ReadDateOrDefault("返却日（空欄で本日）: ", today);
            }

            var result = rentalService.ReturnItem(itemId, returnDate);
            switch (result.Status)
            {
                case ReturnItemStatus.Success:
                    Console.WriteLine("返却を登録しました。");
                    break;
                case ReturnItemStatus.ItemNotFound:
                    Console.WriteLine("指定された備品IDは登録されていません。");
                    break;
                case ReturnItemStatus.NotRented:
                    Console.WriteLine("この備品は現在貸出中ではありません。");
                    break;
                case ReturnItemStatus.ReturnDateBeforeRentalDate:
                    Console.WriteLine("返却日は貸出日以降の日付を入力してください。");
                    break;
            }
        }

        private void ShowItemList()
        {
            Console.WriteLine("--- 備品一覧 ---");

            var items = rentalService.GetItemList(DateTime.Today);
            if (items.Count == 0)
            {
                Console.WriteLine("備品が登録されていません。");
                return;
            }

            Console.WriteLine("ID\t備品名\t区分\t状態\t借主\t貸出日\t返却予定日\t督促");

            foreach (var row in items)
            {
                var item = row.Item;
                var currentRental = row.CurrentRental;

                if (currentRental == null)
                {
                    Console.WriteLine(
                        string.Format(
                            "{0}\t{1}\t{2}\t利用可\t-\t-\t-\t-",
                            item.Id,
                            item.Name,
                            item.Category.ToDisplayName()));
                    continue;
                }

                Console.WriteLine(
                    string.Format(
                        "{0}\t{1}\t{2}\t貸出中\t{3}\t{4}\t{5}\t{6}",
                        item.Id,
                        item.Name,
                        item.Category.ToDisplayName(),
                        currentRental.BorrowerName,
                        DisplayFormatter.Date(currentRental.RentalDate),
                        DisplayFormatter.Date(currentRental.DueDate),
                        DisplayFormatter.Reminder(row.IsOverdue)));
            }
        }

        private void ShowRentalsByBorrower()
        {
            Console.WriteLine("--- 社員別貸出状況の確認 ---");

            var borrowerKeyword = ConsoleInput.ReadRequiredText("社員名（部分一致可）: ");
            var currentRentals = rentalService.GetCurrentRentalsByBorrower(
                borrowerKeyword,
                DateTime.Today);

            if (currentRentals.Count == 0)
            {
                Console.WriteLine("該当する貸出中の備品はありません。");
                return;
            }

            Console.WriteLine("備品ID\t備品名\t区分\t借主\t貸出日\t返却予定日\t督促");

            foreach (var row in currentRentals)
            {
                var rental = row.Rental;
                Console.WriteLine(
                    string.Format(
                        "{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}",
                        rental.ItemId,
                        row.Item == null ? "(未登録)" : row.Item.Name,
                        row.Item == null ? "-" : row.Item.Category.ToDisplayName(),
                        rental.BorrowerName,
                        DisplayFormatter.Date(rental.RentalDate),
                        DisplayFormatter.Date(rental.DueDate),
                        DisplayFormatter.Reminder(row.IsOverdue)));
            }
        }

        private void ShowItemHistory()
        {
            Console.WriteLine("--- 備品別の貸出履歴表示 ---");

            var itemId = ConsoleInput.ReadRequiredText("備品ID: ");
            var result = rentalService.GetItemHistory(itemId);

            if (result.Status == ItemHistoryStatus.ItemNotFound || result.Item == null)
            {
                Console.WriteLine("指定された備品IDは登録されていません。");
                return;
            }

            var item = result.Item;
            var histories = result.Rentals ?? new List<RentalRecord>();

            Console.WriteLine(
                string.Format(
                    "備品: {0} / {1} / {2}",
                    item.Id,
                    item.Name,
                    item.Category.ToDisplayName()));

            if (histories.Count == 0)
            {
                Console.WriteLine("貸出履歴はありません。");
                return;
            }

            Console.WriteLine("借主\t貸出日\t返却予定日\t返却日\t状態");
            foreach (var rental in histories)
            {
                var status = rental.ReturnDate.HasValue ? "返却済み" : "貸出中";
                Console.WriteLine(
                    string.Format(
                        "{0}\t{1}\t{2}\t{3}\t{4}",
                        rental.BorrowerName,
                        DisplayFormatter.Date(rental.RentalDate),
                        DisplayFormatter.Date(rental.DueDate),
                        DisplayFormatter.OptionalDate(rental.ReturnDate),
                        status));
            }
        }
    }
}
