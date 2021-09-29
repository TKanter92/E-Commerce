using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class SeededShoppingCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "daf1cf7b-d356-4443-b24a-9e548e092171");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec78faaa-53e2-4d54-aeaf-f228cbc86b9d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4cccfbb5-980a-477b-a852-2d2b8533f079", "84ee17eb-b008-4dd6-be26-2e0ceaef77d5", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2f8d148e-6add-4093-a0ee-919477d99def", "ce9ba667-54a9-4a88-8467-57fb64547819", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "ShoppingCarts",
                columns: new[] { "ShoppingCartId", "ProductId", "Quantity", "UserId" },
                values: new object[] { 1, 2, 2, "a123" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f8d148e-6add-4093-a0ee-919477d99def");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4cccfbb5-980a-477b-a852-2d2b8533f079");

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "ShoppingCartId",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "daf1cf7b-d356-4443-b24a-9e548e092171", "02f04608-d7ab-484d-a4f0-0e4803bd934a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec78faaa-53e2-4d54-aeaf-f228cbc86b9d", "8e97524f-99b8-4382-bb85-3c749f326ab8", "Admin", "ADMIN" });
        }
    }
}
