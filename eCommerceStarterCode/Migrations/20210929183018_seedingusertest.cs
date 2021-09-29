using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class seedingusertest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "7ac12342-521d-485c-becf-6b35674bebdd", "6c7b0c47-31b0-4823-870a-7dd8dc6e45c8", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "47d3f6e6-9370-4641-89f5-1a48c70a7ea4", "0fa6db93-1714-408c-b9c0-33136170c35e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2073c289-e37a-451d-b215-bac6b5d30433", 0, "71607ee6-d7a5-48ce-a381-31ac67e6edc0", null, false, "Test", "Test", false, null, null, null, null, null, false, "553caf20-87a3-4932-9f33-f8a35f916275", false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47d3f6e6-9370-4641-89f5-1a48c70a7ea4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ac12342-521d-485c-becf-6b35674bebdd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2073c289-e37a-451d-b215-bac6b5d30433");

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
    }
}
