using System;
using System.ComponentModel.DataAnnotations;

namespace MoshCourseApp.Models
{
    public class Movie
    {        
        public int Id { get; set; }

        [Required]//(ErrorMessage = "Please, enter name of the movie")]
        [StringLength(36)]
        public string Name { get; set; }
        
        public Genre Genre { get; set; }
       
        [Required(ErrorMessage = "Please, enter release date of the movie")]
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }
        
        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "Please, enter quantity in stock")]        
        [Range(1,25)]
        [Display(Name = "Number in Stock")]
        public int? NumberInStock { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }
    }
}
