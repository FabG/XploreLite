using MonoTouch.UIKit;
using System.Drawing;
using System;
using MonoTouch.Foundation;

namespace Xplore_Lite
{
	public partial class FlipsideViewController : UIViewController
	{

		UIImageView _saxImageView;

		public FlipsideViewController (IntPtr handle) : base (handle)
		{
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		#region View lifecycle
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Any additional setup after loading the view, typically from a nib.
			_saxImageView = new UIImageView(UIImage.FromBundle("Images/SAxC_238x31.png"));
			_saxImageView.Frame = new Rectangle (14,50,_saxImageView.Image.CGImage.Width, _saxImageView.Image.CGImage.Height);     
			View.AddSubview (_saxImageView);

		}
		
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			
			// Release any retained subviews of the main view.
		}
		
		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}
		
		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}
		
		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}
		
		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}
		
		#endregion
		
		partial void done (UIBarButtonItem sender)
		{
			this.DismissModalViewControllerAnimated (true);
			
			if (Done != null)
				Done (this, EventArgs.Empty);
		}
		
		public event EventHandler Done;
	}
}
