using ShoesStore.Domain.Common;

namespace ShoesStore.Domain.Entities;

public class OrderItem : BaseEntity
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }

    public Product Product { get; set; } = null!;
}