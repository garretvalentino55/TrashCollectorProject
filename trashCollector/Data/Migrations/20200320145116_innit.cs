using Microsoft.EntityFrameworkCore.Migrations;

namespace trashCollector.Data.Migrations
{
    public partial class innit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a13f7d4-3a81-4ece-917a-f246749f82f5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "444f6b0d-a383-43b9-a85a-8d97bf651010", "3dc7fc6a-3ae4-4002-b988-5f8e3f8f5aff", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "444f6b0d-a383-43b9-a85a-8d97bf651010");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3a13f7d4-3a81-4ece-917a-f246749f82f5", "895351db-d1ae-4cb1-acf7-3fe4558d090a", "Admin", "ADMIN" });
        }
    }
}
