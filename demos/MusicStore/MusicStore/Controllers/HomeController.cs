namespace MusicStore.Controllers
{
    using MusicStore.Models;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Albums()
        {
            return View(DataContext.Albums);
        }

        public ActionResult AddAlbum()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAlbum(Album album)
        {
            DataContext.Albums.Add(album);
            return RedirectToAction("Albums", "Home");
        }
    }
}