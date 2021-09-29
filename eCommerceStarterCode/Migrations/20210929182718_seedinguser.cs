using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class seedinguser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "da7999e8-5f45-4a3e-bfc4-f49af3f1ac0b", "0f40780a-25a5-403c-90a5-d603afccc66e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e4682c8a-89f7-4d43-882f-4ba401fd688a", "9956fffc-6783-489e-b318-a0632bc4dca0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "44a65849-3f49-4536-bace-07e22c643122", 0, "a057683c-8bec-41dd-bebc-cac7006cc093", null, false, "Test", "Test", false, null, null, null, null, null, false, "a0132da3-6838-45a3-88c0-d1263471ceeb", false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da7999e8-5f45-4a3e-bfc4-f49af3f1ac0b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4682c8a-89f7-4d43-882f-4ba401fd688a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44a65849-3f49-4536-bace-07e22c643122");

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
    }
}
