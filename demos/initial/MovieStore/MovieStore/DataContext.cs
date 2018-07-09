namespace MovieStore
{
    using MovieStore.Models;
    using System;
    using System.Collections.Generic;

    public static class DataContext
    {
        public static ICollection<Movie> Movies { get; set; } = new List<Movie>()
        {
            new Movie()
            {
                Title = "No Country for Old Men",
                ReleaseDate = new DateTime(2006, 1, 1),
                Rating = 8,
                Genre = "Thriller"
            },
            new Movie()
            {
                Title = "Scent of a Woman",
                ReleaseDate = new DateTime(1993, 1, 1),
                Rating = 7,
                Genre = "Drama"
            },
            new Movie()
            {
                Title = "The Departed",
                ReleaseDate = new DateTime(2006, 1, 1),
                Rating = 8,
                Genre = "Crime"
            },
            new Movie()
            {
                Title = "2001: A Space Odyssey",
                ReleaseDate = new DateTime(1968, 1, 1),
                Rating = 8,
                Genre = "Sci-Fi"
            },
            new Movie()
            {
                Title = "It",
                ReleaseDate = new DateTime(2017, 1, 1),
                Rating = 7,
                Genre = "Horror"
            },
            new Movie()
            {
                Title = "Vanilla Sky",
                ReleaseDate = new DateTime(2001, 1, 1),
                Rating = 6,
                Genre = "Drama"
            }
        };
    }
}
