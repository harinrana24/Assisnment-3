using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieMVC.Data;
using System;
using System.Linq;

namespace MovieMVC.Models
{
    public static class SeedData
    {

        
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new MovieMVCContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MovieMVCContext>>());
            // Check if the database has been seeded
            if (context.Movie.Any())
            {
                return;   // Database has been seeded
            }

            context.Movie.AddRange(
                new Movie
                {
                    Title = "3 Idiots",
                    ReleaseDate = DateTime.Parse("2009-12-25"),
                    Genre = "Comedy, Drama",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "Dilwale Dulhania Le Jayenge",
                    ReleaseDate = DateTime.Parse("1995-10-20"),
                    Genre = "Drama, Romance",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Sholay",
                    ReleaseDate = DateTime.Parse("1975-08-15"),
                    Genre = "Action, Adventure",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Lagaan",
                    ReleaseDate = DateTime.Parse("2001-06-15"),
                    Genre = "Drama, Musical",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "PK",
                    ReleaseDate = DateTime.Parse("2014-12-19"),
                    Genre = "Comedy, Drama",
                    Price = 10.49M
                },
                new Movie
                {
                    Title = "Bahubali: The Beginning",
                    ReleaseDate = DateTime.Parse("2015-07-10"),
                    Genre = "Action, Drama",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "Mughal-E-Azam",
                    ReleaseDate = DateTime.Parse("1960-08-05"),
                    Genre = "Drama, Romance",
                    Price = 9.49M
                },
                new Movie
                {
                    Title = "Gadar: Ek Prem Katha",
                    ReleaseDate = DateTime.Parse("2001-06-15"),
                    Genre = "Action, Drama",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "Dangal",
                    ReleaseDate = DateTime.Parse("2016-12-23"),
                    Genre = "Action, Biography, Drama",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "Kabhi Khushi Kabhie Gham...",
                    ReleaseDate = DateTime.Parse("2001-12-14"),
                    Genre = "Drama, Musical, Romance",
                    Price = 9.99M
                }
            );
            context.SaveChanges();
        }
    }
}
