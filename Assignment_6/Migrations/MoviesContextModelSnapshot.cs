﻿// <auto-generated />
using Assignment_6.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment_6.Migrations
{
    [DbContext(typeof(MoviesContext))]
    partial class MoviesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Assignment_6.Models.MovieResponse", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MovieCategory")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieDirector")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("MovieEdited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MovieLent")
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieNotes")
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieRating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<short>("MovieYear")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            MovieCategory = "Action",
                            MovieDirector = "Captain Morb",
                            MovieEdited = true,
                            MovieLent = "Sir Morb II",
                            MovieNotes = "It's trash",
                            MovieRating = "PG-13",
                            MovieTitle = "Morbius",
                            MovieYear = (short)2022
                        },
                        new
                        {
                            MovieID = 2,
                            MovieCategory = "Action",
                            MovieDirector = "Tom Holland",
                            MovieEdited = false,
                            MovieLent = "Sir Tom III",
                            MovieNotes = "It's good",
                            MovieRating = "PG-13",
                            MovieTitle = "Uncharted",
                            MovieYear = (short)2022
                        },
                        new
                        {
                            MovieID = 3,
                            MovieCategory = "Action",
                            MovieDirector = "Iron Man",
                            MovieEdited = false,
                            MovieLent = "The Hulk",
                            MovieNotes = "It's amazing",
                            MovieRating = "PG-13",
                            MovieTitle = "Black Panther",
                            MovieYear = (short)2017
                        });
                });
#pragma warning restore 612, 618
        }
    }
}