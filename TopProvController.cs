// This file has been autogenerated from parsing an Objective-C header file added in Xcode.

using System;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Steema.TeeChart;

namespace Xplore_Lite
{
	public partial class TopProvController : UIViewController
	{
		// Creating a sample Line chart 
		// With random points
		public TChart chart1 = new Steema.TeeChart.TChart();
		
		System.Drawing.RectangleF r1;
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			chart1.Frame = TPRUIView.Frame;
			this.View.AddSubview(chart1);
			
			// Bar series
			Steema.TeeChart.Styles.Line line1 = new Steema.TeeChart.Styles.Line();  
			chart1.Series.Add(line1);
			chart1.Aspect.View3D = true;
			
			// Header
			chart1.Header.Visible = true; 
			chart1.Header.Text = "Top Provider"; 
			chart1.Header.Alignment = MonoTouch.CoreText.CTTextAlignment.Left; 
			chart1.Header.Shadow.Visible = true;
			chart1.Header.Font.Size=20; 
			
			// Formating Legend
			chart1.Legend.Visible = true; 
			chart1.Legend.Shadow.Visible=false;
			chart1.Legend.Gradient.Visible=false; 
			chart1.Legend.Transparency = 50; 
			chart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom; 
			chart1.Legend.Font.Color = UIColor.Black.CGColor; 
			
			// Random serie
			chart1.Series[0].FillSampleValues(50); 
			chart1.Panel.MarginTop = 10; 
			
		}
		
		public override void DidRotate(UIInterfaceOrientation fromInterfaceOrientation) 
		{
			// Refresh Chart rotating the device
			r1 = new System.Drawing.RectangleF(0,0,this.View.Bounds.Width/2,this.View.Bounds.Height/2);						
			chart1.Frame = r1;
			
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations			
			return true;
		}
		
		public TopProvController (IntPtr handle) : base (handle)
		{
		}
	}
}


