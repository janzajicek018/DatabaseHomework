using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseHomework.Data.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXX1",
                column: "ConcurrencyStamp",
                value: "cb6d25fe-1218-4f4f-a73b-71d40d45d956");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "81705968-252f-4cdd-9fa7-d73920b6662d", "AQAAAAEAACcQAAAAEMZVcKM7m+Wzqvi0fYaxd0LArQwI5+aWKOna1/0WrqZmix6hiMM18rvrMtB1sKE+1Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
