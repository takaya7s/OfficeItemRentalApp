namespace OfficeItemRentalApp.Models
{
    public sealed class Item
    {
        public Item()
        {
            Id = string.Empty;
            Name = string.Empty;
            Category = ItemCategory.Other;
        }

        public Item(string id, string name, ItemCategory category)
        {
            Id = id;
            Name = name;
            Category = category;
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public ItemCategory Category { get; set; }
    }
}
