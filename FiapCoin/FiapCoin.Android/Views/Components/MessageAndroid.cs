using System;
using Android.App;
using Android.Widget;
using APPCompassSP.Droid.Views.Components;
using APPCompassSP.Views.Components;

[assembly: Xamarin.Forms.Dependency(typeof(MessageAndroid))] 
namespace APPCompassSP.Droid.Views.Components
{
    public class MessageAndroid : IMessage
    {
        public void LongAlert(string message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Long).Show();
        }

        public void ShortAlert(string message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Short).Show();
        }
    }
}
