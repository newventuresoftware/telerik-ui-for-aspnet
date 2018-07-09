namespace MovieStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Genre { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:N1}", ApplyFormatInEditMode = true)]
        [Range(1, 10, ErrorMessage = "The rating should be a number between 1 and 10.")]
        public int Rating { get; set; }
    }
}
