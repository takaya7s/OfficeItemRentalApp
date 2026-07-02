using System.Collections.Generic;

namespace OfficeItemRentalApp.Models
{
    public sealed class RentalDatabase
    {
        public RentalDatabase()
        {
            Items = new List<Item>();
            Rentals = new List<RentalRecord>();
        }

        public List<Item> Items { get; set; }

        public List<RentalRecord> Rentals { get; set; }
    }
}
