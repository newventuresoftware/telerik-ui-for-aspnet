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
                Id = 1,
                Title = "Back In Black by AC/DC",
                ReleaseDate = new DateTime(1980, 1, 1),
                Genre = "Rock",
                CoverColor = "black"
            },
            new Album() {
                Id = 2,
                Title = "Perfect Strangers by Deep Purple",
                ReleaseDate = new DateTime(1986, 1, 1),
                Genre = "Rock",
                CoverColor = "purple"
            },
            new Album() {
                Id = 3,
                Title = "The Eminem Show",
                ReleaseDate = new DateTime(2000, 1, 1),
                Genre = "Rap",
                CoverColor = "orange"
            },
            new Album() {
                Id = 4,
                Title = "Music by Madonna",
                ReleaseDate = new DateTime(2000, 1, 1),
                Genre = "Pop",
                CoverColor = "red"
            }
        };
    }
}