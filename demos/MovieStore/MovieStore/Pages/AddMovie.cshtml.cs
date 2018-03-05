namespace MovieStore.Pages
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using MovieStore.Models;
    using System.Collections.Generic;

    public class AddMovie : PageModel
    {
        [BindProperty]
        public Movie Movie { get; set; }

        [BindProperty]
        public IEnumerable<string> Genres { get; set; } = 
            new string[] { "Action", "Drama", "Comedy", "Horror", "Documentary", "Thriller", "Romance" };

        public IActionResult OnPost(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            DataContext.Movies.Add(movie);
            return RedirectToPage("Movies");
        }
    }
}
