using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinYoutube.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovieDetailView : ContentPage
    {
        public MovieDetailView()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(2000);
            BackdropPath.TranslationY = 600;
            BackdropPath.IsVisible = true;
            await BackdropPath.TranslateTo(0, 0, 500, Easing.SinIn);
            await Task.Delay(700);
            Title.TranslationY = 600;
            Title.IsVisible = true;
            await Title.TranslateTo(0, 0, 500, Easing.SinInOut);
            await Task.Delay(400);
            TheGenres.TranslationY = 600;
            TheGenres.IsVisible = true;
            await TheGenres.TranslateTo(0, 0, 500, Easing.SinInOut);
            await Task.Delay(500);
            await Overview.TranslateTo(0, 0, 500, Easing.BounceOut);


        }
    }
}