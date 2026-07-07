using System;
using System.Globalization;

namespace OfficeItemRentalApp.CLI.ConsoleUI
{
    internal static class DisplayFormatter
    {
        public static string Date(DateTime date)
        {
            return date.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);
        }

        public static string OptionalDate(DateTime? date)
        {
            return date.HasValue ? Date(date.Value) : "-";
        }

        public static string Reminder(bool isOverdue)
        {
            return isOverdue ? "督促対象" : "-";
        }
    }
}
