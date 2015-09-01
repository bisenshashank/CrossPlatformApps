// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Weather.iOS
{
	[Register ("FirstView")]
	partial class FirstView
	{
		[Outlet]
		UIKit.UILabel cityLabel { get; set; }

		[Outlet]
		UIKit.UILabel dateLabel { get; set; }

		[Outlet]
		UIKit.UIButton nextButton { get; set; }

		[Outlet]
		UIKit.UIButton prevButton { get; set; }

		[Outlet]
		UIKit.UILabel templabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (prevButton != null) {
				prevButton.Dispose ();
				prevButton = null;
			}

			if (nextButton != null) {
				nextButton.Dispose ();
				nextButton = null;
			}

			if (cityLabel != null) {
				cityLabel.Dispose ();
				cityLabel = null;
			}

			if (dateLabel != null) {
				dateLabel.Dispose ();
				dateLabel = null;
			}

			if (templabel != null) {
				templabel.Dispose ();
				templabel = null;
			}
		}
	}
}
