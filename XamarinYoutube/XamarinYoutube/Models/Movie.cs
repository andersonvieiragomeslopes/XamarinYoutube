using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinYoutube.Models
{
    public class Movie
    {
        public int IdMovie { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public string BackdropPath { get; set; }
        public string PosterPath { get; set; }
        public string ReleaseDate { get; set; }
        public string Year { get; set; }
        public string Country { get; set; }
        public string Runtime { get; set; }
        public string TheGenres { get; set; }
        public string YoutubeId { get; set; }
    }
}
