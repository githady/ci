﻿
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
using AppCI;

namespace DemoApp
{
	[Activity(Label = "HomeScreen")]
	public class HomeScreen : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);

			Button button = FindViewById<Button>(Resource.Id.btnGoBack);
			button.Click += delegate { Finish(); };
		}
	}
}

