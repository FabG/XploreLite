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
		MonoTouch.UIKit.UIButton buttonSAxM { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton buttonSAxC { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (buttonSAxM != null) {
				buttonSAxM.Dispose ();
				buttonSAxM = null;
			}

			if (buttonSAxC != null) {
				buttonSAxC.Dispose ();
				buttonSAxC = null;
			}
		}
	}
}
