using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
//_______________________________
using System;
using System.Threading;
using Android.Content;
using Android.Runtime;
using Android.Views;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Android_Client
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        }
    }
}

