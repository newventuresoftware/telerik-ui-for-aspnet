namespace MusicStore.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Album
    {
        [Required]
        [StringLength(20, ErrorMessage = "The length should not exceed 20 characters.")]
        public string Title { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }
        
        public string Genre { get; set; }

        [Display(Name = "Cover Color")]
        public string CoverColor { get; set; }
    }
}