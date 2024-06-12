using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class SecondMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Fanfics");

            migrationBuilder.DropColumn(
                name: "Fandoms",
                table: "Fanfics");

            migrationBuilder.DropColumn(
                name: "Focus",
                table: "Fanfics");

            migrationBuilder.DropColumn(
                name: "Genres",
                table: "Fanfics");

            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Fanfics");

            migrationBuilder.RenameColumn(
                name: "chapterTitle",
                table: "Chapters",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "chapterSummary",
                table: "Chapters",
                newName: "Summary");

            migrationBuilder.RenameColumn(
                name: "chapterPublicationDate",
                table: "Chapters",
                newName: "PublicationDate");

            migrationBuilder.RenameColumn(
                name: "chapterNumber",
                table: "Chapters",
                newName: "SerialNumber");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Fanfics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FocusId",
                table: "Fanfics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CommentsNumber",
                table: "Chapters",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nickname = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SubscribersNumber = table.Column<string>(type: "text", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bookmark",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Author = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookmark", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PublicationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Author = table.Column<string>(type: "text", nullable: false),
                    Summary = table.Column<string>(type: "text", nullable: false),
                    ChapterId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Chapters_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "Chapters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fandom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fandom", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Focuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Focuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PublicationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Summary = table.Column<string>(type: "text", nullable: false),
                    AuthorId = table.Column<int>(type: "integer", nullable: false),
                    FanficId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Fanfics_FanficId",
                        column: x => x.FanficId,
                        principalTable: "Fanfics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FanficBookmarks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FanficId = table.Column<int>(type: "integer", nullable: false),
                    BookmarkId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FanficBookmarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FanficBookmarks_Bookmark_BookmarkId",
                        column: x => x.BookmarkId,
                        principalTable: "Bookmark",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FanficBookmarks_Fanfics_FanficId",
                        column: x => x.FanficId,
                        principalTable: "Fanfics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FanficFandoms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FanficId = table.Column<int>(type: "integer", nullable: false),
                    FandomId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FanficFandoms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FanficFandoms_Fandom_FandomId",
                        column: x => x.FandomId,
                        principalTable: "Fandom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FanficFandoms_Fanfics_FanficId",
                        column: x => x.FanficId,
                        principalTable: "Fanfics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FanficGenres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FanficId = table.Column<int>(type: "integer", nullable: false),
                    GenreId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FanficGenres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FanficGenres_Fanfics_FanficId",
                        column: x => x.FanficId,
                        principalTable: "Fanfics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FanficGenres_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FanficTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FanficId = table.Column<int>(type: "integer", nullable: false),
                    TagId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FanficTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FanficTags_Fanfics_FanficId",
                        column: x => x.FanficId,
                        principalTable: "Fanfics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FanficTags_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fanfics_AuthorId",
                table: "Fanfics",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Fanfics_FocusId",
                table: "Fanfics",
                column: "FocusId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ChapterId",
                table: "Comments",
                column: "ChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_FanficBookmarks_BookmarkId",
                table: "FanficBookmarks",
                column: "BookmarkId");

            migrationBuilder.CreateIndex(
                name: "IX_FanficBookmarks_FanficId",
                table: "FanficBookmarks",
                column: "FanficId");

            migrationBuilder.CreateIndex(
                name: "IX_FanficFandoms_FandomId",
                table: "FanficFandoms",
                column: "FandomId");

            migrationBuilder.CreateIndex(
                name: "IX_FanficFandoms_FanficId",
                table: "FanficFandoms",
                column: "FanficId");

            migrationBuilder.CreateIndex(
                name: "IX_FanficGenres_FanficId",
                table: "FanficGenres",
                column: "FanficId");

            migrationBuilder.CreateIndex(
                name: "IX_FanficGenres_GenreId",
                table: "FanficGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_FanficTags_FanficId_TagId",
                table: "FanficTags",
                columns: new[] { "FanficId", "TagId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FanficTags_TagId",
                table: "FanficTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_AuthorId",
                table: "Reviews",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_FanficId",
                table: "Reviews",
                column: "FanficId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fanfics_Authors_AuthorId",
                table: "Fanfics",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fanfics_Focuses_FocusId",
                table: "Fanfics",
                column: "FocusId",
                principalTable: "Focuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fanfics_Authors_AuthorId",
                table: "Fanfics");

            migrationBuilder.DropForeignKey(
                name: "FK_Fanfics_Focuses_FocusId",
                table: "Fanfics");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "FanficBookmarks");

            migrationBuilder.DropTable(
                name: "FanficFandoms");

            migrationBuilder.DropTable(
                name: "FanficGenres");

            migrationBuilder.DropTable(
                name: "FanficTags");

            migrationBuilder.DropTable(
                name: "Focuses");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Bookmark");

            migrationBuilder.DropTable(
                name: "Fandom");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Fanfics_AuthorId",
                table: "Fanfics");

            migrationBuilder.DropIndex(
                name: "IX_Fanfics_FocusId",
                table: "Fanfics");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Fanfics");

            migrationBuilder.DropColumn(
                name: "FocusId",
                table: "Fanfics");

            migrationBuilder.DropColumn(
                name: "CommentsNumber",
                table: "Chapters");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Chapters",
                newName: "chapterTitle");

            migrationBuilder.RenameColumn(
                name: "Summary",
                table: "Chapters",
                newName: "chapterSummary");

            migrationBuilder.RenameColumn(
                name: "SerialNumber",
                table: "Chapters",
                newName: "chapterNumber");

            migrationBuilder.RenameColumn(
                name: "PublicationDate",
                table: "Chapters",
                newName: "chapterPublicationDate");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Fanfics",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<List<string>>(
                name: "Fandoms",
                table: "Fanfics",
                type: "text[]",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Focus",
                table: "Fanfics",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<List<string>>(
                name: "Genres",
                table: "Fanfics",
                type: "text[]",
                nullable: false);

            migrationBuilder.AddColumn<List<string>>(
                name: "Tags",
                table: "Fanfics",
                type: "text[]",
                nullable: false);
        }
    }
}
