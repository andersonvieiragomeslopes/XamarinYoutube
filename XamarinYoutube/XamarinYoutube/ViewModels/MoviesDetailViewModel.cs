using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using XamarinYoutube.DependencyService;
using XamarinYoutube.Models;

namespace XamarinYoutube.ViewModels
{
    public class MoviesDetailViewModel
    {
        public Movie movies;

        public int IdMovie { get; set; } = 1;
        public string Title { get; set; } = "O Auto da Compadecida";
        public string BackdropPath { get; set; } = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/m8eFedsS7vQCZCS8WGp5n1bVD0q.jpg";
        public string Overview { get; set; } = "O Auto da Compadecida: As aventuras dos nordestinos João Grilo (Matheus Natchergaele), um sertanejo pobre e mentiroso, e Chicó (Selton Mello), o mais covarde dos homens. Ambos lutam pelo pão de cada dia e atravessam por vários episódios enganando a todos do pequeno vilarejo de Taperoá, no sertão da Paraíba. A salvação da dupla acontece com a aparição da Nossa Senhora (Fernanda Montenegro). Adaptação da obra de Ariano Suassuna.";
        public string PosterPath { get; set; } = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/m8eFedsS7vQCZCS8WGp5n1bVD0q.jpg";
        public string ReleaseDate { get; set; } = "15/09/2000";
        public string Year { get; set; } = "2000";
        public string Country { get; set; } = "Brasil";
        public string Runtime { get; set; } = "104";
        public string TheGenres { get; set; } = "Aventura, Comédia";
        public string YoutubeId { get; set; } = "XPuMu_ENzlg";

        public ICommand WatchCommandTrailer {
            get {
                return new RelayCommand(WatchTrailer);
            }
        }
        private void WatchTrailer()
        {
            Xamarin.Forms.DependencyService.Get<IOpenYoutubeNaviteView>().Open(YoutubeId);
        }

    }
}
