using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrganicShopBackend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateonAdminProductsAndProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$VAPRmn65VgoVfWu.QQQecuDA95rr/oh.2JYJ2WitVqgzqbIaY3.16");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$z63WCxdi/rZp2eVuPyi.0OGJkANszpOXrPN9.JkwOCi47snys69l6");
        }
    }
}
