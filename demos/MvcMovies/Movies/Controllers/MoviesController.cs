using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Movies.Models;

namespace Movies.Controllers
{
    public class MoviesController : Controller
    {
        private static ICollection<Movie> movies = new List<Movie>()
        {
            new Movie()
            {
                Id = 1,
                Title = "The Shawshank Redemption",
                Rating = 9.3,
                ReleaseDate = new DateTime(1994, 10, 14),
                Genre = "Crime"
            },
            new Movie()
            {
                Id = 2,
                Title = "The Godfather",
                Rating = 9.2,
                ReleaseDate = new DateTime(1972, 3, 24),
                Genre = "Crime"
            },
            new Movie()
            {
                Id = 3,
                Title = "The Godfather II",
                Rating = 9,
                ReleaseDate = new DateTime(1974, 12, 20),
                Genre = "Crime"
            },
            new Movie()
            {
                Id = 4,
                Title = "The Dark Knight",
                Rating = 9,
                ReleaseDate = new DateTime(2008, 7, 18),
                Genre = "Action"
            },
            new Movie()
            {
                Id = 5,
                Title = "12 Angry Men",
                Rating = 8.9,
                ReleaseDate = new DateTime(1957, 4, 1),
                Genre = "Crime"
            },
            new Movie()
            {
                Id = 6,
                Title = "Schindler's List",
                Rating = 8.9,
                ReleaseDate = new DateTime(1994, 2, 4),
                Genre = "Drama"
            },
            new Movie()
            {
                Id = 7,
                Title = "Pulp Fiction",
                Rating = 8.9,
                ReleaseDate = new DateTime(1994, 10, 14),
                Genre = "Crime"
            },
            new Movie()
            {
                Id = 8,
                Title = "The Lord of the Rings: The Return of the King",
                Rating = 8.8,
                ReleaseDate = new DateTime(2003, 12, 17),
                Genre = "Fantasy"
            },
            new Movie()
            {
                Id = 9,
                Title = "The Good, the Bad and the Ugly",
                Rating = 8.8,
                ReleaseDate = new DateTime(1967, 12, 29),
                Genre = "Western"
            },
            new Movie()
            {
                Id = 10,
                Title = "Fight Club",
                Rating = 8.7,
                ReleaseDate = new DateTime(1999, 10, 15),
                Genre = "Drama"
            },
            new Movie()
            {
                Id = 11,
                Title = "The Lord of the Rings: The Fellowship of the Ring",
                Rating = 8.6,
                ReleaseDate = new DateTime(2001, 12, 19),
                Genre = "Fantasy"
            },
            new Movie()
            {
                Id = 12,
                Title = "Forrest Gump",
                Rating = 8.6,
                ReleaseDate = new DateTime(2004, 6, 6),
                Genre = "Drama"
            },
            new Movie()
            {
                Id = 13,
                Title = "Star Wars: Episode V - The Empire Strikes Back",
                Rating = 8.6,
                ReleaseDate = new DateTime(1980, 6, 20),
                Genre = "Fantasy"
            },
            new Movie()
            {
                Id = 14,
                Title = "Inception",
                Rating = 8.5,
                ReleaseDate = new DateTime(2010, 6, 16),
                Genre = "Fantasy"
            },
            new Movie()
            {
                Id = 15,
                Title = "The Lord of the Rings: The Two Towers",
                Rating = 8.4,
                ReleaseDate = new DateTime(2002, 12, 18),
                Genre = "Fantasy"
            }
        };

        [HttpPost]
        // the DataSourceRequest attribute is a custom model binder
        // it parses the specific format of the kendo widget request to a C# object
        public ActionResult GetMovies([DataSourceRequest] DataSourceRequest request)
        {
            // the ToDataSourceResult is a part of the Kendo.Mvc.Extensions namespace
            // it extends IEnumerable and IQueriable collections and performs the requested paging, filtering, sorting, etc.
            var result = movies.ToDataSourceResult(request);
            return this.Json(result);
        }

        [HttpPost]
        public ActionResult CreateMovie([DataSourceRequest] DataSourceRequest request, Movie movie)
        {
            if (this.ModelState.IsValid)
            {
                movie.Id = movies.Count + 1;
                movies.Add(movie);
            }

            var result = new[] { movie }.ToDataSourceResult(request, this.ModelState);
            return this.Json(result);
        }

        [HttpPost]
        public ActionResult EditMovie([DataSourceRequest] DataSourceRequest request, Movie movie)
        {
            var dbMovie = movies.FirstOrDefault(m => m.Id == movie.Id);
            if (this.ModelState.IsValid && dbMovie != null)
            {
                dbMovie.Rating = movie.Rating;
                dbMovie.ReleaseDate = movie.ReleaseDate;
                dbMovie.Title = movie.Title;
                dbMovie.Genre = movie.Genre;
            }

            var result = new[] { dbMovie }.ToDataSourceResult(request, this.ModelState);
            return this.Json(result);
        }

        [HttpPost]
        public ActionResult DeleteMovie([DataSourceRequest] DataSourceRequest request, Movie movie)
        {
            var dbMovie = movies.FirstOrDefault(m => m.Id == movie.Id);
            if (dbMovie != null)
            {
                movies.Remove(dbMovie);
            }

            var result = new[] { dbMovie }.ToDataSourceResult(request, this.ModelState);
            return this.Json(result);
        }
    }
}