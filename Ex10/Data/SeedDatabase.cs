using Ex10.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Ex10.Data
{
    public static class SeedDatabase
    {
        public static void Initialize(IServiceProvider provider)
        {
            using (var context = new MainContext(provider.GetRequiredService<DbContextOptions<MainContext>>()))
            {
                if (context.Movie.Any()) 
                {
                    return;
                }


                context.Movie.AddRange
                (
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99,
                        Rating = "Z"

                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99,
                        Rating = "G"
                    }
                ) ;

                context.SaveChanges();

            }
        }
    }
}
