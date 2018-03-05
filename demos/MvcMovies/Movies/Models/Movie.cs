using System;
using System.ComponentModel.DataAnnotations;

namespace Movies.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You need to specify a title!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The title should be between 3 and 30 symbols long.")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [RegularExpression("[A-Za-z]+", ErrorMessage = "Only latin letters allowed!")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "The genre should be between 3 and 30 symbols long.")]
        public string Genre { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:N1}", ApplyFormatInEditMode = true)]
        [Range(1, 10, ErrorMessage = "The rating can be a number between 1 and 10.")]
        public double Rating { get; set; }
    }
}