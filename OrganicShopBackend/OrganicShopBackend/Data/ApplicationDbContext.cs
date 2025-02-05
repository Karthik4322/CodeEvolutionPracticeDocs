using Microsoft.EntityFrameworkCore;
using OrganicShopBackend.Models;

namespace OrganicShopBackend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Cart> Carts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Defining relationships
            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Product)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(oi => oi.ProductId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent deletion of product if it exists in an order item

            modelBuilder.Entity<Cart>()
                .HasOne(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Cart>()
                .HasOne(c => c.Product)
                .WithMany()
                .HasForeignKey(c => c.ProductId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent deletion of product if it exists in the cart

           

            // Seeding Admin user
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    Name = "Freshio",
                    Username = null,  
                    Email = "saiakash200236@gmail.com",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("AdminPassword123"),  // Password (hashed)
                    PhoneNumber = "1234567890",  // Example phone number
                    Role = "Admin",  // Role set to Admin
                    Address = "123 Admin Street"
                }
            );

            // Seeding Products
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Title = "Potatoes",
                    Description = "Versatile and starchy potatoes, great for roasting, mashing, or as a side dish.",
                    Category = "vegetables",
                    Price = 45M,
                    DiscountPercentage = 4.05M,
                    Rating = 3.82,
                    QuantityInStock = 8,
                    Sku = "W4NOBW45",
                    Weight = 250,
                    WarrantyInformation = "5 year warranty",
                    ShippingInformation = "Ships in 1-2 business days",
                    AvailabilityStatus = "In Stock",
                    ReturnPolicy = "7 days return policy",
                    MinimumOrderQuantity = 29,
                    Images = new List<string> { "https://cdn.dummyjson.com/products/images/groceries/Potatoes/1.png" },
                    Thumbnail = "https://cdn.dummyjson.com/products/images/groceries/Potatoes/thumbnail.png",
                    Tags = new List<string> { "vegetables" }
                },
                new Product
                {
                    ProductId = 2,
                    Title = "Red Onions",
                    Description = "Flavorful and aromatic red onions, perfect for adding depth to your savory dishes.",
                    Category = "vegetables",
                    Price = 50M,
                    DiscountPercentage = 17.89M,
                    Rating = 4.08,
                    QuantityInStock = 86,
                    Sku = "TAF870KJ",
                    Weight = 200,
                    WarrantyInformation = "Lifetime warranty",
                    ShippingInformation = "Ships in 2 weeks",
                    AvailabilityStatus = "In Stock",
                    ReturnPolicy = "60 days return policy",
                    MinimumOrderQuantity = 40,
                    Images = new List<string> { "https://cdn.dummyjson.com/products/images/groceries/Red%20Onions/1.png" },
                    Thumbnail = "https://cdn.dummyjson.com/products/images/groceries/Red%20Onions/thumbnail.png",
                    Tags = new List<string> { "vegetables" }
                },
                new Product
                {
                    ProductId = 3,
                    Title = "Cucumber",
                    Description = "Crisp and hydrating cucumbers, ideal for salads, snacks, or as a refreshing side.",
                    Category = "vegetables",
                    Price = 30M,
                    DiscountPercentage = 11.44M,
                    Rating = 4.71,
                    QuantityInStock = 22,
                    Sku = "6KGF2K6Z",
                    Weight = 100,
                    WarrantyInformation = "5 year warranty",
                    ShippingInformation = "Ships overnight",
                    AvailabilityStatus = "In Stock",
                    ReturnPolicy = "30 days return policy",
                    MinimumOrderQuantity = 7,
                    Images = new List<string> { "https://cdn.dummyjson.com/products/images/groceries/Cucumber/1.png" },
                    Thumbnail = "https://cdn.dummyjson.com/products/images/groceries/Cucumber/thumbnail.png",
                    Tags = new List<string> { "vegetables" }
                },
                new Product
                {
                    ProductId = 4,
                    Title = "Broccoli",
                    Description = "Fresh broccoli, packed with vitamins, perfect for healthy meals and salads.",
                    Category = "vegetables",
                    Price = 60M,
                    DiscountPercentage = 12.5M,
                    Rating = 4.5,
                    QuantityInStock = 20,
                    Sku = "0Y4NORN2",
                    Weight = 200,
                    WarrantyInformation = "No warranty applicable",
                    ShippingInformation = "Ships in 1-2 business days",
                    AvailabilityStatus = "In Stock",
                    ReturnPolicy = "7 days return policy",
                    MinimumOrderQuantity = 5,
                    Images = new List<string> { "https://pixabay.com/get/g1b17eba27df6f4f681f4bb1e9ae2102e2e81756e64dc7723a66ca573577f243fb9df0ab1cd83fd529c9535a6f34d6dc08ebe0439c2e2235d7aa2a085f233ab3c_1280.png" },
                    Thumbnail = "https://cdn.dummyjson.com/products/images/vegetables/Broccoli/thumbnail.png",
                    Tags = new List<string> { "greens", "healthy", "vegetables" }
                },
                new Product
                {
                    ProductId = 5,
                    Title = "Tomato",
                    Description = "Fresh and juicy tomatoes, perfect for salads, sauces, and cooking.",
                    Category = "vegetables",
                    Price = 90M,
                    DiscountPercentage = 15.0M,
                    Rating = 4.6,
                    QuantityInStock = 50,
                    Sku = "0T3M0T0",
                    Weight = 250,
                    WarrantyInformation = "No warranty applicable",
                    ShippingInformation = "Ships in 1-2 business days",
                    AvailabilityStatus = "In Stock",
                    ReturnPolicy = "7 days return policy",
                    MinimumOrderQuantity = 10,
                    Images = new List<string> { "https://pixabay.com/get/g3c064f77e6790ec8d35b90cae5f245790c9bcb61588e055cc39f91d53a2e6aa2a0eca0cdfea5674c2d92b96f107fc037a46e7552a1d64c77e84ebaeb77a49ca7_1280.png" },
                    Thumbnail = "https://cdn.dummyjson.com/products/images/vegetables/Tomato/thumbnail.png",
                    Tags = new List<string> { "fresh", "vegetables", "rich in vitamins" }
                },
                new Product
                {
                    ProductId = 6,
                    Title = "Carrot",
                    Description = "Crunchy and sweet carrots, rich in beta-carotene, ideal for snacks and cooking.",
                    Category = "vegetables",
                    Price = 50M,
                    DiscountPercentage = 5.0M,
                    Rating = 4.8,
                    QuantityInStock = 40,
                    Sku = "0C4R0T0",
                    Weight = 250,
                    WarrantyInformation = "No warranty applicable",
                    ShippingInformation = "Ships in 1-2 business days",
                    AvailabilityStatus = "In Stock",
                    ReturnPolicy = "7 days return policy",
                    MinimumOrderQuantity = 5,
                    Images = new List<string> { "https://pixabay.com/get/g713b394cac9b414df164d361727e3efd2c02e91ba69ce979f2b3de1f196ea6458edd2c85a9d69ebd03c01f480eceabee2e0c28d45705c6113e1dde2697da991d_1280.jpg" },
                    Thumbnail = "https://cdn.dummyjson.com/products/images/vegetables/Carrot/thumbnail.png",
                    Tags = new List<string> { "snack", "healthy", "vegetables" }
                },
        new Product
        {
            ProductId = 7,
            Title = "Milk",
            Description = "Fresh and nutritious milk, a staple for various recipes and daily consumption.",
            Category = "dairy",
            Price = 35M,
            DiscountPercentage = 15.09M,
            Rating = 3.14,
            QuantityInStock = 57,
            Sku = "VOZKMF40",
            Weight = 500,
            WarrantyInformation = "6 months warranty",
            ShippingInformation = "Ships in 1 month",
            AvailabilityStatus = "In Stock",
            ReturnPolicy = "7 days return policy",
            MinimumOrderQuantity = 41,
            Images = new List<string> { "https://cdn.dummyjson.com/products/images/groceries/Milk/1.png" },
            Thumbnail = "https://cdn.dummyjson.com/products/images/groceries/Milk/thumbnail.png",
            Tags = new List<string> { "dairy" }
        },
        new Product
        {
            ProductId = 8,
            Title = "Ghee",
            Description = "Pure and clarified butter, perfect for cooking and traditional dishes.",
            Category = "dairy",
            Price = 400M,
            DiscountPercentage = 12.5M,
            Rating = 4.7,
            QuantityInStock = 40,
            Sku = "GH3E5E",
            Weight = 500,
            WarrantyInformation = "No warranty applicable",
            ShippingInformation = "Ships in 1 week",
            AvailabilityStatus = "In Stock",
            ReturnPolicy = "30 days return policy",
            MinimumOrderQuantity = 1,
            Images = new List<string> { "https://pixabay.com/get/gb796cbed853e0edb1ee5fcd8ae9c0ddd4b6652f9bce82f7c0ab829b09c340c6f67940709695379bfe59f64703d3886c47d418f83ccb097cc27a13179e463eca6_1280.png" },
            Thumbnail = "https://cdn.dummyjson.com/products/images/groceries/Ghee/thumbnail.png",
            Tags = new List<string> { "dairy" }
        },
        new Product
        {
            ProductId = 9,
            Title = "Butter",
            Description = "Rich and creamy butter, perfect for spreading or cooking.",
            Category = "dairy",
            Price = 270M,
            DiscountPercentage = 5.0M,
            Rating = 4.6,
            QuantityInStock = 25,
            Sku = "BU8T7E",
            Weight = 250,
            WarrantyInformation = "No warranty applicable",
            ShippingInformation = "Ships in 1 week",
            AvailabilityStatus = "In Stock",
            ReturnPolicy = "30 days return policy",
            MinimumOrderQuantity = 1,
            Images = new List<string> { "https://pixabay.com/get/g0fe29c8175f0a328a0063543a59b8ed05969958ee207305345f77722466c21566b99686b2ae94838653e8d978208e83e7a1f0545384a2272e5f78c43b83e317b_1280.png" },
            Thumbnail = "https://cdn.dummyjson.com/products/images/groceries/Butter/thumbnail.png",
            Tags = new List<string> { "dairy" }
        },
        new Product
        {
            ProductId = 10,
            Title = "Cheese",
            Description = "Delicious and creamy cheese, perfect for sandwiches and pizzas.",
            Category = "dairy",
            Price = 300M,
            DiscountPercentage = 7.5M,
            Rating = 4.9,
            QuantityInStock = 20,
            Sku = "CH4E3S",
            Weight = 200,
            WarrantyInformation = "No warranty applicable",
            ShippingInformation = "Ships in 1 week",
            AvailabilityStatus = "In Stock",
            ReturnPolicy = "30 days return policy",
            MinimumOrderQuantity = 1,
            Images = new List<string> { "https://pixabay.com/get/g58d541b341f4855eca50fc2fd226a42905d8362edd911572e5a6cec58c87fe97973963afa2789fa56b84882f3609254305330af9edf16ce5d9a05c071d175434_1280.png" },
            Thumbnail = "https://cdn.dummyjson.com/products/images/groceries/Cheese/thumbnail.png",
            Tags = new List<string> { "dairy" }
        },
        new Product
        {
            ProductId = 11,
            Title = "Yogurt",
            Description = "Creamy and tangy yogurt, a great addition to smoothies and desserts.",
            Category = "dairy   ",
            Price = 75M,
            DiscountPercentage = 10.0M,
            Rating = 4.3,
            QuantityInStock = 60,
            Sku = "YO3G5T",
            Weight = 100,
            WarrantyInformation = "No warranty applicable",
            ShippingInformation = "Ships in 1 week",
            AvailabilityStatus = "In Stock",
            ReturnPolicy = "30 days return policy",
            MinimumOrderQuantity = 1,
            Images = new List<string> { "https://pixabay.com/get/g545d9d935daf898002d64100c46d0f8a63b64773a4b29c2b127bb36d55911623ec678b351909db690a4b6ccb141c5c0cfaacea4d47e43b0cc4d3aa18095c049c_1280.png" },
            Thumbnail = "https://cdn.dummyjson.com/products/images/groceries/Yogurt/thumbnail.png",
            Tags = new List<string> { "dairy" }
        },



        new Product
        {
            ProductId = 12,
            Title = "Chicken Meat",
            Description = "Fresh and tender chicken meat, suitable for various culinary preparations.",
            Category = "eggandmeat",
        Price = 110M,
            DiscountPercentage = 10.46M,
            Rating = 4.61,
            QuantityInStock = 69,
            Sku = "G5YEHW7B",
            Weight = 250,
            WarrantyInformation = "Lifetime warranty",
            ShippingInformation = "Ships in 1 month",
            AvailabilityStatus = "In Stock",
            ReturnPolicy = "7 days return policy",
            MinimumOrderQuantity = 46,
            Images = new List<string> { "https://cdn.dummyjson.com/products/images/groceries/Chicken%20Meat/1.png",
                      "https://cdn.dummyjson.com/products/images/groceries/Chicken%20Meat/2.png"
                    },
            Thumbnail = "https://cdn.dummyjson.com/products/images/groceries/Chicken%20Meat/thumbnail.png",
            Tags = new List<string> { "Non-veg" }
        },

        new Product
        {
            ProductId = 13,
            Title = "Eggs",
            Description = "Fresh eggs, a versatile ingredient for baking, cooking, or breakfast.",
            Category = "eggandmeat",
            Price = 6M,
            DiscountPercentage = 5.8M,
            Rating = 4.46,
            QuantityInStock = 10,
            Sku = "YA617RI7",
            Weight = 4,
            WarrantyInformation = "3 year warranty",
            ShippingInformation = "Ships overnight",
            AvailabilityStatus = "In Stock",
            ReturnPolicy = "30 days return policy",
            MinimumOrderQuantity = 43,
            Images = new List<string> { "https://cdn.dummyjson.com/products/images/groceries/Eggs/1.png" },
            Thumbnail = "https://cdn.dummyjson.com/products/images/groceries/Eggs/thumbnail.png",
            Tags = new List<string> { "Non-veg" }
        },

        new Product
        {
            ProductId = 14,
            Title = "Fish Steak",
            Description = "Quality fish steak, suitable for grilling, baking, or pan-searing.",
            Category = "eggandmeat",
            Price = 70M,
            DiscountPercentage = 7M,
            Rating = 4.83,
            QuantityInStock = 99,
            Sku = "XNIH1MTA",
            Weight = 8,
            WarrantyInformation = "1 year warranty",
            ShippingInformation = "Ships in 1 month",
            AvailabilityStatus = "In Stock",
            ReturnPolicy = "30 days return policy",
            MinimumOrderQuantity = 49,
            Images = new List<string> { "https://cdn.dummyjson.com/products/images/groceries/Fish%20Steak/1.png" },
            Thumbnail = "https://cdn.dummyjson.com/products/images/groceries/Fish%20Steak/thumbnail.png",
            Tags = new List<string> { "Non-veg" }
        },

        new Product
        {
            ProductId = 15,
            Title = "Green Bell Pepper",
            Description = "Fresh and vibrant green bell pepper, perfect for adding color and flavor to your dishes.",
            Category = "vegetables",
            Price = 20M,
            DiscountPercentage = 15.5M,
            Rating = 4.28,
            QuantityInStock = 89,
            Sku = "HU7S7VQ0",
            Weight = 50,
            WarrantyInformation = "5 year warranty",
            ShippingInformation = "Ships overnight",
            AvailabilityStatus = "In Stock",
            ReturnPolicy = "30 days return policy",
            MinimumOrderQuantity = 1,
            Images = new List<string> { "https://cdn.dummyjson.com/products/images/groceries/Green%20Bell%20Pepper/1.png" },
            Thumbnail = "https://cdn.dummyjson.com/products/images/groceries/Green%20Bell%20Pepper/thumbnail.png",
            Tags = new List<string> { "Vegetables" }
        },

        new Product
        {
            ProductId = 16,
            Title = "Green Chili Pepper",
            Description = "Spicy green chili pepper, ideal for adding heat to your favorite recipes.",
            Category = "vegetables",
            Price = 30M,
            DiscountPercentage = 18.51M,
            Rating = 4.43,
            QuantityInStock = 8,
            Sku = "Y4RM3JCB",
            Weight = 100,
            WarrantyInformation = "No warranty",
            ShippingInformation = "Ships in 1-2 business days",
            AvailabilityStatus = "In Stock",
            ReturnPolicy = "30 days return policy",
            MinimumOrderQuantity = 43,
            Images = new List<string> { "https://cdn.dummyjson.com/products/images/groceries/Green%20Chili%20Pepper/1.png" },
            Thumbnail = "https://cdn.dummyjson.com/products/images/groceries/Green%20Chili%20Pepper/thumbnail.png",
            Tags = new List<string> { "Vegetables" }
        },

        new Product
        {
            ProductId = 17,
            Title = "Kiwi",
            Description = "Nutrient-rich kiwi, perfect for snacking or adding a tropical twist to your dishes.",
            Category = "fruits",
            Price = 100M,
            DiscountPercentage = 10.32M,
            Rating = 4.37,
            QuantityInStock = 10,
            Sku = "0X3NORB9",
            Weight = 250,
            WarrantyInformation = "6 months warranty",
            ShippingInformation = "Ships in 3-5 business days",
            AvailabilityStatus = "Low Stock",
            ReturnPolicy = "7 days return policy",
            MinimumOrderQuantity = 8,
            Images = new List<string> { "https://cdn.dummyjson.com/products/images/groceries/Kiwi/1.png" },
            Thumbnail = "https://cdn.dummyjson.com/products/images/groceries/Kiwi/thumbnail.png",
            Tags = new List<string> { "Fruits" }
        },

        new Product
        {
            ProductId = 18,
            Title = "Lemon",
            Description = "Zesty and tangy lemons, versatile for cooking, baking, or making refreshing beverages.",
            Category = "fruits",
            Price = 10M,
            DiscountPercentage = 17.81M,
            Rating = 4.25,
            QuantityInStock = 0,
            Sku = "J074TE3H",
            Weight = 20,
            WarrantyInformation = "3 year warranty",
            ShippingInformation = "Ships in 1 week",
            AvailabilityStatus = "Out of Stock",
            ReturnPolicy = "90 days return policy",
            MinimumOrderQuantity = 1,
            Images = new List<string> { "https://cdn.dummyjson.com/products/images/groceries/Lemon/1.png" },
            Thumbnail = "https://cdn.dummyjson.com/products/images/groceries/Lemon/thumbnail.png",
            Tags = new List<string> { "Fruits" }
        },

        new Product
        {
            ProductId = 19,
            Title = "Mulberry",
            Description = "Sweet and juicy mulberries, perfect for snacking or adding to desserts and cereals.",
            Category = "fruits",
            Price = 75M,
            DiscountPercentage = 16.35M,
            Rating = 3.19,
            QuantityInStock = 79,
            Sku = "0M1K7RRC",
            Weight = 50,
            WarrantyInformation = "3 months warranty",
            ShippingInformation = "Ships in 1 month",
            AvailabilityStatus = "In Stock",
            ReturnPolicy = "60 days return policy",
            MinimumOrderQuantity = 50,
            Images = new List<string> { "https://cdn.dummyjson.com/products/images/groceries/Mulberry/1.png" },
            Thumbnail = "https://cdn.dummyjson.com/products/images/groceries/Mulberry/thumbnail.png",
            Tags = new List<string> { "Fruits" }
        },

        new Product
        {
            ProductId = 20,
            Title = "Strawberry",
            Description = "Sweet and succulent strawberries, great for snacking, desserts, or blending into smoothies.",
            Category = "fruits",
            Price = 150M,
            DiscountPercentage = 19.59M,
            Rating = 4.5,
            QuantityInStock = 9,
            Sku = "LPP7I4JZ",
            Weight = 200,
            WarrantyInformation = "1 year warranty",
            ShippingInformation = "Ships in 1 week",
            AvailabilityStatus = "In Stock",
            ReturnPolicy = "30 days return policy",
            MinimumOrderQuantity = 38,
            Images = new List<string> { "https://cdn.dummyjson.com/products/images/groceries/Strawberry/1.png" },
            Thumbnail = "https://cdn.dummyjson.com/products/images/groceries/Strawberry/thumbnail.png",
            Tags = new List<string> { "Fruits" }
        },

        new Product
        {
            ProductId = 21,
            Title = "Apple",
            Description = "Crisp and juicy apples, perfect for snacking or adding to salads.",
            Category = "fruits",
            Price = 200M,
            DiscountPercentage = 10.0M,
            Rating = 4.8,
            QuantityInStock = 50,
            Sku = "AP5L8E23",
            Weight = 250,
            WarrantyInformation = "No warranty applicable",
            ShippingInformation = "Ships in 1-3 business days",
            AvailabilityStatus = "In Stock",
            ReturnPolicy = "30 days return policy",
            MinimumOrderQuantity = 1,
            Images = new List<string> { "https://pixabay.com/get/g123a55ae86d8fe724f0b0a87785a6cbe66b413cfccb31c473977562e332ded9415929891f9774e90dc4609b8a74a009f_1280.png" },
            Thumbnail = "https://cdn.dummyjson.com/products/images/groceries/Apple/thumbnail.png",
            Tags = new List<string> { "Fruits" }
        },

        new Product
        {
            ProductId = 22,
            Title = "Banana",
            Description = "Fresh and ripe bananas, rich in potassium, perfect for snacking or smoothies.",
            Category = "fruits",
            Price = 25M,
            DiscountPercentage = 10.0M,
            Rating = 4.8,
            QuantityInStock = 100,
            Sku = "BA7A9M23",
            Weight = 30,
            WarrantyInformation = "No warranty applicable",
            ShippingInformation = "Ships in 1-3 business days",
            AvailabilityStatus = "In Stock",
            ReturnPolicy = "30 days return policy",
            MinimumOrderQuantity = 1,
            Images = new List<string> { "https://pixabay.com/get/g07fbaaf5af87cb8fa5b72f6170f5ce044d2df78825c7c506b649e7d151396ddcb93b19c7cdf77fb84879e65e72eff861_1280.png" },
            Thumbnail = "https://cdn.dummyjson.com/products/images/groceries/Banana/thumbnail.png",
            Tags = new List<string> { "Fruits" }
        }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
    }

