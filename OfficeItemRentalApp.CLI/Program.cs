using System;
using System.IO;
using System.Text;
using OfficeItemRentalApp.CLI.ConsoleUI;
using OfficeItemRentalApp.Services;

namespace OfficeItemRentalApp.CLI
{
    internal static class Program
    {
        private static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var dataPath = Path.Combine(Directory.GetCurrentDirectory(), "data", "item-rentals.json");
            var store = new JsonDataStore(dataPath);

            try
            {
                var database = store.Load();
                var rentalService = new ItemRentalService(database, store);
                var app = new ItemRentalConsoleApp(rentalService);

                app.Run();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("データファイルを確認してから再実行してください。");
            }
        }
    }
}
