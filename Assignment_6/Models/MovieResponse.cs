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
        [Required(ErrorMessage = "Inputting the movie title is required")]
        public string MovieTitle { get; set; }
        [Required(ErrorMessage = "Inputting the movie year is required")]
        public short MovieYear { get; set; }
        [Required(ErrorMessage = "The Director's name is required")]
        public string MovieDirector { get; set; }
        [Required (ErrorMessage = "Movie Rating is required")]
        public string MovieRating { get; set; }
        public bool MovieEdited { get; set; }
        public string MovieLent { get; set; }
        public string MovieNotes { get; set; }

        // Build Foreign Key Relationship
        [Required]
        public int MovieCategoryId { get; set; }
        public MovieCategory MovieCategory { get; set; }
    }
}
