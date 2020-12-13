using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseHomework.Data.Migrations
{
    public partial class TestMig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anime_Genre_GenreID",
                table: "Anime");

            migrationBuilder.DropIndex(
                name: "IX_Anime_GenreID",
                table: "Anime");

            migrationBuilder.DropColumn(
                name: "GenreID",
                table: "Anime");

            migrationBuilder.CreateTable(
                name: "AnimeGenre",
                columns: table => new
                {
                    AnimeID = table.Column<int>(nullable: false),
                    GenreID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeGenre", x => new { x.AnimeID, x.GenreID });
                    table.ForeignKey(
                        name: "FK_AnimeGenre_Anime_AnimeID",
                        column: x => x.AnimeID,
                        principalTable: "Anime",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimeGenre_Genre_GenreID",
                        column: x => x.GenreID,
                        principalTable: "Genre",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimeGenre_GenreID",
                table: "AnimeGenre",
                column: "GenreID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimeGenre");

            migrationBuilder.AddColumn<int>(
                name: "GenreID",
                table: "Anime",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Anime",
                keyColumn: "ID",
                keyValue: 1,
                column: "GenreID",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Anime_GenreID",
                table: "Anime",
                column: "GenreID");

            migrationBuilder.AddForeignKey(
                name: "FK_Anime_Genre_GenreID",
                table: "Anime",
                column: "GenreID",
                principalTable: "Genre",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
