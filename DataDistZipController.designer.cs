// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace Xplore_Lite
{
	[Register ("DataDistZipController")]
	partial class DataDistZipController
	{
		[Outlet]
		MonoTouch.MapKit.MKMapView DDZMapView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (DDZMapView != null) {
				DDZMapView.Dispose ();
				DDZMapView = null;
			}
		}
	}
}
