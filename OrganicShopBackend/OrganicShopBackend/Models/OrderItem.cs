using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrganicShopBackend.Models
{
    [Table("OrderItems")]
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }  // Primary key for the OrderItem

        [Required, ForeignKey("Order")]
        public int OrderId { get; set; }  // Foreign key to the Order

        public Order Order { get; set; }  // Navigation property for the related Order

        [Required, ForeignKey("Product")]
        public int ProductId { get; set; }  // Foreign key to the Product

        public Product Product { get; set; }  // Navigation property for the related Product

        [Required]
        public int Quantity { get; set; }  // Quantity of the product in the order

        [Required]
        public decimal Price { get; set; }  // Price of the product at the time of the order

        // Optional: Calculate Subtotal (Quantity * Price) for the order item
        public decimal Subtotal => Quantity * Price;
    }
}
