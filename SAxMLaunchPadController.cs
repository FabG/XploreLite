// This file has been autogenerated from parsing an Objective-C header file added in Xcode.

using System;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Xplore_Lite
{
	public partial class SAxMLaunchPadController : UIViewController
	{
		public SAxMLaunchPadController (IntPtr handle) : base (handle)
		{
		}

		partial void clicked (MonoTouch.Foundation.NSObject sender)
		{
			DismissModalViewControllerAnimated(true);
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			//Assign images to buttons
			buttonSAxMDSA.SetImage(UIImage.FromFile ("Images/SAxM_Launch_Pad_DSA_150x150.png"), UIControlState.Normal);
			buttonSAxMTPA.SetImage(UIImage.FromFile ("Images/SAxM_Launch_Pad_TPA_150x150.png"), UIControlState.Normal);
			buttonSAxMDA.SetImage(UIImage.FromFile ("Images/SAxM_Launch_Pad_DA_150x150.png"), UIControlState.Normal);
			buttonSAxMCIA.SetImage(UIImage.FromFile ("Images/SAxM_Launch_Pad_CIA_150x150.png"), UIControlState.Normal);
			buttonSAxMCOA.SetImage(UIImage.FromFile ("Images/SAxM_Launch_Pad_COA_150x150.png"), UIControlState.Normal);
			buttonSAxMUR.SetImage(UIImage.FromFile ("Images/SAxM_Launch_Pad_UR_150x150.png"), UIControlState.Normal);
			
		}
	}
}
