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
            Movies = new ObservableCollection<Movie>();
            LoadMovie();
        }

        private void LoadMovie()
        {
            Movies = new ObservableCollection<Movie>
            {
                new Movie
                {
                    Title="Tropa de Elite",
                    Country = "Brasil",
                    PosterPath = "https://duastorres.com.br/wp-content/uploads/2018/01/Iron-Man-2.jpg",
                    Overview="sdhsdfhsjkdfsdf",
                    Runtime="60",
                    BackdropPath="https://duastorres.com.br/wp-content/uploads/2018/01/Iron-Man-2.jpg",
                    TheGenres= "Adulto, Romance, Terror",
                    IdMovie=1,
                    ReleaseDate ="2019",
                    Year="2019",
                    YoutubeId="gdfgfg5"
                },
                new Movie
                {
                    Title="Tropa de Elite",
                    Country = "Brasil",
                    PosterPath = "https://duastorres.com.br/wp-content/uploads/2018/01/Iron-Man-2.jpg",
                    Overview="sdhsdfhsjkdfsdf",
                    Runtime="60",
                    BackdropPath="https://duastorres.com.br/wp-content/uploads/2018/01/Iron-Man-2.jpg",
                    TheGenres= "Adulto, Romance, Terror",
                    IdMovie=1,
                    ReleaseDate ="2019",
                    Year="2019",
                    YoutubeId="gdfgfg5"
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
