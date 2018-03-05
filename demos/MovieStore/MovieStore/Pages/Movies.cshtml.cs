namespace MovieStore.Pages
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using MovieStore.Models;

    public class Movies : PageModel
    {
        public IEnumerable<Movie> MovieList => DataContext.Movies;

        public void OnGet()
        {
            
        }
    }
}
