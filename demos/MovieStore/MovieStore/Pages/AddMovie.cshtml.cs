namespace MovieStore.Pages
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using MovieStore.Models;
    using System.Collections.Generic;

    public class AddMovie : PageModel
    {
        /* Razor Pages introduce a new model-binding attribute, [BindProperty], 
         * which is especially useful on forms.You can apply this attribute to a property 
         * on a Razor Page (with or without an explicit PageModel) to opt into data binding 
         * for non-GET requests to the page.This enables tag helpers like asp-for and asp-validation-for
         * to work with the property you’ve specified, and allows handlers to work with bound properties 
         * without having to specify them as method parameters. The [BindProperty] attribute also works on Controllers.*/
        [BindProperty]
        public Movie Movie { get; set; }

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
