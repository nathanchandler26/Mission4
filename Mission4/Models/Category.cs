using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class Category
    {
        [Key]
        [Required] // This makes it a required field
        public int CategoryId { get; set; }
        public string CategoryTitle { get; set; }
    }
}
