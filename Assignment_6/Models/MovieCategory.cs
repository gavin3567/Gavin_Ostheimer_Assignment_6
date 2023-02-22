using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_6.Models
{
    public class MovieCategory
    {
        [Key]
        [Required]
        public int MovieCategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
