// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieStore.Controllers
{
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;
    using Microsoft.AspNetCore.Mvc;
    using MovieStore.Models;
    using System.Linq;

    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get([DataSourceRequest] DataSourceRequest request) => 
            new JsonResult(DataContext.Movies.ToDataSourceResult(request));

        [HttpPut, Route("update")]
        public ActionResult UpdateAlbum([DataSourceRequest] DataSourceRequest request, Movie movie)
        {
            var dbMovie = DataContext.Movies.FirstOrDefault(m => m.Id == movie.Id);

            if (this.ModelState.IsValid && movie != null)
            {
                dbMovie.Title = movie.Title;
                dbMovie.Genre = movie.Genre;
                dbMovie.ReleaseDate = movie.ReleaseDate;
                dbMovie.Rating = movie.Rating;
            }

            var result = new[] { dbMovie }.ToDataSourceResult(request, this.ModelState);

            return this.Json(result);
        }

        [HttpDelete, Route("delete")]
        public ActionResult DeleteAlbum([DataSourceRequest] DataSourceRequest request, Movie movie)
        {
            var dbMovie = DataContext.Movies.FirstOrDefault(a => a.Id == movie.Id);

            if (dbMovie != null)
            {
                DataContext.Movies.Remove(dbMovie);
            }

            var result = new[] { dbMovie }.ToDataSourceResult(request, this.ModelState);
            return this.Json(result);
        }
    }
}
