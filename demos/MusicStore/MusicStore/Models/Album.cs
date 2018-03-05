namespace MusicStore.Models
{
    using System;

    public class Album
    {
        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }

        public string CoverColor { get; set; }
    }
}