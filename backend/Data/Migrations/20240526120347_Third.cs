using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FanficGenres_FanficId",
                table: "FanficGenres");

            migrationBuilder.DropIndex(
                name: "IX_FanficFandoms_FanficId",
                table: "FanficFandoms");

            migrationBuilder.DropIndex(
                name: "IX_FanficBookmarks_FanficId",
                table: "FanficBookmarks");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Fanfics",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Chapters",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_FanficGenres_FanficId_GenreId",
                table: "FanficGenres",
                columns: new[] { "FanficId", "GenreId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FanficFandoms_FanficId_FandomId",
                table: "FanficFandoms",
                columns: new[] { "FanficId", "FandomId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FanficBookmarks_FanficId_BookmarkId",
                table: "FanficBookmarks",
                columns: new[] { "FanficId", "BookmarkId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FanficGenres_FanficId_GenreId",
                table: "FanficGenres");

            migrationBuilder.DropIndex(
                name: "IX_FanficFandoms_FanficId_FandomId",
                table: "FanficFandoms");

            migrationBuilder.DropIndex(
                name: "IX_FanficBookmarks_FanficId_BookmarkId",
                table: "FanficBookmarks");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Fanfics");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Chapters");

            migrationBuilder.CreateIndex(
                name: "IX_FanficGenres_FanficId",
                table: "FanficGenres",
                column: "FanficId");

            migrationBuilder.CreateIndex(
                name: "IX_FanficFandoms_FanficId",
                table: "FanficFandoms",
                column: "FanficId");

            migrationBuilder.CreateIndex(
                name: "IX_FanficBookmarks_FanficId",
                table: "FanficBookmarks",
                column: "FanficId");
        }
    }
}
