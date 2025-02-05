using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrganicShopBackend.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "Email", "Name", "PasswordHash", "PhoneNumber", "Role", "Username" },
                values: new object[] { 1, "123 Admin Street", "saiakash200236@gmail.com", "Freshio", "$2a$11$T9zL5T3v.a2ZEBoKZ1Z76.U9crE0hxYD03cCDCIO.92Zej1n.5pv2", "1234567890", "Admin", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);
        }
    }
}
