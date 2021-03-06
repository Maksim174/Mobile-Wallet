﻿using System;
using Android.App;
using Android.OS;
using Android.Widget;

namespace Mobile_Wallet
{
	[Activity(Label = "Help")]
	public class Help : Activity
	{
		Button button1, button2;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.Help);
			button1 = FindViewById<Button>(Resource.Id.button1);
			button1.Click += new EventHandler (button1_click);
			button2 = FindViewById<Button>(Resource.Id.button2);
			button2.Click += new EventHandler (button2_click);
		}
			void button1_click(object sender, System.EventArgs e)
			{
				StartActivity(typeof(Problem));
			}
			void button2_click(object sender, System.EventArgs e)
			{
				StartActivity(typeof(Guess));
			}

	}
}

