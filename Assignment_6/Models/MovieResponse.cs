using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_6.Models
{
    public class MovieResponse
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required]
        public string MovieCategory { get; set; }
        [Required]
        public string MovieTitle { get; set; }
        [Required]
        public short MovieYear { get; set; }
        [Required]
        public string MovieDirector { get; set; }
        [Required]
        public string MovieRating { get; set; }
        public bool MovieEdited { get; set; }
        public string MovieLent { get; set; }
        public string MovieNotes { get; set; }
    }
}
