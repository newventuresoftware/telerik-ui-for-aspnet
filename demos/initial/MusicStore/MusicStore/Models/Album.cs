namespace MusicStore.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Album
    {
        [Required]
        public int Id { get; set; }
         
        [Required]
        [StringLength(30, ErrorMessage = "The length should not exceed 30 characters.")]
        //[RegularExpression("[A-Za-z]+", ErrorMessage = "Title Contains Invalid Characters!")]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        
        public string Genre { get; set; }

        [Display(Name = "Cover Color")]
        public string CoverColor { get; set; }
    }
}