using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrganicShopBackend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateonAdminProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$YDf0Bgc.HNYG8VfM4n5SmuutptghDUyz3ApxEvson5CNDJ5EdG4W6");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$VAPRmn65VgoVfWu.QQQecuDA95rr/oh.2JYJ2WitVqgzqbIaY3.16");
        }
    }
}
