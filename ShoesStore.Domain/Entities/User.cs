using ShoesStore.Domain.Common;

namespace ShoesStore.Domain.Entities;

public class User : BaseEntity
{
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;

    public string Role { get; set; } = "Customer";
}