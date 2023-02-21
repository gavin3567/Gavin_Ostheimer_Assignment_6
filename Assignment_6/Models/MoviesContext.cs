using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_6.Models
{
    public class MoviesContext : DbContext
    {
        //Constructor
        public MoviesContext (DbContextOptions<MoviesContext> options) : base(options)
        {
            //Leave blank for now
        }

        public DbSet<MovieResponse> Responses { get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }


        // Seed data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieCategory>().HasData(
                    new MovieCategory { CategoryId = 1, CategoryName = "Action/Adventure"},
                    new MovieCategory { CategoryId = 2, CategoryName = "Comedy" },
                    new MovieCategory { CategoryId = 3, CategoryName = "Drama" },
                    new MovieCategory { CategoryId = 4, CategoryName = "Family" },
                    new MovieCategory { CategoryId = 5, CategoryName = "Horror/Suspense" },
                    new MovieCategory { CategoryId = 6, CategoryName = "Miscellaneous" },
                    new MovieCategory { CategoryId = 7, CategoryName = "Television" },
                    new MovieCategory { CategoryId = 8, CategoryName = "VHS" }
                );

            mb.Entity<MovieResponse>().HasData(
                    
                    new MovieResponse
                    {
                        MovieID = 1,
                        CategoryId = 1,
                        MovieTitle = "Morbius",
                        MovieYear = 2022,
                        MovieDirector = "Captain Morb",
                        MovieRating = "PG-13",
                        MovieEdited = true,
                        MovieLent = "Sir Morb II",
                        MovieNotes = "It's trash"
                    },

                    new MovieResponse
                    {
                        MovieID = 2,
                        CategoryId = 1,
                        MovieTitle = "Uncharted",
                        MovieYear = 2022,
                        MovieDirector = "Tom Holland",
                        MovieRating = "PG-13",
                        MovieEdited = false,
                        MovieLent = "Sir Tom III",
                        MovieNotes = "It's good"
                    },

                    new MovieResponse
                    {
                        MovieID = 3,
                        CategoryId = 1,
                        MovieTitle = "Black Panther",
                        MovieYear = 2017,
                        MovieDirector = "Iron Man",
                        MovieRating = "PG-13",
                        MovieEdited = false,
                        MovieLent = "The Hulk",
                        MovieNotes = "It's amazing"
                    }
                );
        }

    }
}
