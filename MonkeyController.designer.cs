// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace Xplore_Lite
{
	[Register ("MonkeyController")]
	partial class MonkeyController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton buttonSAxMDSA { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton buttonSAxMTPA { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton buttonSAxMDA { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton buttonSAxMCIA { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton buttonSAxMCOA { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton buttonSAxMUR { get; set; }

		[Action ("clicked:")]
		partial void clicked (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (buttonSAxMDSA != null) {
				buttonSAxMDSA.Dispose ();
				buttonSAxMDSA = null;
			}

			if (buttonSAxMTPA != null) {
				buttonSAxMTPA.Dispose ();
				buttonSAxMTPA = null;
			}

			if (buttonSAxMDA != null) {
				buttonSAxMDA.Dispose ();
				buttonSAxMDA = null;
			}

			if (buttonSAxMCIA != null) {
				buttonSAxMCIA.Dispose ();
				buttonSAxMCIA = null;
			}

			if (buttonSAxMCOA != null) {
				buttonSAxMCOA.Dispose ();
				buttonSAxMCOA = null;
			}

			if (buttonSAxMUR != null) {
				buttonSAxMUR.Dispose ();
				buttonSAxMUR = null;
			}
		}
	}
}
