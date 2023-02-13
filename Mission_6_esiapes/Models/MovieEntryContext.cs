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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                //Manually adding entries into database
                new ApplicationResponse
                {
                    MovieID = 1,
                    Category = "Action/Adventure",
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
                    Category = "Action/Adventure",
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
                    Category = "Action/Adventure",
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
