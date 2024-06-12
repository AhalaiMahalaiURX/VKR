﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    [Migration("20240526120347_Third")]
    partial class Third
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("SubscribersNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Domain.Bookmark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Bookmark");
                });

            modelBuilder.Entity("Domain.Chapter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CommentsNumber")
                        .HasColumnType("integer");

                    b.Property<int>("FanficId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("SerialNumber")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FanficId");

                    b.ToTable("Chapters");
                });

            modelBuilder.Entity("Domain.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ChapterId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ChapterId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Domain.Fandom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Fandom");
                });

            modelBuilder.Entity("Domain.Fanfic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AgeRating")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<int>("BookmarksNumber")
                        .HasColumnType("integer");

                    b.Property<int>("ChaptersNumber")
                        .HasColumnType("integer");

                    b.Property<int>("CommentsNumber")
                        .HasColumnType("integer");

                    b.Property<int>("FocusId")
                        .HasColumnType("integer");

                    b.Property<int>("Likes")
                        .HasColumnType("integer");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ReviewsNumber")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("TotalRate")
                        .HasColumnType("numeric");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Views")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("FocusId");

                    b.ToTable("Fanfics");
                });

            modelBuilder.Entity("Domain.FanficBookmark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BookmarkId")
                        .HasColumnType("integer");

                    b.Property<int>("FanficId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BookmarkId");

                    b.HasIndex("FanficId", "BookmarkId")
                        .IsUnique();

                    b.ToTable("FanficBookmarks");
                });

            modelBuilder.Entity("Domain.FanficFandom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("FandomId")
                        .HasColumnType("integer");

                    b.Property<int>("FanficId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("FandomId");

                    b.HasIndex("FanficId", "FandomId")
                        .IsUnique();

                    b.ToTable("FanficFandoms");
                });

            modelBuilder.Entity("Domain.FanficGenre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("FanficId")
                        .HasColumnType("integer");

                    b.Property<int>("GenreId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.HasIndex("FanficId", "GenreId")
                        .IsUnique();

                    b.ToTable("FanficGenres");
                });

            modelBuilder.Entity("Domain.FanficTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("FanficId")
                        .HasColumnType("integer");

                    b.Property<int>("TagId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TagId");

                    b.HasIndex("FanficId", "TagId")
                        .IsUnique();

                    b.ToTable("FanficTags");
                });

            modelBuilder.Entity("Domain.Focus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Focuses");
                });

            modelBuilder.Entity("Domain.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("Domain.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<int>("FanficId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("FanficId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Domain.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("Domain.Chapter", b =>
                {
                    b.HasOne("Domain.Fanfic", "Fanfic")
                        .WithMany("Chapters")
                        .HasForeignKey("FanficId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fanfic");
                });

            modelBuilder.Entity("Domain.Comment", b =>
                {
                    b.HasOne("Domain.Chapter", "Chapter")
                        .WithMany("Comments")
                        .HasForeignKey("ChapterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chapter");
                });

            modelBuilder.Entity("Domain.Fanfic", b =>
                {
                    b.HasOne("Domain.Author", "Author")
                        .WithMany("Fanfics")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Focus", "Focus")
                        .WithMany("Fanfics")
                        .HasForeignKey("FocusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Focus");
                });

            modelBuilder.Entity("Domain.FanficBookmark", b =>
                {
                    b.HasOne("Domain.Bookmark", "Bookmark")
                        .WithMany("RelatedFanfics")
                        .HasForeignKey("BookmarkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Fanfic", "Fanfic")
                        .WithMany("RelatedBookmarks")
                        .HasForeignKey("FanficId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bookmark");

                    b.Navigation("Fanfic");
                });

            modelBuilder.Entity("Domain.FanficFandom", b =>
                {
                    b.HasOne("Domain.Fandom", "Fandom")
                        .WithMany("RelatedFanfics")
                        .HasForeignKey("FandomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Fanfic", "Fanfic")
                        .WithMany("RelatedFandoms")
                        .HasForeignKey("FanficId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fandom");

                    b.Navigation("Fanfic");
                });

            modelBuilder.Entity("Domain.FanficGenre", b =>
                {
                    b.HasOne("Domain.Fanfic", "Fanfic")
                        .WithMany("RelatedGenres")
                        .HasForeignKey("FanficId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Genre", "Genre")
                        .WithMany("RelatedFanfics")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fanfic");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Domain.FanficTag", b =>
                {
                    b.HasOne("Domain.Fanfic", "Fanfic")
                        .WithMany("RelatedTags")
                        .HasForeignKey("FanficId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Tag", "Tag")
                        .WithMany("RelatedFanfics")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fanfic");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("Domain.Review", b =>
                {
                    b.HasOne("Domain.Author", "Author")
                        .WithMany("Reviews")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Fanfic", "Fanfic")
                        .WithMany("Reviews")
                        .HasForeignKey("FanficId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Fanfic");
                });

            modelBuilder.Entity("Domain.Author", b =>
                {
                    b.Navigation("Fanfics");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Domain.Bookmark", b =>
                {
                    b.Navigation("RelatedFanfics");
                });

            modelBuilder.Entity("Domain.Chapter", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Domain.Fandom", b =>
                {
                    b.Navigation("RelatedFanfics");
                });

            modelBuilder.Entity("Domain.Fanfic", b =>
                {
                    b.Navigation("Chapters");

                    b.Navigation("RelatedBookmarks");

                    b.Navigation("RelatedFandoms");

                    b.Navigation("RelatedGenres");

                    b.Navigation("RelatedTags");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Domain.Focus", b =>
                {
                    b.Navigation("Fanfics");
                });

            modelBuilder.Entity("Domain.Genre", b =>
                {
                    b.Navigation("RelatedFanfics");
                });

            modelBuilder.Entity("Domain.Tag", b =>
                {
                    b.Navigation("RelatedFanfics");
                });
#pragma warning restore 612, 618
        }
    }
}
