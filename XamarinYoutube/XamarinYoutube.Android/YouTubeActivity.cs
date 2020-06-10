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
using Com.Google.Android.Youtube.Player;
using Java.Lang.Reflect;

namespace XamarinYoutube.Droid
{
    [Activity(
        Label = "Youtube")]
    public class YouTubeActivity : YouTubeBaseActivity, IYouTubePlayerOnInitializedListener
    {
        YouTubePlayerView youTubeView;
        public string idvideo = string.Empty;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            RequestWindowFeature(WindowFeatures.NoTitle);
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Youtube_Player);
            idvideo = Intent.GetStringExtra("videoid"); // gets the previously created intent ;)

            youTubeView = FindViewById<YouTubePlayerView>(Resource.Id.videoplayeryoutube);
            youTubeView.Initialize(AppSettings.DEVELOPER_KEY, this);
            

        }
        public void OnInitializationFailure(IYouTubePlayerProvider p0, YouTubeInitializationResult youTubeInitializationResult)
        {
            // no implemented
           //  Toast.MakeText(this, youTubeInitializationResult.ToString(), ToastLength.Short).Show();

            throw new NotImplementedException();
        }

        public void OnInitializationSuccess(IYouTubePlayerProvider p0, IYouTubePlayer player, bool p2)
        {
            try
            {
                player.LoadVideo(idvideo);
                player.SetFullscreen(true);
                player.SetShowFullscreenButton(false);
            }
            catch (Exception)
            {

                throw;
            }
        }
        //Method 2
        //public IYouTubePlayer YoutubePlayerVideo;
        // oncreate YoutubePlayerVideo?.LoadVideo(idvideo);

    }
}