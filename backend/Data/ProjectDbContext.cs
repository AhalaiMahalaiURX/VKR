using Microsoft.EntityFrameworkCore;
using Domain;
// using System.Data.Entity;

namespace Data
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {

        }
        public DbSet<Fanfic> Fanfics { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Focus> Focuses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<FanficTag> FanficTags { get; set; }
        public DbSet<FanficGenre> FanficGenres { get; set; }
        public DbSet<FanficFandom> FanficFandoms { get; set; }
        public DbSet<FanficBookmark> FanficBookmarks { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fanfic>()
                .HasMany(F => F.Chapters)
                .WithOne(C => C.Fanfic)
                .HasForeignKey(C => C.FanficId);   //один ко многим между Fanfic и Chapters

            modelBuilder.Entity<Fanfic>()
                .HasMany(F => F.Reviews)
                .WithOne(R => R.Fanfic)
                .HasForeignKey(R => R.FanficId);   //один ко многим между Fanfic и Reviews

            modelBuilder.Entity<Chapter>()
                .HasMany(C => C.Comments)
                .WithOne(Com => Com.Chapter)
                .HasForeignKey(Com => Com.ChapterId); //один ко многим между Chapter и Comments

            modelBuilder.Entity<Author>()
               .HasMany(A => A.Fanfics)
               .WithOne(F => F.Author)
               .HasForeignKey(F => F.AuthorId); //один ко многим между Author и Fanfics

            modelBuilder.Entity<Author>()
               .HasMany(A => A.Reviews)
               .WithOne(R => R.Author)
               .HasForeignKey(R => R.AuthorId); //один ко многим между Author и Reviews

            modelBuilder.Entity<Focus>()
            .HasMany(F => F.Fanfics)
            .WithOne(Fan => Fan.Focus)
            .HasForeignKey(Fan => Fan.FocusId); //один ко многим между Focus и Fanfics

            modelBuilder.Entity<FanficTag>()
     .HasIndex(ft => new { ft.FanficId, ft.TagId }).IsUnique();

            modelBuilder.Entity<FanficTag>()
                .HasOne(ft => ft.Fanfic) // 
                .WithMany(f => f.RelatedTags) // У Fanfic может быть много FanficTag
                .HasForeignKey(ft => ft.FanficId); // Внешний ключ для Fanfic

            modelBuilder.Entity<FanficTag>()
                .HasOne(ft => ft.Tag) // 
                .WithMany(t => t.RelatedFanfics) // У Tag может быть много FanficTag
                .HasForeignKey(ft => ft.TagId); // Внешний ключ для Tag


            modelBuilder.Entity<FanficGenre>()
.HasIndex(fg => new { fg.FanficId, fg.GenreId }).IsUnique();

            modelBuilder.Entity<FanficGenre>()
                .HasOne(fg => fg.Fanfic) // 
                .WithMany(f => f.RelatedGenres) // У Fanfic может быть много FanficGenre
                .HasForeignKey(fg => fg.FanficId); // Внешний ключ для Fanfic

            modelBuilder.Entity<FanficGenre>()
                .HasOne(fg => fg.Genre) // 
                .WithMany(g => g.RelatedFanfics) // У Genre может быть много FanficGenre
                .HasForeignKey(fg => fg.GenreId); // Внешний ключ для Genre


            modelBuilder.Entity<FanficFandom>()
    .HasIndex(ff => new { ff.FanficId, ff.FandomId }).IsUnique();

            modelBuilder.Entity<FanficFandom>()
                .HasOne(ff => ff.Fanfic) // 
                .WithMany(f => f.RelatedFandoms) // У Fanfic может быть много FanficFandom
                .HasForeignKey(ff => ff.FanficId); // Внешний ключ для Fanfic

            modelBuilder.Entity<FanficFandom>()
                .HasOne(ff => ff.Fandom) // 
                .WithMany(f => f.RelatedFanfics) // У Fandom может быть много FanficFandom
                .HasForeignKey(ff=> ff.FandomId); // Внешний ключ для Fandom


            modelBuilder.Entity<FanficBookmark>()
    .HasIndex(fb => new { fb.FanficId, fb.BookmarkId }).IsUnique();

            modelBuilder.Entity<FanficBookmark>()
                .HasOne(fb => fb.Fanfic) // 
                .WithMany(f => f.RelatedBookmarks) // У Fanfic может быть много FanficFandom
                .HasForeignKey(fb => fb.FanficId); // Внешний ключ для Fanfic

            modelBuilder.Entity<FanficBookmark>()
                .HasOne(fb => fb.Bookmark) // 
                .WithMany(f => f.RelatedFanfics) // У Fandom может быть много FanficFandom
                .HasForeignKey(fb => fb.BookmarkId); // Внешний ключ для Fandom
        }


    }

}