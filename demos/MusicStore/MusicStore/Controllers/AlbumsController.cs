namespace MVCSandbox.Controllers
{
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;
    using MusicStore;
    using MusicStore.Models;
    using System.Linq;
    using System.Web.Mvc;

    public class AlbumsController : Controller
    {
        public ActionResult Index()
        {
            return View(DataContext.Albums);
        }

        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Album album)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            album.Id = DataContext.Albums.Count + 1;

            DataContext.Albums.Add(album);
            return RedirectToAction("Index", "Albums");
        }

        [HttpPost]
        // The DataSourceRequest attribute is a custom model binder
        // it parses the specific format of the kendo widget request to a C# object
        public ActionResult GetAlbums([DataSourceRequest] DataSourceRequest request)
        {
            // The ToDataSourceResult is a part of the Kendo.Mvc.Extensions namespace
            // it extends IEnumerable and IQueriable collections and performs the requested paging, filtering, sorting, etc.
            var result = DataContext.Albums.ToDataSourceResult(request);
            return this.Json(result);
        }

        [HttpPost]
        public ActionResult EditAlbum([DataSourceRequest] DataSourceRequest request, Album album)
        {
            var dbAlbum = DataContext.Albums.FirstOrDefault(m => m.Id == album.Id);

            if (this.ModelState.IsValid && album != null)
            {
                dbAlbum.Title = album.Title;
                dbAlbum.Genre = album.Genre;
                dbAlbum.ReleaseDate = album.ReleaseDate;
                dbAlbum.CoverColor = album.CoverColor;
            }

            var result = new[] { dbAlbum }.ToDataSourceResult(request, this.ModelState);

            return this.Json(result);
        }

        [HttpPost]
        public ActionResult DeleteAlbum([DataSourceRequest] DataSourceRequest request, Album album)
        {
            var dbAlbum = DataContext.Albums.FirstOrDefault(a => a.Id == album.Id);

            if (dbAlbum != null)
            {
                DataContext.Albums.Remove(dbAlbum);
            }

            var result = new[] { dbAlbum }.ToDataSourceResult(request, this.ModelState);
            return this.Json(result);
        }
    }
}