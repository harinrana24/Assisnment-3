using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieMVC.Models;

namespace MovieMVC.Data
{
    public class MovieMVCContext : DbContext
    {
        public MovieMVCContext(DbContextOptions<MovieMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MovieMVC.Models.Movie> Movie { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)"); 

                entity.Property(e => e.ReleaseDate)
                    .IsRequired()
                    .HasColumnType("date");

                entity.Property(e => e.Genre)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}
