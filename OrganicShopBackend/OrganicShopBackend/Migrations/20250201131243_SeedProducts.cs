using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrganicShopBackend.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$z63WCxdi/rZp2eVuPyi.0OGJkANszpOXrPN9.JkwOCi47snys69l6");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$T9zL5T3v.a2ZEBoKZ1Z76.U9crE0hxYD03cCDCIO.92Zej1n.5pv2");
        }
    }
}
