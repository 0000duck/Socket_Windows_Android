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
	public partial class MainActivity : AppCompatActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.activity_main);


			MainRun();
		}

	}
public class ToastUtils
{
	static Toast toast = null;
	public static void Show(Context context, String text)
	{
		try
		{
			if (toast != null)
			{
				toast.SetText(text);
			}
			else
			{
				toast = Toast.MakeText(context, text, ToastLength.Short);
			}
			toast.Show();
		}
		catch (Exception)
		{
			Looper.Prepare();
			Toast.MakeText(context, text, ToastLength.Short).Show();
			Looper.Loop();
		}
	}
}

}
