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
        };
    }
}
