using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinYoutube.ViewModels;
using XamarinYoutube.Views;

namespace XamarinYoutube.Models
{
    public class Movie
    {
        private MoviesDetailViewModel vm;
        public MoviesDetailViewModel VM {
            get => vm; set {
                vm = value;
            }
        }
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
        public Movie()
        {
        }
        public ICommand OpenCommand {
            get {
                return new RelayCommand(Open);
            }
        }

        private async void Open()
        {
            vm = new MoviesDetailViewModel(this);

            await Application.Current.MainPage.Navigation.PushAsync(new MovieDetailView());
        }

    }
}
