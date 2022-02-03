using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicPlaylist.Server.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musics_MusicStyles_MusicStyleId",
                table: "Musics");

            migrationBuilder.AlterColumn<int>(
                name: "MusicStyleId",
                table: "Musics",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Musics_MusicStyles_MusicStyleId",
                table: "Musics",
                column: "MusicStyleId",
                principalTable: "MusicStyles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musics_MusicStyles_MusicStyleId",
                table: "Musics");

            migrationBuilder.AlterColumn<int>(
                name: "MusicStyleId",
                table: "Musics",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Musics_MusicStyles_MusicStyleId",
                table: "Musics",
                column: "MusicStyleId",
                principalTable: "MusicStyles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
