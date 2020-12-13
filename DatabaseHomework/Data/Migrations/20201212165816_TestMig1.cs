using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseHomework.Data.Migrations
{
    public partial class TestMig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Anime",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Episodes = table.Column<int>(nullable: false),
                    GenreID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anime", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Anime_Genre_GenreID",
                        column: x => x.GenreID,
                        principalTable: "Genre",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mark = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    UserID = table.Column<string>(nullable: false),
                    AnimeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Review_Anime_AnimeID",
                        column: x => x.AnimeID,
                        principalTable: "Anime",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "Romance" });

            migrationBuilder.InsertData(
                table: "Anime",
                columns: new[] { "ID", "Description", "Episodes", "GenreID", "Name" },
                values: new object[] { 1, null, 13, 1, "Bloom into you" });

            migrationBuilder.CreateIndex(
                name: "IX_Anime_GenreID",
                table: "Anime",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_Review_AnimeID",
                table: "Review",
                column: "AnimeID");

            migrationBuilder.CreateIndex(
                name: "IX_Review_UserID",
                table: "Review",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Anime");

            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
