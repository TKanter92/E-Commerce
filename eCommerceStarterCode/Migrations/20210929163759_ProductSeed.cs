using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class ProductSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91c4a51f-a2a0-4887-be55-395b5aec018f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b79f18fd-96fc-4df5-bfde-ee9c5c871716");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "daf1cf7b-d356-4443-b24a-9e548e092171", "02f04608-d7ab-484d-a4f0-0e4803bd934a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec78faaa-53e2-4d54-aeaf-f228cbc86b9d", "8e97524f-99b8-4382-bb85-3c749f326ab8", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Artist", "Description", "Genre", "Price", "ProductName", "Rating" },
                values: new object[] { 1, null, "Cool Album", "Rock", 20f, "Abbey Road", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "daf1cf7b-d356-4443-b24a-9e548e092171");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec78faaa-53e2-4d54-aeaf-f228cbc86b9d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "91c4a51f-a2a0-4887-be55-395b5aec018f", "9c0ca3d3-6d1a-47e1-98e6-bcf477703c94", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b79f18fd-96fc-4df5-bfde-ee9c5c871716", "90679dc7-1644-48e0-b013-93903a570d2a", "Admin", "ADMIN" });
        }
    }
}
