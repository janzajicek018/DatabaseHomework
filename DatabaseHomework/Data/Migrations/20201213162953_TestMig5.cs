using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseHomework.Data.Migrations
{
    public partial class TestMig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXX1",
                column: "ConcurrencyStamp",
                value: "3307654a-2c03-439a-bd66-32d88084ceff");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f07b22a7-7f95-402d-a29f-e9702c61de16", "AQAAAAEAACcQAAAAEEQ6h61E/54zMVzRODPCNClueTpewRPP+DpiJtTbpJUR4Y400N53MYUgG2U1JsBskg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXX1",
                column: "ConcurrencyStamp",
                value: "ea20b1fe-8db6-41c7-bfdd-f31b5149af38");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e8c00a20-c90e-4aec-bc2a-97ee34567b4d", "AQAAAAEAACcQAAAAEInf37a2e8BopgOm9VOywuMo5rt7UpATSyCI9TzNMf0fmj0GtpT4/wFd+uFdua5iXQ==" });
        }
    }
}
