using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
using Weather.Common.ViewModels;
using System.Linq;


namespace Weather.iOS
{
	public partial class FirstView : MvxViewController
	{
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			var set = this.CreateBindingSet<FirstView, FirstViewModel>();
			set.Bind(this.cityLabel).To(vm => vm.DailyTemperature.City);
			set.Bind(this.dateLabel).To(vm => vm.DailyTemperature.ShortDate);
			set.Bind(this.templabel).To(vm => vm.DailyTemperature.Temperature);
			set.Bind(this.prevButton).To(vm => vm.PreviousCommand);
			set.Bind(this.nextButton).To(vm => vm.NextCommand);
			set.Bind(this.nextButton).For(b => b.Enabled).To(vm => vm.IsNext);
			set.Bind(this.prevButton).For(b => b.Enabled).To(vm => vm.IsPrevious);
			set.Apply();
		}


	}
}

