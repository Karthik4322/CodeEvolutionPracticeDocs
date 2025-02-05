using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OrganicShopBackend.Migrations
{
    /// <inheritdoc />
    public partial class SeedOrderItemsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StockQuantity",
                table: "Products",
                newName: "QuantityInStock");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "WarrantyInformation");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Products",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "AvailabilityStatus",
                table: "Products",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Products",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountPercentage",
                table: "Products",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Images",
                table: "Products",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "MinimumOrderQuantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Products",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "ReturnPolicy",
                table: "Products",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ShippingInformation",
                table: "Products",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Sku",
                table: "Products",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Products",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Thumbnail",
                table: "Products",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "Products",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AvailabilityStatus", "Category", "Description", "DiscountPercentage", "Images", "MinimumOrderQuantity", "Price", "QuantityInStock", "Rating", "ReturnPolicy", "ShippingInformation", "Sku", "Tags", "Thumbnail", "Title", "WarrantyInformation", "Weight" },
                values: new object[,]
                {
                    { 1, "In Stock", "groceries", "Versatile and starchy potatoes, great for roasting, mashing, or as a side dish.", 4.05m, "[\"https://cdn.dummyjson.com/products/images/groceries/Potatoes/1.png\"]", 29, 45m, 8, 3.8199999999999998, "7 days return policy", "Ships in 1-2 business days", "W4NOBW45", "[\"vegetables\"]", "https://cdn.dummyjson.com/products/images/groceries/Potatoes/thumbnail.png", "Potatoes", "5 year warranty", 250.0 },
                    { 2, "In Stock", "groceries", "Flavorful and aromatic red onions, perfect for adding depth to your savory dishes.", 17.89m, "[\"https://cdn.dummyjson.com/products/images/groceries/Red%20Onions/1.png\"]", 40, 50m, 86, 4.0800000000000001, "60 days return policy", "Ships in 2 weeks", "TAF870KJ", "[\"vegetables\"]", "https://cdn.dummyjson.com/products/images/groceries/Red%20Onions/thumbnail.png", "Red Onions", "Lifetime warranty", 200.0 },
                    { 3, "In Stock", "groceries", "Crisp and hydrating cucumbers, ideal for salads, snacks, or as a refreshing side.", 11.44m, "[\"https://cdn.dummyjson.com/products/images/groceries/Cucumber/1.png\"]", 7, 30m, 22, 4.71, "30 days return policy", "Ships overnight", "6KGF2K6Z", "[\"vegetables\"]", "https://cdn.dummyjson.com/products/images/groceries/Cucumber/thumbnail.png", "Cucumber", "5 year warranty", 100.0 },
                    { 4, "In Stock", "vegetables", "Fresh broccoli, packed with vitamins, perfect for healthy meals and salads.", 12.5m, "[\"https://pixabay.com/get/g1b17eba27df6f4f681f4bb1e9ae2102e2e81756e64dc7723a66ca573577f243fb9df0ab1cd83fd529c9535a6f34d6dc08ebe0439c2e2235d7aa2a085f233ab3c_1280.png\"]", 5, 60m, 20, 4.5, "7 days return policy", "Ships in 1-2 business days", "0Y4NORN2", "[\"greens\",\"healthy\",\"vegetables\"]", "https://cdn.dummyjson.com/products/images/vegetables/Broccoli/thumbnail.png", "Broccoli", "No warranty applicable", 200.0 },
                    { 5, "In Stock", "vegetables", "Fresh and juicy tomatoes, perfect for salads, sauces, and cooking.", 15.0m, "[\"https://pixabay.com/get/g3c064f77e6790ec8d35b90cae5f245790c9bcb61588e055cc39f91d53a2e6aa2a0eca0cdfea5674c2d92b96f107fc037a46e7552a1d64c77e84ebaeb77a49ca7_1280.png\"]", 10, 90m, 50, 4.5999999999999996, "7 days return policy", "Ships in 1-2 business days", "0T3M0T0", "[\"fresh\",\"vegetables\",\"rich in vitamins\"]", "https://cdn.dummyjson.com/products/images/vegetables/Tomato/thumbnail.png", "Tomato", "No warranty applicable", 250.0 },
                    { 6, "In Stock", "vegetables", "Crunchy and sweet carrots, rich in beta-carotene, ideal for snacks and cooking.", 5.0m, "[\"https://pixabay.com/get/g713b394cac9b414df164d361727e3efd2c02e91ba69ce979f2b3de1f196ea6458edd2c85a9d69ebd03c01f480eceabee2e0c28d45705c6113e1dde2697da991d_1280.jpg\"]", 5, 50m, 40, 4.7999999999999998, "7 days return policy", "Ships in 1-2 business days", "0C4R0T0", "[\"snack\",\"healthy\",\"vegetables\"]", "https://cdn.dummyjson.com/products/images/vegetables/Carrot/thumbnail.png", "Carrot", "No warranty applicable", 250.0 },
                    { 7, "In Stock", "groceries", "Fresh and nutritious milk, a staple for various recipes and daily consumption.", 15.09m, "[\"https://cdn.dummyjson.com/products/images/groceries/Milk/1.png\"]", 41, 35m, 57, 3.1400000000000001, "7 days return policy", "Ships in 1 month", "VOZKMF40", "[\"dairy\"]", "https://cdn.dummyjson.com/products/images/groceries/Milk/thumbnail.png", "Milk", "6 months warranty", 500.0 },
                    { 8, "In Stock", "groceries", "Pure and clarified butter, perfect for cooking and traditional dishes.", 12.5m, "[\"https://pixabay.com/get/gb796cbed853e0edb1ee5fcd8ae9c0ddd4b6652f9bce82f7c0ab829b09c340c6f67940709695379bfe59f64703d3886c47d418f83ccb097cc27a13179e463eca6_1280.png\"]", 1, 400m, 40, 4.7000000000000002, "30 days return policy", "Ships in 1 week", "GH3E5E", "[\"dairy\"]", "https://cdn.dummyjson.com/products/images/groceries/Ghee/thumbnail.png", "Ghee", "No warranty applicable", 500.0 },
                    { 9, "In Stock", "groceries", "Rich and creamy butter, perfect for spreading or cooking.", 5.0m, "[\"https://pixabay.com/get/g0fe29c8175f0a328a0063543a59b8ed05969958ee207305345f77722466c21566b99686b2ae94838653e8d978208e83e7a1f0545384a2272e5f78c43b83e317b_1280.png\"]", 1, 270m, 25, 4.5999999999999996, "30 days return policy", "Ships in 1 week", "BU8T7E", "[\"dairy\"]", "https://cdn.dummyjson.com/products/images/groceries/Butter/thumbnail.png", "Butter", "No warranty applicable", 250.0 },
                    { 10, "In Stock", "groceries", "Delicious and creamy cheese, perfect for sandwiches and pizzas.", 7.5m, "[\"https://pixabay.com/get/g58d541b341f4855eca50fc2fd226a42905d8362edd911572e5a6cec58c87fe97973963afa2789fa56b84882f3609254305330af9edf16ce5d9a05c071d175434_1280.png\"]", 1, 300m, 20, 4.9000000000000004, "30 days return policy", "Ships in 1 week", "CH4E3S", "[\"dairy\"]", "https://cdn.dummyjson.com/products/images/groceries/Cheese/thumbnail.png", "Cheese", "No warranty applicable", 200.0 },
                    { 11, "In Stock", "groceries", "Creamy and tangy yogurt, a great addition to smoothies and desserts.", 10.0m, "[\"https://pixabay.com/get/g545d9d935daf898002d64100c46d0f8a63b64773a4b29c2b127bb36d55911623ec678b351909db690a4b6ccb141c5c0cfaacea4d47e43b0cc4d3aa18095c049c_1280.png\"]", 1, 75m, 60, 4.2999999999999998, "30 days return policy", "Ships in 1 week", "YO3G5T", "[\"dairy\"]", "https://cdn.dummyjson.com/products/images/groceries/Yogurt/thumbnail.png", "Yogurt", "No warranty applicable", 100.0 },
                    { 12, "In Stock", "groceries", "Versatile and starchy potatoes, great for roasting, mashing, or as a side dish.", 4.05m, "[\"https://cdn.dummyjson.com/products/images/groceries/Potatoes/1.png\"]", 29, 45m, 8, 3.8199999999999998, "7 days return policy", "Ships in 1-2 business days", "W4NOBW45", "[\"vegetables\"]", "https://cdn.dummyjson.com/products/images/groceries/Potatoes/thumbnail.png", "Potatoes", "5 year warranty", 250.0 },
                    { 13, "In Stock", "groceries", "Flavorful and aromatic red onions, perfect for adding depth to your savory dishes.", 17.89m, "[\"https://cdn.dummyjson.com/products/images/groceries/Red%20Onions/1.png\"]", 40, 50m, 86, 4.0800000000000001, "60 days return policy", "Ships in 2 weeks", "TAF870KJ", "[\"vegetables\"]", "https://cdn.dummyjson.com/products/images/groceries/Red%20Onions/thumbnail.png", "Red Onions", "Lifetime warranty", 200.0 },
                    { 14, "In Stock", "groceries", "Crisp and hydrating cucumbers, ideal for salads, snacks, or as a refreshing side.", 11.44m, "[\"https://cdn.dummyjson.com/products/images/groceries/Cucumber/1.png\"]", 7, 30m, 22, 4.71, "30 days return policy", "Ships overnight", "6KGF2K6Z", "[\"vegetables\"]", "https://cdn.dummyjson.com/products/images/groceries/Cucumber/thumbnail.png", "Cucumber", "5 year warranty", 100.0 },
                    { 15, "In Stock", "vegetables", "Fresh broccoli, packed with vitamins, perfect for healthy meals and salads.", 12.5m, "[\"https://pixabay.com/get/g1b17eba27df6f4f681f4bb1e9ae2102e2e81756e64dc7723a66ca573577f243fb9df0ab1cd83fd529c9535a6f34d6dc08ebe0439c2e2235d7aa2a085f233ab3c_1280.png\"]", 5, 60m, 20, 4.5, "7 days return policy", "Ships in 1-2 business days", "0Y4NORN2", "[\"greens\",\"healthy\",\"vegetables\"]", "https://cdn.dummyjson.com/products/images/vegetables/Broccoli/thumbnail.png", "Broccoli", "No warranty applicable", 200.0 },
                    { 16, "In Stock", "vegetables", "Fresh and juicy tomatoes, perfect for salads, sauces, and cooking.", 15.0m, "[\"https://pixabay.com/get/g3c064f77e6790ec8d35b90cae5f245790c9bcb61588e055cc39f91d53a2e6aa2a0eca0cdfea5674c2d92b96f107fc037a46e7552a1d64c77e84ebaeb77a49ca7_1280.png\"]", 10, 90m, 50, 4.5999999999999996, "7 days return policy", "Ships in 1-2 business days", "0T3M0T0", "[\"fresh\",\"vegetables\",\"rich in vitamins\"]", "https://cdn.dummyjson.com/products/images/vegetables/Tomato/thumbnail.png", "Tomato", "No warranty applicable", 250.0 },
                    { 17, "In Stock", "vegetables", "Crunchy and sweet carrots, rich in beta-carotene, ideal for snacks and cooking.", 5.0m, "[\"https://pixabay.com/get/g713b394cac9b414df164d361727e3efd2c02e91ba69ce979f2b3de1f196ea6458edd2c85a9d69ebd03c01f480eceabee2e0c28d45705c6113e1dde2697da991d_1280.jpg\"]", 5, 50m, 40, 4.7999999999999998, "7 days return policy", "Ships in 1-2 business days", "0C4R0T0", "[\"snack\",\"healthy\",\"vegetables\"]", "https://cdn.dummyjson.com/products/images/vegetables/Carrot/thumbnail.png", "Carrot", "No warranty applicable", 250.0 },
                    { 18, "In Stock", "groceries", "Fresh and nutritious milk, a staple for various recipes and daily consumption.", 15.09m, "[\"https://cdn.dummyjson.com/products/images/groceries/Milk/1.png\"]", 41, 35m, 57, 3.1400000000000001, "7 days return policy", "Ships in 1 month", "VOZKMF40", "[\"dairy\"]", "https://cdn.dummyjson.com/products/images/groceries/Milk/thumbnail.png", "Milk", "6 months warranty", 500.0 },
                    { 19, "In Stock", "groceries", "Pure and clarified butter, perfect for cooking and traditional dishes.", 12.5m, "[\"https://pixabay.com/get/gb796cbed853e0edb1ee5fcd8ae9c0ddd4b6652f9bce82f7c0ab829b09c340c6f67940709695379bfe59f64703d3886c47d418f83ccb097cc27a13179e463eca6_1280.png\"]", 1, 400m, 40, 4.7000000000000002, "30 days return policy", "Ships in 1 week", "GH3E5E", "[\"dairy\"]", "https://cdn.dummyjson.com/products/images/groceries/Ghee/thumbnail.png", "Ghee", "No warranty applicable", 500.0 },
                    { 20, "In Stock", "groceries", "Rich and creamy butter, perfect for spreading or cooking.", 5.0m, "[\"https://pixabay.com/get/g0fe29c8175f0a328a0063543a59b8ed05969958ee207305345f77722466c21566b99686b2ae94838653e8d978208e83e7a1f0545384a2272e5f78c43b83e317b_1280.png\"]", 1, 270m, 25, 4.5999999999999996, "30 days return policy", "Ships in 1 week", "BU8T7E", "[\"dairy\"]", "https://cdn.dummyjson.com/products/images/groceries/Butter/thumbnail.png", "Butter", "No warranty applicable", 250.0 },
                    { 21, "In Stock", "groceries", "Delicious and creamy cheese, perfect for sandwiches and pizzas.", 7.5m, "[\"https://pixabay.com/get/g58d541b341f4855eca50fc2fd226a42905d8362edd911572e5a6cec58c87fe97973963afa2789fa56b84882f3609254305330af9edf16ce5d9a05c071d175434_1280.png\"]", 1, 300m, 20, 4.9000000000000004, "30 days return policy", "Ships in 1 week", "CH4E3S", "[\"dairy\"]", "https://cdn.dummyjson.com/products/images/groceries/Cheese/thumbnail.png", "Cheese", "No warranty applicable", 200.0 },
                    { 22, "In Stock", "groceries", "Creamy and tangy yogurt, a great addition to smoothies and desserts.", 10.0m, "[\"https://pixabay.com/get/g545d9d935daf898002d64100c46d0f8a63b64773a4b29c2b127bb36d55911623ec678b351909db690a4b6ccb141c5c0cfaacea4d47e43b0cc4d3aa18095c049c_1280.png\"]", 1, 75m, 60, 4.2999999999999998, "30 days return policy", "Ships in 1 week", "YO3G5T", "[\"dairy\"]", "https://cdn.dummyjson.com/products/images/groceries/Yogurt/thumbnail.png", "Yogurt", "No warranty applicable", 100.0 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$e2Injt0kkSZx.xQeAfnBmeQG0Kd1dsakzJ7aCBKIVBi30XOegoDfm");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DropColumn(
                name: "AvailabilityStatus",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DiscountPercentage",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Images",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MinimumOrderQuantity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ReturnPolicy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ShippingInformation",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Sku",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Thumbnail",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "WarrantyInformation",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Products",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "QuantityInStock",
                table: "Products",
                newName: "StockQuantity");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$YDf0Bgc.HNYG8VfM4n5SmuutptghDUyz3ApxEvson5CNDJ5EdG4W6");
        }
    }
}
