using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore
{
    public static class DataContext
    {
        public static ICollection<Album> Albums { get; set; } = new List<Album>()
        {
            new Album() { Title = "Back In Black", ReleaseDate = new DateTime(1980) }
        };
    }
}