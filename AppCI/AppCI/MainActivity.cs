using Android.App;
using Android.Widget;
using Android.OS;
using AppCI;

namespace TestApp
{
	[Activity(Label = "TestApp", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			EditText txtUsername = FindViewById<EditText>(Resource.Id.username);
			EditText txtPassword = FindViewById<EditText>(Resource.Id.password);

			Button button = FindViewById<Button>(Resource.Id.loginBtn);

			button.Click += delegate {StartActivity(typeof(HomeScreen));};
		}
	}
}


