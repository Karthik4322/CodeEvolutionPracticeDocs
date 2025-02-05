using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganicShopBackend.Data;
using OrganicShopBackend.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OrganicShopBackend.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ProductController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env; // Used to access the wwwroot folder for saving images
        }

        // Get all products
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }

        // Get product by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }

        // Create a new product with image upload
        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromForm] ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Save the uploaded images to the server
            var imageUrls = new List<string>();
            if (request.Images != null && request.Images.Count > 0)
            {
                foreach (var image in request.Images)
                {
                    if (image.Length > 0)
                    {
                        var uploadsFolder = Path.Combine(_env.WebRootPath, "uploads");
                        if (!Directory.Exists(uploadsFolder))
                            Directory.CreateDirectory(uploadsFolder);

                        var uniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;
                        var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await image.CopyToAsync(fileStream);
                        }

                        imageUrls.Add($"/uploads/{uniqueFileName}");
                    }
                }
            }

            // Create the product entity
            var product = new Product
            {
                Title = request.Title,
                Description = request.Description,
                Price = request.Price,
                DiscountPercentage = request.DiscountPercentage,
                Rating = request.Rating,
                QuantityInStock = request.QuantityInStock,
                Sku = request.Sku,
                Weight = request.Weight,
                WarrantyInformation = request.WarrantyInformation,
                ShippingInformation = request.ShippingInformation,
                AvailabilityStatus = request.AvailabilityStatus,
                ReturnPolicy = request.ReturnPolicy,
                MinimumOrderQuantity = request.MinimumOrderQuantity,
                Images = imageUrls,
                Thumbnail = imageUrls.FirstOrDefault(), // Set the first image as the thumbnail
                Category = request.Category,
                Tags = request.Tags
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProductById), new { id = product.ProductId }, product);
        }
    }

    // Request model for creating a product with image uploads
    public class ProductCreateRequest
    {
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public decimal DiscountPercentage { get; set; }
        public double Rating { get; set; }

        [Required]
        public int QuantityInStock { get; set; }

        public string Sku { get; set; }
        public double Weight { get; set; }
        public string WarrantyInformation { get; set; }
        public string ShippingInformation { get; set; }
        public string AvailabilityStatus { get; set; }
        public string ReturnPolicy { get; set; }
        public int MinimumOrderQuantity { get; set; }

        public List<IFormFile> Images { get; set; } // For image uploads

        public string Category { get; set; }
        public List<string> Tags { get; set; }
    }
}