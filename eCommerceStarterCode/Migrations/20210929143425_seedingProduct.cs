using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class seedingProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "293a7aa3-f316-47e8-9c33-b875854d8c70");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d2bba51-0def-4019-977e-609b822a7261");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c49e787c-fb83-4a9b-acea-a83e3d2ff4a2", "56496bfa-cb20-459a-9cd7-994c6a6e073e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "47cc8f1d-4adc-41dd-9436-6d9f3ad45e5a", "a1f908a4-728d-4b31-befd-f332924b1e0b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "Genre", "Price", "ProductName", "Rating", "Reviews" },
                values: new object[] { 1, "Cool Album", "Rock", 20f, "Abbey Road", 5, "Good" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47cc8f1d-4adc-41dd-9436-6d9f3ad45e5a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c49e787c-fb83-4a9b-acea-a83e3d2ff4a2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2d2bba51-0def-4019-977e-609b822a7261", "23c27555-f0c4-4334-be71-c5c1c5a0a09c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "293a7aa3-f316-47e8-9c33-b875854d8c70", "c4c3819d-96e2-4d62-bbf7-5e70ec672e5b", "Admin", "ADMIN" });
        }
    }
}
