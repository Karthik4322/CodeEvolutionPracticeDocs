using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrganicShopBackend.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string Name { get; set; }

        // Make Username optional by changing it to string?
        public string? Username { get; set; } // Nullable Username

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string Role { get; set; } = "User ";
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}