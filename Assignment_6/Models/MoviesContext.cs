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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieResponse>().HasData(
                    
                    new MovieResponse
                    {
                        MovieID = 1,
                        MovieCategory = "Action",
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
                        MovieCategory = "Action",
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
                        MovieCategory = "Action",
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
