using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.ViewModels;
using System.Collections.Generic;
using System.Text;
using Cirrious.MvvmCross.Touch.Platform;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using Weather.Common;
using UIKit;

namespace Weather.Ios
{
	public class Setup : MvxTouchSetup
	{
		public Setup(MvxApplicationDelegate appDelegate, IMvxTouchViewPresenter presenter)
			: base(appDelegate, presenter)
		{
		}

		protected override IMvxApplication CreateApp()
		{
			return new App();
		}
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
	}
}