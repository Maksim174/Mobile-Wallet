using Android.App;
using Android.Widget;
using Android.OS;
using System;
namespace Mobile_Wallet
{
	[Activity(Label = "Mobile_Wallet", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{

	protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.Main);
			Button button1 = FindViewById<Button>(Resource.Id.button1);
			button1.Click += new EventHandler(button1_click);
			Button button2 = FindViewById<Button>(Resource.Id.button2);
			button2.Click += new EventHandler(button2_click);
			Button button3 = FindViewById<Button>(Resource.Id.button3);
			button3.Click += new EventHandler(button3_click);
			Button button4 = FindViewById<Button>(Resource.Id.button4);
			button4.Click += new EventHandler(button4_click);

		}
		void button1_click(object sender, System.EventArgs e)
		{
			StartActivity(typeof(Cost));
		}
		void button2_click(object sender, System.EventArgs e)
		{
			StartActivity(typeof(List));
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



