namespace MusicStore
{
    using MusicStore.Models;
    using System;
    using System.Collections.Generic;

    public static class DataContext
    {
        public static ICollection<Album> Albums { get; set; } = new List<Album>()
        {
            new Album() {
                Title = "Back In Black by AC/DC",
                ReleaseDate = new DateTime(1980, 1, 1),
                Genre = "Rock",
                CoverColor = "black"
            }
        };
    }
}