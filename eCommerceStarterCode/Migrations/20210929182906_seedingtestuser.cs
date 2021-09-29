using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class seedingtestuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d32906e4-ca29-4f4f-9d86-d763a9989b22", "e6bba19c-51de-4b11-8078-c54779fe62c3", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2570cc12-3e3c-47d4-ba69-9eebe6cca2ef", "11746734-5950-4b7f-8ec1-71bcc7ee1628", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "15442ea7-f1bd-4d0a-98dd-3aa0203ff236", 0, "c3e0bd14-3e21-4c89-bbbe-5d57ed2e928c", null, false, "Test", "Test", false, null, null, null, null, null, false, "1e310d5e-e281-4838-9363-e5eae21564f5", false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2570cc12-3e3c-47d4-ba69-9eebe6cca2ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d32906e4-ca29-4f4f-9d86-d763a9989b22");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15442ea7-f1bd-4d0a-98dd-3aa0203ff236");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "da7999e8-5f45-4a3e-bfc4-f49af3f1ac0b", "0f40780a-25a5-403c-90a5-d603afccc66e", "User", "USER" },
                    { "e4682c8a-89f7-4d43-882f-4ba401fd688a", "9956fffc-6783-489e-b318-a0632bc4dca0", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "44a65849-3f49-4536-bace-07e22c643122", 0, "a057683c-8bec-41dd-bebc-cac7006cc093", null, false, "Test", "Test", false, null, null, null, null, null, false, "a0132da3-6838-45a3-88c0-d1263471ceeb", false, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Artist", "Description", "Genre", "Price", "ProductName", "Rating" },
                values: new object[] { 1, null, "Cool Album", "Rock", 20f, "Abbey Road", 5 });
        }
    }
}
