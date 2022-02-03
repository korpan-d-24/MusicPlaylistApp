using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicPlaylist.Server.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MusicStyles",
                columns: new[] { "Id", "NameOfStyle" },
                values: new object[] { 1, "Heavy metal" });

            migrationBuilder.InsertData(
                table: "MusicStyles",
                columns: new[] { "Id", "NameOfStyle" },
                values: new object[] { 2, "Rock 'n' Roll" });

            migrationBuilder.InsertData(
                table: "MusicStyles",
                columns: new[] { "Id", "NameOfStyle" },
                values: new object[] { 3, "Jazz" });

            migrationBuilder.InsertData(
                table: "Musics",
                columns: new[] { "Id", "AlbumName", "GroupName", "MusicStyleId", "ReleaseYear", "SongName", "Url" },
                values: new object[] { 1, "Heaven and Hell", "Black Sabbath", 1, "1980", "Heaven and Hell", "https://www.youtube.com/watch?v=RVUK2rtAkJE" });

            migrationBuilder.InsertData(
                table: "Musics",
                columns: new[] { "Id", "AlbumName", "GroupName", "MusicStyleId", "ReleaseYear", "SongName", "Url" },
                values: new object[] { 2, "Ritchie Blackmore's Rainbow", "Rainbow", 2, "1975", "Catch The Rainbow", "https://www.youtube.com/watch?v=V5QukAC-jqE" });

            migrationBuilder.InsertData(
                table: "Musics",
                columns: new[] { "Id", "AlbumName", "GroupName", "MusicStyleId", "ReleaseYear", "SongName", "Url" },
                values: new object[] { 3, "What a wonderful world", "Louis Armstrong", 3, "1967", "What a wonderful world", "https://www.youtube.com/watch?v=CWzrABouyeE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Musics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Musics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Musics",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MusicStyles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MusicStyles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MusicStyles",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
