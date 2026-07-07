using System;
using System.Globalization;
using OfficeItemRentalApp.Models;

namespace OfficeItemRentalApp.CLI.ConsoleUI
{
    public static class ConsoleInput
    {
        public static string ReadRequiredText(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                var value = Console.ReadLine();
                value = value == null ? string.Empty : value.Trim();

                if (!string.IsNullOrWhiteSpace(value))
                {
                    return value;
                }

                Console.WriteLine("入力は必須です。");
            }
        }

        public static ItemCategory ReadCategory()
        {
            while (true)
            {
                Console.WriteLine("区分を選択してください。");
                Console.WriteLine("1. PC");
                Console.WriteLine("2. プロジェクター");
                Console.WriteLine("3. その他");
                Console.Write("番号: ");

                var selected = Console.ReadLine();
                selected = selected == null ? string.Empty : selected.Trim();

                switch (selected)
                {
                    case "1":
                        return ItemCategory.Pc;
                    case "2":
                        return ItemCategory.Projector;
                    case "3":
                        return ItemCategory.Other;
                    default:
                        Console.WriteLine("1～3の番号を入力してください。");
                        break;
                }
            }
        }

        public static DateTime ReadDate(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                var value = Console.ReadLine();
                value = value == null ? string.Empty : value.Trim();

                DateTime date;
                if (TryParseDate(value, out date))
                {
                    return date.Date;
                }

                Console.WriteLine("日付は yyyy/MM/dd、yyyy-MM-dd、yyyyMMdd のいずれかで入力してください。");
            }
        }

        public static DateTime ReadDateOrDefault(string prompt, DateTime defaultDate)
        {
            while (true)
            {
                Console.Write(prompt);
                var value = Console.ReadLine();
                value = value == null ? string.Empty : value.Trim();

                if (string.IsNullOrWhiteSpace(value))
                {
                    return defaultDate.Date;
                }

                DateTime date;
                if (TryParseDate(value, out date))
                {
                    return date.Date;
                }

                Console.WriteLine("日付は yyyy/MM/dd、yyyy-MM-dd、yyyyMMdd のいずれかで入力してください。");
            }
        }

        public static void WaitForEnter()
        {
            Console.WriteLine();
            Console.Write("Enterキーでメニューに戻ります...");
            Console.ReadLine();
        }

        private static bool TryParseDate(string value, out DateTime date)
        {
            var formats = new[] { "yyyy/MM/dd", "yyyy/M/d", "yyyy-MM-dd", "yyyy-M-d", "yyyyMMdd" };
            return DateTime.TryParseExact(
                value,
                formats,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out date);
        }
    }
}
