using ShoesStore.Domain.Common;

namespace ShoesStore.Domain.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }

    // Foreign Key
    public int CategoryId { get; set; }

    // Navigation Property
    public Category Category { get; set; } = null!;
}