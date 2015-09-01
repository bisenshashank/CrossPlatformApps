using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;
using Weather.Common.ViewModels;

namespace Weather.Android.Views
{
    [Activity(Label = "Weather")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
        }
    }
}