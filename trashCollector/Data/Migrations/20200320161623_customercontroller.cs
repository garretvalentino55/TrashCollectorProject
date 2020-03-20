using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace trashCollector.Data.Migrations
{
    public partial class customercontroller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    StreetNumber = table.Column<int>(nullable: false),
                    StreetName = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false),
                    PickUpDay = table.Column<string>(nullable: true),
                    OneTimePickUp = table.Column<DateTime>(nullable: false),
                    TempSuspendStart = table.Column<DateTime>(nullable: false),
                    TempSuspendEnd = table.Column<DateTime>(nullable: false),
                    AmountOwed = table.Column<double>(nullable: false),
                    PickupConfirmed = table.Column<bool>(nullable: false),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6f78a780-8868-4fa9-8334-40d084a8e188", "4d19ce9f-314d-48d3-acd9-34f9af41217b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4d822643-08a1-433f-8648-5a0daf7b049f", "e3dc02e3-6da2-4025-abb1-7d494f0b7daa", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5b8e5540-ff6b-44c4-9320-ed5b3664562b", "8e9d762b-7837-4464-9849-43f0414e34d1", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_IdentityUserId",
                table: "Customer",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d822643-08a1-433f-8648-5a0daf7b049f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b8e5540-ff6b-44c4-9320-ed5b3664562b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f78a780-8868-4fa9-8334-40d084a8e188");

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
        }
    }
}
