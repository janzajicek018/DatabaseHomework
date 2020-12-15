using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseHomework.Data.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXX1", "cb6d25fe-1218-4f4f-a73b-71d40d45d956", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX", 0, "81705968-252f-4cdd-9fa7-d73920b6662d", "jan.zajicek1@pslib.cz", true, false, null, "JAN.ZAJICEK1@PSLIB.CZ", "JAN.ZAJICEK1@PSLIB.CZ", "AQAAAAEAACcQAAAAEMZVcKM7m+Wzqvi0fYaxd0LArQwI5+aWKOna1/0WrqZmix6hiMM18rvrMtB1sKE+1Q==", null, false, "", false, "jan.zajicek1@pslib.cz" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX", "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXX1" });
        }
    }
}
