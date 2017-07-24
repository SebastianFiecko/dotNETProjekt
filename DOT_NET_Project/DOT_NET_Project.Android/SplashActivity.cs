
using Android.App;
using Android.Support.V7.App;

namespace DOT_NET_Project.Droid
{
    [Activity(Label = "DOT_NET_Project", Icon = "@drawable/icon", Theme = "@style/splashscreen", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnResume()
        {
            base.OnResume();
            StartActivity(typeof(MainActivity));
        }
    }
}