using System;
using System.Collections.Generic;
using System.Text;
using DatabaseHomework.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DatabaseHomework.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Anime> Animes { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<AnimeGenre> AnimeGenres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXX1", Name = "Administrator", NormalizedName = "ADMINISTRATOR" });
            var hasher = new PasswordHasher<IdentityUser>();
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                Email = "jan.zajicek1@pslib.cz",
                NormalizedEmail = "JAN.ZAJICEK1@PSLIB.CZ",
                EmailConfirmed = true,
                LockoutEnabled = false,
                UserName = "jan.zajicek1@pslib.cz",
                NormalizedUserName = "JAN.ZAJICEK1@PSLIB.CZ",
                PasswordHash = hasher.HashPassword(null, "Admin_1234"),
                SecurityStamp = string.Empty
            });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { RoleId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXX1", UserId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX" });



            modelBuilder.Entity<Genre>().HasData(
                    new Genre { ID = 1, Name = "Romance" },
                    new Genre { ID = 2, Name = "School" },
                    new Genre { ID = 3, Name = "Drama" },
                    new Genre { ID = 4, Name = "Comedy" },
                    new Genre { ID = 5, Name = "Slice of Life" },
                    new Genre { ID = 6, Name = "Supernatural" }
                );
            modelBuilder.Entity<Anime>().HasData(
                    new Anime { ID = 1, Name = "Bloom Into You", Episodes = 13 },
                    new Anime { ID = 2, Name = "Clannad", Episodes = 23 }
                );

            modelBuilder.Entity<Review>()
                   .HasOne(r => r.Anime)
                   .WithMany(a => a.Reviews);
            /*builder.Entity<Review>().HasData(
                    
                );*/

            modelBuilder.Entity<AnimeGenre>()
                   .HasKey(ag => new { ag.AnimeID, ag.GenreID });

            modelBuilder.Entity<AnimeGenre>()
                   .HasOne(ag => ag.Anime)
                   .WithMany(a => a.AnimeGenres)
                   .HasForeignKey(ag => ag.AnimeID);

            modelBuilder.Entity<AnimeGenre>()
                   .HasOne(ag => ag.Genre)
                   .WithMany(g => g.AnimeGenres)
                   .HasForeignKey(ag => ag.GenreID);

            modelBuilder.Entity<AnimeGenre>().HasData(
                new AnimeGenre() { AnimeID = 1, GenreID = 1 },
                new AnimeGenre() { AnimeID = 1, GenreID = 2 },
                new AnimeGenre() { AnimeID = 2, GenreID = 4 },
                new AnimeGenre() { AnimeID = 2, GenreID = 3 },
                new AnimeGenre() { AnimeID = 2, GenreID = 1 },
                new AnimeGenre() { AnimeID = 2, GenreID = 6 },
                new AnimeGenre() { AnimeID = 2, GenreID = 2 },
                new AnimeGenre() { AnimeID = 2, GenreID = 5 });



            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
