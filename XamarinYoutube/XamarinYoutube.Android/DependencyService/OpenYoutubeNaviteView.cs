using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using XamarinYoutube.DependencyService;
using XamarinYoutube.Droid.DependencyService;

[assembly: Dependency(typeof(OpenYoutubeNaviteView))]
namespace XamarinYoutube.Droid.DependencyService
{
    public class OpenYoutubeNaviteView : Activity, IOpenYoutubeNaviteView
    {
        public void Open(string Watch)
        {
            try
            {
                Intent intent = new Intent(Android.App.Application.Context, typeof(YouTubeActivity));
                intent.SetFlags(ActivityFlags.NewTask);
                intent.PutExtra("videoid", Watch);

                Android.App.Application.Context.StartActivity(intent);
            }
            catch (Exception)
            {
                // no implemented
                throw;
            }


        }
    }
}