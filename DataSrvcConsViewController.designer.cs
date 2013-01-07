// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace Xplore_Lite
{
	[Register ("DataSrvcConsViewController")]
	partial class DataSrvcConsViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIView DSCUIView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton DSCIndicButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton DSCDateButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton DSCCustButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton DSCAgeButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel DSCDateLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (DSCUIView != null) {
				DSCUIView.Dispose ();
				DSCUIView = null;
			}

			if (DSCIndicButton != null) {
				DSCIndicButton.Dispose ();
				DSCIndicButton = null;
			}

			if (DSCDateButton != null) {
				DSCDateButton.Dispose ();
				DSCDateButton = null;
			}

			if (DSCCustButton != null) {
				DSCCustButton.Dispose ();
				DSCCustButton = null;
			}

			if (DSCAgeButton != null) {
				DSCAgeButton.Dispose ();
				DSCAgeButton = null;
			}

			if (DSCDateLabel != null) {
				DSCDateLabel.Dispose ();
				DSCDateLabel = null;
			}
		}
	}
}
