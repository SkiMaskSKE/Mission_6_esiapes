using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_6_esiapes.Models
{
    public class MovieEntryContext : DbContext
    {
        //Constructor
        public MovieEntryContext(DbContextOptions<MovieEntryContext> options) : base(options)
        {
            //Leaving blank
        }
        public DbSet<ApplicationResponse> Responses { get; set; }

        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
              mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Action/Adventure" },
                new Category { CategoryId = 2, CategoryName = "Comedy" },
                new Category { CategoryId = 3, CategoryName = "Drama" },
                new Category { CategoryId = 4, CategoryName = "Family" },
                new Category { CategoryId = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 7, CategoryName = "Television" },
                new Category { CategoryId = 8, CategoryName = "VHS" }
              );

            mb.Entity<ApplicationResponse>().HasData(
                //Manually adding entries into database
                new ApplicationResponse
                {
                    MovieID = 1,
                    CategoryId = 1,
                    Title = "Plane",
                    Year = 2023,
                    Director = "Jean-Francois Richet",
                    Rating = "R",
                    Edited = false,
                    LentTo = "",
                    Notes=""

                },
                new ApplicationResponse
                {
                    MovieID =2,
                    CategoryId = 2,
                    Title = "Black Panther",
                    Year = 2022,
                    Director = "Ryan Coogler",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""

                },
                new ApplicationResponse
                {
                    MovieID = 3,
                    CategoryId = 3,
                    Title = "Black Adam",
                    Year = 2022,
                    Director = "Jaume Collet-Serra",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""

                });
        }
    }
}
