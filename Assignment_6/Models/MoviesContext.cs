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
                    new MovieCategory { MovieCategoryId = 1, CategoryName = "Action/Adventure"},
                    new MovieCategory { MovieCategoryId = 2, CategoryName = "Comedy" },
                    new MovieCategory { MovieCategoryId = 3, CategoryName = "Drama" },
                    new MovieCategory { MovieCategoryId = 4, CategoryName = "Family" },
                    new MovieCategory { MovieCategoryId = 5, CategoryName = "Horror/Suspense" },
                    new MovieCategory { MovieCategoryId = 6, CategoryName = "Miscellaneous" },
                    new MovieCategory { MovieCategoryId = 7, CategoryName = "Television" },
                    new MovieCategory { MovieCategoryId = 8, CategoryName = "VHS" }
                );

            mb.Entity<MovieResponse>().HasData(
                    
                    new MovieResponse
                    {
                        MovieID = 1,
                        MovieCategoryId = 1,
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
                        MovieCategoryId = 1,
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
                        MovieCategoryId = 1,
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
