// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace Xplore_Lite
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton buttonSaxMLaunch { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton buttonSaxCLaunch { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (buttonSaxMLaunch != null) {
				buttonSaxMLaunch.Dispose ();
				buttonSaxMLaunch = null;
			}

			if (buttonSaxCLaunch != null) {
				buttonSaxCLaunch.Dispose ();
				buttonSaxCLaunch = null;
			}
		}
	}
}
