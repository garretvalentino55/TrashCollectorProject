using Microsoft.EntityFrameworkCore.Migrations;

namespace trashCollector.Data.Migrations
{
    public partial class newController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "444f6b0d-a383-43b9-a85a-8d97bf651010");

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeNumber = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    EmployeeZipCode = table.Column<int>(nullable: false),
                    IdentityEmployeeId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_AspNetUsers_IdentityEmployeeId",
                        column: x => x.IdentityEmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b63a7ae0-77b6-4b06-852c-794b0ca21cdc", "a2b4dc9f-e036-481c-b6ba-c25e9e4cea6f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a20e20aa-a403-4a3d-8e4f-38267c56539a", "2a32abf8-5460-4994-87bc-71a3001e53a2", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "05519484-97d1-45cf-8d30-846b28774fca", "ff429c4e-e27f-4e5a-b995-3456253aacab", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_IdentityEmployeeId",
                table: "Employee",
                column: "IdentityEmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05519484-97d1-45cf-8d30-846b28774fca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a20e20aa-a403-4a3d-8e4f-38267c56539a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b63a7ae0-77b6-4b06-852c-794b0ca21cdc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "444f6b0d-a383-43b9-a85a-8d97bf651010", "3dc7fc6a-3ae4-4002-b988-5f8e3f8f5aff", "Admin", "ADMIN" });
        }
    }
}
