using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "766f63d4-7e0e-4e6e-aa84-3d2fdbaee00c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "835b5fa3-b810-4b3c-9898-898a2da5e40a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2d2bba51-0def-4019-977e-609b822a7261", "23c27555-f0c4-4334-be71-c5c1c5a0a09c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "293a7aa3-f316-47e8-9c33-b875854d8c70", "c4c3819d-96e2-4d62-bbf7-5e70ec672e5b", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "835b5fa3-b810-4b3c-9898-898a2da5e40a", "64464459-f9ea-49f9-8579-84f2537312ad", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "766f63d4-7e0e-4e6e-aa84-3d2fdbaee00c", "c4d7a0fc-0392-48d0-9464-74f5d594457b", "Admin", "ADMIN" });
        }
    }
}
