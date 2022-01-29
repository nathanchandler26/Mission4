using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class MoviesContext : DbContext
    {
        // Constructor

        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
        {

        }

        public DbSet<MovieResponse> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryTitle = "Action" },
                new Category { CategoryId = 2, CategoryTitle = "Comedy" },
                new Category { CategoryId = 3, CategoryTitle = "Drama" },
                new Category { CategoryId = 4, CategoryTitle = "Family" },
                new Category { CategoryId = 5, CategoryTitle = "Fantasy" },
                new Category { CategoryId = 6, CategoryTitle = "Horror" },
                new Category { CategoryId = 7, CategoryTitle = "Musical" },
                new Category { CategoryId = 8, CategoryTitle = "Mystery" },
                new Category { CategoryId = 9, CategoryTitle = "Romance" },
                new Category { CategoryId = 10, CategoryTitle = "Thriller" },
                new Category { CategoryId = 11, CategoryTitle = "Other" }
            );

            mb.Entity<MovieResponse>().HasData(

                new MovieResponse
                {
                    MovieId = 1,
                    CategoryId = 1,
                    Title = "The Dark Knight",
                    Year = 2008,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new MovieResponse
                {
                    MovieId = 2,
                    CategoryId = 4,
                    Title = "Ratatouille",
                    Year = 2007,
                    Director = "Brad Bird",
                    Rating = "G",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new MovieResponse
                {
                    MovieId = 3,
                    CategoryId = 7,
                    Title = "The Greatest Showman",
                    Year = 2017,
                    Director = "Michael Gracey",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }
                //These are three of my favorite movies seeded into the database (as the instructions say)
            );
        }
    }
}

