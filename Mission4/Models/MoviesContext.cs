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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieResponse>().HasData(

                new MovieResponse
                {
                    MovieId = 1,
                    Category = "Action/Adventure",
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
                    Category = "Family/Comedy",
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
                    Category = "Musical/Drama",
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

