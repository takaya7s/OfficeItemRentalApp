namespace OfficeItemRentalApp.Models
{
    public enum ItemCategory
    {
        Pc,
        Projector,
        Other
    }

    internal static class ItemCategoryExtensions
    {
        public static string ToDisplayName(this ItemCategory category)
        {
            switch (category)
            {
                case ItemCategory.Pc:
                    return "PC";
                case ItemCategory.Projector:
                    return "プロジェクター";
                case ItemCategory.Other:
                default:
                    return "その他";
            }
        }
    }
}
