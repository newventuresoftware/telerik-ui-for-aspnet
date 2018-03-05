namespace MovieStore.Pages
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using MovieStore.Models;

    public class AddMovie : PageModel
    {
        [BindProperty]
        public Movie Movie { get; set; }
        
        public IActionResult OnPost(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            DataContext.Movies.Add(movie);
            return RedirectToPage("Movies");
        }


        public IActionResult GetGenres()
        {
            return new JsonResult(new string[] { "One", "Two" });
        }
    }
}
