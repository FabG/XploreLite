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
		MonoTouch.UIKit.UILabel DSCLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (DSCUIView != null) {
				DSCUIView.Dispose ();
				DSCUIView = null;
			}

			if (DSCLabel != null) {
				DSCLabel.Dispose ();
				DSCLabel = null;
			}
		}
	}
}
