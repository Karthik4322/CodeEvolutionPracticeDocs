using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrganicShopBackend.Migrations
{
    /// <inheritdoc />
    public partial class makesjuoptional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Sku",
                table: "Products",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Category",
                value: "vegetables");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "Category",
                value: "vegetables");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "Category",
                value: "vegetables");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "Category",
                value: "dairy");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "Category",
                value: "dairy");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "Category",
                value: "dairy");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "Category",
                value: "dairy");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "Category",
                value: "dairy   ");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "Category", "Description", "DiscountPercentage", "Images", "MinimumOrderQuantity", "Price", "QuantityInStock", "Rating", "ShippingInformation", "Sku", "Tags", "Thumbnail", "Title", "WarrantyInformation" },
                values: new object[] { "eggandmeat", "Fresh and tender chicken meat, suitable for various culinary preparations.", 10.46m, "[\"https://cdn.dummyjson.com/products/images/groceries/Chicken%20Meat/1.png\",\"https://cdn.dummyjson.com/products/images/groceries/Chicken%20Meat/2.png\"]", 46, 110m, 69, 4.6100000000000003, "Ships in 1 month", "G5YEHW7B", "[\"Non-veg\"]", "https://cdn.dummyjson.com/products/images/groceries/Chicken%20Meat/thumbnail.png", "Chicken Meat", "Lifetime warranty" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "Category", "Description", "DiscountPercentage", "Images", "MinimumOrderQuantity", "Price", "QuantityInStock", "Rating", "ReturnPolicy", "ShippingInformation", "Sku", "Tags", "Thumbnail", "Title", "WarrantyInformation", "Weight" },
                values: new object[] { "eggandmeat", "Fresh eggs, a versatile ingredient for baking, cooking, or breakfast.", 5.8m, "[\"https://cdn.dummyjson.com/products/images/groceries/Eggs/1.png\"]", 43, 6m, 10, 4.46, "30 days return policy", "Ships overnight", "YA617RI7", "[\"Non-veg\"]", "https://cdn.dummyjson.com/products/images/groceries/Eggs/thumbnail.png", "Eggs", "3 year warranty", 4.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "Category", "Description", "DiscountPercentage", "Images", "MinimumOrderQuantity", "Price", "QuantityInStock", "Rating", "ShippingInformation", "Sku", "Tags", "Thumbnail", "Title", "WarrantyInformation", "Weight" },
                values: new object[] { "eggandmeat", "Quality fish steak, suitable for grilling, baking, or pan-searing.", 7m, "[\"https://cdn.dummyjson.com/products/images/groceries/Fish%20Steak/1.png\"]", 49, 70m, 99, 4.8300000000000001, "Ships in 1 month", "XNIH1MTA", "[\"Non-veg\"]", "https://cdn.dummyjson.com/products/images/groceries/Fish%20Steak/thumbnail.png", "Fish Steak", "1 year warranty", 8.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "Description", "DiscountPercentage", "Images", "MinimumOrderQuantity", "Price", "QuantityInStock", "Rating", "ReturnPolicy", "ShippingInformation", "Sku", "Tags", "Thumbnail", "Title", "WarrantyInformation", "Weight" },
                values: new object[] { "Fresh and vibrant green bell pepper, perfect for adding color and flavor to your dishes.", 15.5m, "[\"https://cdn.dummyjson.com/products/images/groceries/Green%20Bell%20Pepper/1.png\"]", 1, 20m, 89, 4.2800000000000002, "30 days return policy", "Ships overnight", "HU7S7VQ0", "[\"Vegetables\"]", "https://cdn.dummyjson.com/products/images/groceries/Green%20Bell%20Pepper/thumbnail.png", "Green Bell Pepper", "5 year warranty", 50.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "Description", "DiscountPercentage", "Images", "MinimumOrderQuantity", "Price", "QuantityInStock", "Rating", "ReturnPolicy", "Sku", "Tags", "Thumbnail", "Title", "WarrantyInformation", "Weight" },
                values: new object[] { "Spicy green chili pepper, ideal for adding heat to your favorite recipes.", 18.51m, "[\"https://cdn.dummyjson.com/products/images/groceries/Green%20Chili%20Pepper/1.png\"]", 43, 30m, 8, 4.4299999999999997, "30 days return policy", "Y4RM3JCB", "[\"Vegetables\"]", "https://cdn.dummyjson.com/products/images/groceries/Green%20Chili%20Pepper/thumbnail.png", "Green Chili Pepper", "No warranty", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "AvailabilityStatus", "Category", "Description", "DiscountPercentage", "Images", "MinimumOrderQuantity", "Price", "QuantityInStock", "Rating", "ShippingInformation", "Sku", "Tags", "Thumbnail", "Title", "WarrantyInformation" },
                values: new object[] { "Low Stock", "fruits", "Nutrient-rich kiwi, perfect for snacking or adding a tropical twist to your dishes.", 10.32m, "[\"https://cdn.dummyjson.com/products/images/groceries/Kiwi/1.png\"]", 8, 100m, 10, 4.3700000000000001, "Ships in 3-5 business days", "0X3NORB9", "[\"Fruits\"]", "https://cdn.dummyjson.com/products/images/groceries/Kiwi/thumbnail.png", "Kiwi", "6 months warranty" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "AvailabilityStatus", "Category", "Description", "DiscountPercentage", "Images", "MinimumOrderQuantity", "Price", "QuantityInStock", "Rating", "ReturnPolicy", "ShippingInformation", "Sku", "Tags", "Thumbnail", "Title", "WarrantyInformation", "Weight" },
                values: new object[] { "Out of Stock", "fruits", "Zesty and tangy lemons, versatile for cooking, baking, or making refreshing beverages.", 17.81m, "[\"https://cdn.dummyjson.com/products/images/groceries/Lemon/1.png\"]", 1, 10m, 0, 4.25, "90 days return policy", "Ships in 1 week", "J074TE3H", "[\"Fruits\"]", "https://cdn.dummyjson.com/products/images/groceries/Lemon/thumbnail.png", "Lemon", "3 year warranty", 20.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "Category", "Description", "DiscountPercentage", "Images", "MinimumOrderQuantity", "Price", "QuantityInStock", "Rating", "ReturnPolicy", "ShippingInformation", "Sku", "Tags", "Thumbnail", "Title", "WarrantyInformation", "Weight" },
                values: new object[] { "fruits", "Sweet and juicy mulberries, perfect for snacking or adding to desserts and cereals.", 16.35m, "[\"https://cdn.dummyjson.com/products/images/groceries/Mulberry/1.png\"]", 50, 75m, 79, 3.1899999999999999, "60 days return policy", "Ships in 1 month", "0M1K7RRC", "[\"Fruits\"]", "https://cdn.dummyjson.com/products/images/groceries/Mulberry/thumbnail.png", "Mulberry", "3 months warranty", 50.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "Category", "Description", "DiscountPercentage", "Images", "MinimumOrderQuantity", "Price", "QuantityInStock", "Rating", "Sku", "Tags", "Thumbnail", "Title", "WarrantyInformation", "Weight" },
                values: new object[] { "fruits", "Sweet and succulent strawberries, great for snacking, desserts, or blending into smoothies.", 19.59m, "[\"https://cdn.dummyjson.com/products/images/groceries/Strawberry/1.png\"]", 38, 150m, 9, 4.5, "LPP7I4JZ", "[\"Fruits\"]", "https://cdn.dummyjson.com/products/images/groceries/Strawberry/thumbnail.png", "Strawberry", "1 year warranty", 200.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                columns: new[] { "Category", "Description", "DiscountPercentage", "Images", "Price", "QuantityInStock", "Rating", "ShippingInformation", "Sku", "Tags", "Thumbnail", "Title", "Weight" },
                values: new object[] { "fruits", "Crisp and juicy apples, perfect for snacking or adding to salads.", 10.0m, "[\"https://pixabay.com/get/g123a55ae86d8fe724f0b0a87785a6cbe66b413cfccb31c473977562e332ded9415929891f9774e90dc4609b8a74a009f_1280.png\"]", 200m, 50, 4.7999999999999998, "Ships in 1-3 business days", "AP5L8E23", "[\"Fruits\"]", "https://cdn.dummyjson.com/products/images/groceries/Apple/thumbnail.png", "Apple", 250.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                columns: new[] { "Category", "Description", "Images", "Price", "QuantityInStock", "Rating", "ShippingInformation", "Sku", "Tags", "Thumbnail", "Title", "Weight" },
                values: new object[] { "fruits", "Fresh and ripe bananas, rich in potassium, perfect for snacking or smoothies.", "[\"https://pixabay.com/get/g07fbaaf5af87cb8fa5b72f6170f5ce044d2df78825c7c506b649e7d151396ddcb93b19c7cdf77fb84879e65e72eff861_1280.png\"]", 25m, 100, 4.7999999999999998, "Ships in 1-3 business days", "BA7A9M23", "[\"Fruits\"]", "https://cdn.dummyjson.com/products/images/groceries/Banana/thumbnail.png", "Banana", 30.0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "Username" },
                values: new object[] { "$2a$11$Gno8PD6TFJU70mGQzVlwQ.xXh0XE6ZWqL9ErDiKZJ6mMipLCyr6Y6", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: null,
                column: "Username",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "PhoneNumber",
                keyValue: null,
                column: "PhoneNumber",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Address",
                keyValue: null,
                column: "Address",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Sku",
                keyValue: null,
                column: "Sku",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Sku",
                table: "Products",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Category",
                value: "groceries");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "Category",
                value: "groceries");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "Category",
                value: "groceries");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "Category",
                value: "groceries");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "Category",
                value: "groceries");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "Category",
                value: "groceries");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "Category",
                value: "groceries");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "Category",
                value: "groceries");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "Category", "Description", "DiscountPercentage", "Images", "MinimumOrderQuantity", "Price", "QuantityInStock", "Rating", "ShippingInformation", "Sku", "Tags", "Thumbnail", "Title", "WarrantyInformation" },
                values: new object[] { "groceries", "Versatile and starchy potatoes, great for roasting, mashing, or as a side dish.", 4.05m, "[\"https://cdn.dummyjson.com/products/images/groceries/Potatoes/1.png\"]", 29, 45m, 8, 3.8199999999999998, "Ships in 1-2 business days", "W4NOBW45", "[\"vegetables\"]", "https://cdn.dummyjson.com/products/images/groceries/Potatoes/thumbnail.png", "Potatoes", "5 year warranty" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "Category", "Description", "DiscountPercentage", "Images", "MinimumOrderQuantity", "Price", "QuantityInStock", "Rating", "ReturnPolicy", "ShippingInformation", "Sku", "Tags", "Thumbnail", "Title", "WarrantyInformation", "Weight" },
                values: new object[] { "groceries", "Flavorful and aromatic red onions, perfect for adding depth to your savory dishes.", 17.89m, "[\"https://cdn.dummyjson.com/products/images/groceries/Red%20Onions/1.png\"]", 40, 50m, 86, 4.0800000000000001, "60 days return policy", "Ships in 2 weeks", "TAF870KJ", "[\"vegetables\"]", "https://cdn.dummyjson.com/products/images/groceries/Red%20Onions/thumbnail.png", "Red Onions", "Lifetime warranty", 200.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "Category", "Description", "DiscountPercentage", "Images", "MinimumOrderQuantity", "Price", "QuantityInStock", "Rating", "ShippingInformation", "Sku", "Tags", "Thumbnail", "Title", "WarrantyInformation", "Weight" },
                values: new object[] { "groceries", "Crisp and hydrating cucumbers, ideal for salads, snacks, or as a refreshing side.", 11.44m, "[\"https://cdn.dummyjson.com/products/images/groceries/Cucumber/1.png\"]", 7, 30m, 22, 4.71, "Ships overnight", "6KGF2K6Z", "[\"vegetables\"]", "https://cdn.dummyjson.com/products/images/groceries/Cucumber/thumbnail.png", "Cucumber", "5 year warranty", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "Description", "DiscountPercentage", "Images", "MinimumOrderQuantity", "Price", "QuantityInStock", "Rating", "ReturnPolicy", "ShippingInformation", "Sku", "Tags", "Thumbnail", "Title", "WarrantyInformation", "Weight" },
                values: new object[] { "Fresh broccoli, packed with vitamins, perfect for healthy meals and salads.", 12.5m, "[\"https://pixabay.com/get/g1b17eba27df6f4f681f4bb1e9ae2102e2e81756e64dc7723a66ca573577f243fb9df0ab1cd83fd529c9535a6f34d6dc08ebe0439c2e2235d7aa2a085f233ab3c_1280.png\"]", 5, 60m, 20, 4.5, "7 days return policy", "Ships in 1-2 business days", "0Y4NORN2", "[\"greens\",\"healthy\",\"vegetables\"]", "https://cdn.dummyjson.com/products/images/vegetables/Broccoli/thumbnail.png", "Broccoli", "No warranty applicable", 200.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "Description", "DiscountPercentage", "Images", "MinimumOrderQuantity", "Price", "QuantityInStock", "Rating", "ReturnPolicy", "Sku", "Tags", "Thumbnail", "Title", "WarrantyInformation", "Weight" },
                values: new object[] { "Fresh and juicy tomatoes, perfect for salads, sauces, and cooking.", 15.0m, "[\"https://pixabay.com/get/g3c064f77e6790ec8d35b90cae5f245790c9bcb61588e055cc39f91d53a2e6aa2a0eca0cdfea5674c2d92b96f107fc037a46e7552a1d64c77e84ebaeb77a49ca7_1280.png\"]", 10, 90m, 50, 4.5999999999999996, "7 days return policy", "0T3M0T0", "[\"fresh\",\"vegetables\",\"rich in vitamins\"]", "https://cdn.dummyjson.com/products/images/vegetables/Tomato/thumbnail.png", "Tomato", "No warranty applicable", 250.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "AvailabilityStatus", "Category", "Description", "DiscountPercentage", "Images", "MinimumOrderQuantity", "Price", "QuantityInStock", "Rating", "ShippingInformation", "Sku", "Tags", "Thumbnail", "Title", "WarrantyInformation" },
                values: new object[] { "In Stock", "vegetables", "Crunchy and sweet carrots, rich in beta-carotene, ideal for snacks and cooking.", 5.0m, "[\"https://pixabay.com/get/g713b394cac9b414df164d361727e3efd2c02e91ba69ce979f2b3de1f196ea6458edd2c85a9d69ebd03c01f480eceabee2e0c28d45705c6113e1dde2697da991d_1280.jpg\"]", 5, 50m, 40, 4.7999999999999998, "Ships in 1-2 business days", "0C4R0T0", "[\"snack\",\"healthy\",\"vegetables\"]", "https://cdn.dummyjson.com/products/images/vegetables/Carrot/thumbnail.png", "Carrot", "No warranty applicable" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "AvailabilityStatus", "Category", "Description", "DiscountPercentage", "Images", "MinimumOrderQuantity", "Price", "QuantityInStock", "Rating", "ReturnPolicy", "ShippingInformation", "Sku", "Tags", "Thumbnail", "Title", "WarrantyInformation", "Weight" },
                values: new object[] { "In Stock", "groceries", "Fresh and nutritious milk, a staple for various recipes and daily consumption.", 15.09m, "[\"https://cdn.dummyjson.com/products/images/groceries/Milk/1.png\"]", 41, 35m, 57, 3.1400000000000001, "7 days return policy", "Ships in 1 month", "VOZKMF40", "[\"dairy\"]", "https://cdn.dummyjson.com/products/images/groceries/Milk/thumbnail.png", "Milk", "6 months warranty", 500.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "Category", "Description", "DiscountPercentage", "Images", "MinimumOrderQuantity", "Price", "QuantityInStock", "Rating", "ReturnPolicy", "ShippingInformation", "Sku", "Tags", "Thumbnail", "Title", "WarrantyInformation", "Weight" },
                values: new object[] { "groceries", "Pure and clarified butter, perfect for cooking and traditional dishes.", 12.5m, "[\"https://pixabay.com/get/gb796cbed853e0edb1ee5fcd8ae9c0ddd4b6652f9bce82f7c0ab829b09c340c6f67940709695379bfe59f64703d3886c47d418f83ccb097cc27a13179e463eca6_1280.png\"]", 1, 400m, 40, 4.7000000000000002, "30 days return policy", "Ships in 1 week", "GH3E5E", "[\"dairy\"]", "https://cdn.dummyjson.com/products/images/groceries/Ghee/thumbnail.png", "Ghee", "No warranty applicable", 500.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "Category", "Description", "DiscountPercentage", "Images", "MinimumOrderQuantity", "Price", "QuantityInStock", "Rating", "Sku", "Tags", "Thumbnail", "Title", "WarrantyInformation", "Weight" },
                values: new object[] { "groceries", "Rich and creamy butter, perfect for spreading or cooking.", 5.0m, "[\"https://pixabay.com/get/g0fe29c8175f0a328a0063543a59b8ed05969958ee207305345f77722466c21566b99686b2ae94838653e8d978208e83e7a1f0545384a2272e5f78c43b83e317b_1280.png\"]", 1, 270m, 25, 4.5999999999999996, "BU8T7E", "[\"dairy\"]", "https://cdn.dummyjson.com/products/images/groceries/Butter/thumbnail.png", "Butter", "No warranty applicable", 250.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                columns: new[] { "Category", "Description", "DiscountPercentage", "Images", "Price", "QuantityInStock", "Rating", "ShippingInformation", "Sku", "Tags", "Thumbnail", "Title", "Weight" },
                values: new object[] { "groceries", "Delicious and creamy cheese, perfect for sandwiches and pizzas.", 7.5m, "[\"https://pixabay.com/get/g58d541b341f4855eca50fc2fd226a42905d8362edd911572e5a6cec58c87fe97973963afa2789fa56b84882f3609254305330af9edf16ce5d9a05c071d175434_1280.png\"]", 300m, 20, 4.9000000000000004, "Ships in 1 week", "CH4E3S", "[\"dairy\"]", "https://cdn.dummyjson.com/products/images/groceries/Cheese/thumbnail.png", "Cheese", 200.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                columns: new[] { "Category", "Description", "Images", "Price", "QuantityInStock", "Rating", "ShippingInformation", "Sku", "Tags", "Thumbnail", "Title", "Weight" },
                values: new object[] { "groceries", "Creamy and tangy yogurt, a great addition to smoothies and desserts.", "[\"https://pixabay.com/get/g545d9d935daf898002d64100c46d0f8a63b64773a4b29c2b127bb36d55911623ec678b351909db690a4b6ccb141c5c0cfaacea4d47e43b0cc4d3aa18095c049c_1280.png\"]", 75m, 60, 4.2999999999999998, "Ships in 1 week", "YO3G5T", "[\"dairy\"]", "https://cdn.dummyjson.com/products/images/groceries/Yogurt/thumbnail.png", "Yogurt", 100.0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "Username" },
                values: new object[] { "$2a$11$cm01/YvKO0LMGMcvEMl4oeQux88qi8oyHg1x.ysseoZdbS/SIqRse", "admin" });
        }
    }
}
