using Android.App;
using Android.Widget;
using Android.OS;
using System;
namespace Mobile_Wallet
{
	[Activity(Label = "Mobile_Wallet", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		Button button1, button2, button3, button4;

	protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.Main);
			button1 = FindViewById<Button>(Resource.Id.button1);
			button1.Click += new EventHandler(button1_click);
			button3 = FindViewById<Button>(Resource.Id.button3);
			button3.Click += new EventHandler(button3_click);
			button4 = FindViewById<Button>(Resource.Id.button4);
			button4.Click += new EventHandler(button4_click);

		}
		void button1_click(object sender, System.EventArgs e)
		{
			StartActivity(typeof(Cost));
		}
		void button3_click(object sender, System.EventArgs e)
		{
			StartActivity(typeof(Help));
		}
		void button4_click(object sender, System.EventArgs e)
		{
			StartActivity(typeof(INFO));
		}
	}
}



