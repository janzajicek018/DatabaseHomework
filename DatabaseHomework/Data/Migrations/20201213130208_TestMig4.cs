using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseHomework.Data.Migrations
{
    public partial class TestMig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXX1", "ea20b1fe-8db6-41c7-bfdd-f31b5149af38", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX", 0, "e8c00a20-c90e-4aec-bc2a-97ee34567b4d", "jan.zajicek1@pslib.cz", true, false, null, "JAN.ZAJICEK1@PSLIB.CZ", "JAN.ZAJICEK1@PSLIB.CZ", "AQAAAAEAACcQAAAAEInf37a2e8BopgOm9VOywuMo5rt7UpATSyCI9TzNMf0fmj0GtpT4/wFd+uFdua5iXQ==", null, false, "", false, "jan.zajicek1@pslib.cz" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXX1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXX1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXX1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX");
        }
    }
}
