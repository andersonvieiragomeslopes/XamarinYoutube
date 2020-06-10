using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using XamarinYoutube.Models;

namespace XamarinYoutube.ViewModels
{
    public class MoviesViewModel
    {
        public ObservableCollection<Movie> Movies {
            get;
            set;
        }
        public MoviesViewModel()
        {
            LoadMovie();
        }

        private void LoadMovie()
        {
            Movies = new ObservableCollection<Movie>
            {
                new Movie
                {
                    Title="Tropa de Elite",
                    Country = "",
                    PosterPath = "https://duastorres.com.br/wp-content/uploads/2018/01/Iron-Man-2.jpg",
                    Overview="",
                    Runtime="",
                    BackdropPath="",
                    TheGenres= "",
                    IdMovie=1,
                    ReleaseDate ="",
                    Year="",
                    YoutubeId=""
                },
                new Movie
                {
                    Title="Tropa de Elite",
                    Country = "",
                    PosterPath = "https://duastorres.com.br/wp-content/uploads/2018/01/Iron-Man-2.jpg",
                    Overview="",
                    Runtime="",
                    BackdropPath="",
                    TheGenres= "",
                    IdMovie=1,
                    ReleaseDate ="",
                    Year="",
                    YoutubeId=""
                },
                new Movie
                {
                    Title="Tropa de Elite",
                    Country = "",
                    PosterPath = "https://duastorres.com.br/wp-content/uploads/2018/01/Iron-Man-2.jpg",
                    Overview="",
                    Runtime="",
                    BackdropPath="",
                    TheGenres= "",
                    IdMovie=1,
                    ReleaseDate ="",
                    Year="",
                    YoutubeId=""
                },
                new Movie
                {
                    Title="Tropa de Elite",
                    Country = "",
                    PosterPath = "https://duastorres.com.br/wp-content/uploads/2018/01/Iron-Man-2.jpg",
                    Overview="",
                    Runtime="",
                    BackdropPath="",
                    TheGenres= "",
                    IdMovie=1,
                    ReleaseDate ="",
                    Year="",
                    YoutubeId=""
                },
                new Movie
                {
                    Title="Tropa de Elite",
                    Country = "",
                    PosterPath = "https://duastorres.com.br/wp-content/uploads/2018/01/Iron-Man-2.jpg",
                    Overview="",
                    Runtime="",
                    BackdropPath="",
                    TheGenres= "",
                    IdMovie=1,
                    ReleaseDate ="",
                    Year="",
                    YoutubeId=""
                },
                new Movie
                {
                    Title="Tropa de Elite",
                    Country = "",
                    PosterPath = "https://duastorres.com.br/wp-content/uploads/2018/01/Iron-Man-2.jpg",
                    Overview="",
                    Runtime="",
                    BackdropPath="",
                    TheGenres= "",
                    IdMovie=1,
                    ReleaseDate ="",
                    Year="",
                    YoutubeId=""
                },
                new Movie
                {
                    Title="Tropa de Elite",
                    Country = "",
                    PosterPath = "https://duastorres.com.br/wp-content/uploads/2018/01/Iron-Man-2.jpg",
                    Overview="",
                    Runtime="",
                    BackdropPath="",
                    TheGenres= "",
                    IdMovie=1,
                    ReleaseDate ="",
                    Year="",
                    YoutubeId=""
                },
            };
        }
    }
}
