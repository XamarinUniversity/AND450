using System;
using Android.App;
using Android.Widget;
using Android.OS;

namespace MyApp
{
	[Activity(Label = "MyApp", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.Main);

			Button button = FindViewById<Button>(Resource.Id.myButton);
			
			button.Click += delegate
				{
					double result = Com.Xamarin.Pi.Calculate(10000);

					button.Text = result.ToString();
				};
		}
	}
}