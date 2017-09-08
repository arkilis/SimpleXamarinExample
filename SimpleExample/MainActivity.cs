using Android.App;
using Android.Widget;
using Android.OS;

namespace SimpleExample
{
    [Activity(Label = "SimpleExample", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += delegate {
				AlertDialog.Builder alert = new AlertDialog.Builder(this);
				alert.SetTitle("Simple Example");
				alert.SetMessage("This is a simple example");
				alert.SetPositiveButton("OK", (senderAlert, args) => {
					Toast.MakeText(this, "Button Click!", ToastLength.Short).Show();
				});
				Dialog dialog = alert.Create();
				dialog.Show();
            };
        }
    }
}

