using ShoesStore.Domain.Common;

namespace ShoesStore.Domain.Entities;

public class Order : BaseEntity
{
    public int UserId { get; set; }
    public decimal TotalAmount { get; set; }

    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}