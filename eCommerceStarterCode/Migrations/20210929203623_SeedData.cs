using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "503d7bcf-aa7f-4659-b499-34ceacf74580");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71e9bd22-fbf7-4a6c-b9b8-12c5796fcf24");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "20bff8ac-e5c9-47a9-822d-f25195fbbc42", "3b6e828f-b331-47e0-aa75-c42f56c8746b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a5830b19-470f-4227-810d-64faa9b32181", "941bb335-a465-4489-84b9-c91d768be3dd", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Artist", "Description", "Genre", "Price", "ProductName", "Rating" },
                values: new object[] { 1, null, "Cool Album", "Rock", 20f, "Abbey Road", 5 });

            migrationBuilder.InsertData(
                table: "ShoppingCarts",
                columns: new[] { "ShoppingCartId", "ProductId", "Quantity", "UserId" },
                values: new object[] { 1, 1, 2, "3c82f367-c83e-4231-86e3-1775cb1c097a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20bff8ac-e5c9-47a9-822d-f25195fbbc42");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5830b19-470f-4227-810d-64faa9b32181");

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "ShoppingCartId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "503d7bcf-aa7f-4659-b499-34ceacf74580", "1b338e8b-f496-4389-97eb-88b64ff33df6", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "71e9bd22-fbf7-4a6c-b9b8-12c5796fcf24", "b4064bed-20f1-42d8-9711-a167cdd06588", "Admin", "ADMIN" });
        }
    }
}
