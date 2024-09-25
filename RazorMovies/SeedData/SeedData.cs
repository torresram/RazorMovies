using Microsoft.EntityFrameworkCore;
using RazorMovies.Data;
using RazorMovies.Models;

namespace RazorMovies.SeedData
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorMoviesContext(serviceProvider.GetRequiredService<DbContextOptions<RazorMoviesContext>>()))
            {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("NUll RazorMoviesContext");
                }

                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 200,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Ghostbusters",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 999,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 399,
                        Rating = "R"
                    }
                    );

                context.SaveChanges();
            }
        }
    }
}
