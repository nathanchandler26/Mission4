using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class MovieResponse
    {
        [Key]
        [Required] // This makes it a required field
        public int MovieId { get; set; }
        [Required] // This makes it a required field
        public string Category { get; set; }
        [Required] // This makes it a required field
        public string Title { get; set; }
        [Required] // This makes it a required field
        public int Year { get; set; }
        [Required] // This makes it a required field
        public string Director { get; set; }
        [Required] // This makes it a required field
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [StringLength(25)] // This limits the input to 25 characters
        public string Notes { get; set; }
    }
}
