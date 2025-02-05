using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrganicShopBackend.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]  // Title is required
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]  // Price is required
        public decimal Price { get; set; }

        public decimal DiscountPercentage { get; set; }
        public double Rating { get; set; }

        [Required]  // QuantityInStock is required
        public int QuantityInStock { get; set; }

       
        public string? Sku { get; set; }

        public double Weight { get; set; }
        public string WarrantyInformation { get; set; }
        public string ShippingInformation { get; set; }
        public string AvailabilityStatus { get; set; }
        public string ReturnPolicy { get; set; }
        public int MinimumOrderQuantity { get; set; }

        [Required]  // Image URLs are required
        public List<string> Images { get; set; }

        public string Thumbnail { get; set; }

        // Optional properties can be nullable
        public string Category { get; set; }
        public List<string> Tags { get; set; }

        // Navigation property to link product with order items
        public List<OrderItem> OrderItems { get; set; }
    }

    
}
