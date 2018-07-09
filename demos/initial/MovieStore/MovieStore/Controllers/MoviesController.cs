// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieStore.Controllers
{
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;
    using Microsoft.AspNetCore.Mvc;
    using MovieStore.Models;

    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get([DataSourceRequest] DataSourceRequest request) => 
            new JsonResult(DataContext.Movies.ToDataSourceResult(request));
    }
}
