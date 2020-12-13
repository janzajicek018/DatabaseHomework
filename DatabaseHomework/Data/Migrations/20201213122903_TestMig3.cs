using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseHomework.Data.Migrations
{
    public partial class TestMig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimeGenre_Anime_AnimeID",
                table: "AnimeGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_AnimeGenre_Genre_GenreID",
                table: "AnimeGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Anime_AnimeID",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_AspNetUsers_UserID",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genre",
                table: "Genre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimeGenre",
                table: "AnimeGenre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Anime",
                table: "Anime");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "Reviews");

            migrationBuilder.RenameTable(
                name: "Genre",
                newName: "Genres");

            migrationBuilder.RenameTable(
                name: "AnimeGenre",
                newName: "AnimeGenres");

            migrationBuilder.RenameTable(
                name: "Anime",
                newName: "Animes");

            migrationBuilder.RenameIndex(
                name: "IX_Review_UserID",
                table: "Reviews",
                newName: "IX_Reviews_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Review_AnimeID",
                table: "Reviews",
                newName: "IX_Reviews_AnimeID");

            migrationBuilder.RenameIndex(
                name: "IX_AnimeGenre_GenreID",
                table: "AnimeGenres",
                newName: "IX_AnimeGenres_GenreID");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimeGenres",
                table: "AnimeGenres",
                columns: new[] { "AnimeID", "GenreID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Animes",
                table: "Animes",
                column: "ID");

            migrationBuilder.InsertData(
                table: "AnimeGenres",
                columns: new[] { "AnimeID", "GenreID" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Animes",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "Bloom Into You");

            migrationBuilder.InsertData(
                table: "Animes",
                columns: new[] { "ID", "Description", "Episodes", "Name" },
                values: new object[] { 2, null, 23, "Clannad" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 2, "School" },
                    { 3, "Drama" },
                    { 4, "Comedy" },
                    { 5, "Slice of Life" },
                    { 6, "Supernatural" }
                });

            migrationBuilder.InsertData(
                table: "AnimeGenres",
                columns: new[] { "AnimeID", "GenreID" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AnimeGenres_Animes_AnimeID",
                table: "AnimeGenres",
                column: "AnimeID",
                principalTable: "Animes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnimeGenres_Genres_GenreID",
                table: "AnimeGenres",
                column: "GenreID",
                principalTable: "Genres",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Animes_AnimeID",
                table: "Reviews",
                column: "AnimeID",
                principalTable: "Animes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_UserID",
                table: "Reviews",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimeGenres_Animes_AnimeID",
                table: "AnimeGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_AnimeGenres_Genres_GenreID",
                table: "AnimeGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Animes_AnimeID",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_UserID",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Animes",
                table: "Animes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimeGenres",
                table: "AnimeGenres");

            migrationBuilder.DeleteData(
                table: "AnimeGenres",
                keyColumns: new[] { "AnimeID", "GenreID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AnimeGenres",
                keyColumns: new[] { "AnimeID", "GenreID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "AnimeGenres",
                keyColumns: new[] { "AnimeID", "GenreID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "AnimeGenres",
                keyColumns: new[] { "AnimeID", "GenreID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AnimeGenres",
                keyColumns: new[] { "AnimeID", "GenreID" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "AnimeGenres",
                keyColumns: new[] { "AnimeID", "GenreID" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "AnimeGenres",
                keyColumns: new[] { "AnimeID", "GenreID" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "AnimeGenres",
                keyColumns: new[] { "AnimeID", "GenreID" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "Review");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "Genre");

            migrationBuilder.RenameTable(
                name: "Animes",
                newName: "Anime");

            migrationBuilder.RenameTable(
                name: "AnimeGenres",
                newName: "AnimeGenre");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_UserID",
                table: "Review",
                newName: "IX_Review_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_AnimeID",
                table: "Review",
                newName: "IX_Review_AnimeID");

            migrationBuilder.RenameIndex(
                name: "IX_AnimeGenres_GenreID",
                table: "AnimeGenre",
                newName: "IX_AnimeGenre_GenreID");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genre",
                table: "Genre",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Anime",
                table: "Anime",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimeGenre",
                table: "AnimeGenre",
                columns: new[] { "AnimeID", "GenreID" });

            migrationBuilder.UpdateData(
                table: "Anime",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "Bloom into you");

            migrationBuilder.AddForeignKey(
                name: "FK_AnimeGenre_Anime_AnimeID",
                table: "AnimeGenre",
                column: "AnimeID",
                principalTable: "Anime",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnimeGenre_Genre_GenreID",
                table: "AnimeGenre",
                column: "GenreID",
                principalTable: "Genre",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Anime_AnimeID",
                table: "Review",
                column: "AnimeID",
                principalTable: "Anime",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_AspNetUsers_UserID",
                table: "Review",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
