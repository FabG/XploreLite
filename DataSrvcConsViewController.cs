// This file has been autogenerated from parsing an Objective-C header file added in Xcode.

using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Steema.TeeChart;
using Xplore.Framework.Common.DataProvider.DTO;
using System.ServiceModel;
using System.IO;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Xml;

namespace Xplore_Lite
{
	public partial class DataSrvcConsViewController : UIViewController
	{
		private static readonly DataProviderServiceClient dataProviderClient = GetClient();

		// Lists to handle the Series name/data points coming from the webservice
		List<String> metadataColListName = new List<String>();
		List<String> metadataColListId = new List<String>();
		List<String> metadataRowListName = new List<String>();
		List<String> metadataRowListValue = new List<String>();
		int i = 0;
		LoadingOverlay loadingOverlay;
		ActionSheetDatePicker actionSheetDatePicker;
		string[] datePickerResult;
		string filterGlobalDate;

		// TChart
		public TChart chart_DSC = new Steema.TeeChart.TChart();


		System.Drawing.RectangleF r1;

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			loadingOverlay = new LoadingOverlay (UIScreen.MainScreen.Bounds);
			View.Add (loadingOverlay);

			chart_DSC.Frame = DSCUIView.Frame;
			//this.View.AddSubview(chart_DSC);
			Steema.TeeChart.Styles.Pie pie_DSC = new Steema.TeeChart.Styles.Pie(); 
			
			chart_DSC.Series.Add(pie_DSC);
			chart_DSC.Aspect.View3D = true;
			
			// Header
			chart_DSC.Header.Text = "Data Services Consumption";
			chart_DSC.Header.Visible = false;
			chart_DSC.Header.Alignment = MonoTouch.CoreText.CTTextAlignment.Center;
			chart_DSC.Header.Shadow.Visible = true;
			
			// Formating Legend
			chart_DSC.Legend.Alignment = LegendAlignments.Bottom;
			chart_DSC.Legend.Shadow.Visible=false;
			chart_DSC.Legend.Transparency = 50; 

			// ************** ORIGINAL CODE WITH STATIC BAR CHART *************************
			//chart1.Frame = DSCUIView.Frame;
			//this.View.AddSubview(chart1);

			// Bar series
			//Steema.TeeChart.Styles.Bar bar1 = new Steema.TeeChart.Styles.Bar(); 
			//chart1.Series.Add(bar1);
			//chart1.Aspect.View3D = true;

			// Header
			//chart1.Header.Visible = false;

			// Formating Legend
			//chart1.Legend.Alignment = LegendAlignments.Bottom;
			//chart1.Legend.Shadow.Visible=false;
			//chart1.Legend.Transparency = 50; 

			// Static series
			//bar1.Add(44,"Browsing",UIColor.Blue.CGColor);  
			//bar1.Add(24,"Streaming",UIColor.Red.CGColor);  
			//bar1.Add(16,"Download / Upload / Gaming",UIColor.Green.CGColor);  
			//bar1.Add(6,"Communication / Messaging",UIColor.Yellow.CGColor);  

			// ************** NEW CODE WITH DYNAMIC PIE CHART (WEBSERVICE) *************************



			// Data series coming from xomScore SAxM demo website
			// WSDL Service used: http://saxm.comscore.com/DataProviderService.svc?wsdl
			// Proxy created with Silver light: AppDelegate.cs

			// Pod accessed: http://saxm.comscore.com > Data Services Analysis Dashboard > Data Services Consumption
			var paramsDto = ParamsDTO.CreateParamsDTO("DSC", "Days~08/06/2012~08/06/2012");

			// Fill Request
			dataProviderClient.GetDataAsync("DASH_SQL_EXEC", paramsDto);

			// Pass callback when asynchronous call is done
			// Response has 3 fields as part of the GetDataResult tag: Code, Description and ResultObject
			// for this POC, Code = "GEN-0000", Description is null
			// and ResultObject is filled with an XML string
			dataProviderClient.GetDataCompleted += (object sender2, GetDataCompletedEventArgs ev) => {
				if (ev.Result.Code == "GEN-0000")
				{

					Console.WriteLine("Response received");

					string xmlresultObject = ev.Result.ResultObject.ToString();
					// Console.WriteLine("xmlresultObject = {0}", xmlresultObject);
					//xmlresultObject=
					/*<GetData><MetaData>
						<Columns>
							<col id="No" name="No" type="number" />
							<col id="Network_id" name="Network_id" type="number" />
							<col id="service_x0020_group" name="service group" type="string" />
							<col id="Avg_x0020_Data_x0020_Volume_x0020_per_x0020_Session_x0020__x0028_MB_x0029_" name="Avg Data Volume per Session (MB)" type="number" />
							<col id="ROWID" name="ROWID" type="string" />
						</Columns>
						<Pagination actualPage="1" totalRowCount="6" totalPages="1" pageSize="25" />
						<AdditionalProperties><AdditionalProperty name="ROWNUM_COLID" value="No" />
						</AdditionalProperties>
						</MetaData>
						<Data><row No="1" Network_id="6" service_x0020_group="Communication / Messaging" Avg_x0020_Data_x0020_Volume_x0020_per_x0020_Session_x0020__x0028_MB_x0029_="0.01" ROWID="-979132663" /><row No="2" Network_id="5" service_x0020_group="Download / Upload / Gaming" Avg_x0020_Data_x0020_Volume_x0020_per_x0020_Session_x0020__x0028_MB_x0029_="0.47" ROWID="-876054502" /><row No="3" Network_id="4" service_x0020_group="Browsing" Avg_x0020_Data_x0020_Volume_x0020_per_x0020_Session_x0020__x0028_MB_x0029_="0.13" ROWID="-788535925" /><row No="4" Network_id="3" service_x0020_group="Streaming" Avg_x0020_Data_x0020_Volume_x0020_per_x0020_Session_x0020__x0028_MB_x0029_="1.98" ROWID="1697245990" /><row No="5" Network_id="2" service_x0020_group="Mail" Avg_x0020_Data_x0020_Volume_x0020_per_x0020_Session_x0020__x0028_MB_x0029_="0.08" ROWID="-867832989" /><row No="6" Network_id="1" service_x0020_group="Others" Avg_x0020_Data_x0020_Volume_x0020_per_x0020_Session_x0020__x0028_MB_x0029_="0.01" ROWID="1497011326" />
						</Data>
					  </GetData>
							*/

					// FirstNode is <MetaData>
					// Console.WriteLine("xmlFromMemStream.FirstNode:{0}",xElementFromStream.FirstNode);
					/* xElementFromStream.FirstNode = 
					  <MetaData>
						  <Columns>
						    <col id="No" name="No" type="number" />
						    <col id="Network_id" name="Network_id" type="number" />
						    <col id="service_x0020_group" name="service group" type="string" />
						    <col id="Avg_x0020_Data_x0020_Volume_x0020_per_x0020_Session_x0020__x0028_MB_x0029_" name="Avg Data Volume per Session (MB)" type="number" />
						    <col id="ROWID" name="ROWID" type="string" />
						  </Columns>
						  <Pagination actualPage="1" totalRowCount="6" totalPages="1" pageSize="25" />
						  <AdditionalProperties>
						    <AdditionalProperty name="ROWNUM_COLID" value="No" />
						  </AdditionalProperties>
					 </MetaData>
					 */
					
					// LastNode is <Data>
					// Console.WriteLine("xmlFromMemStream.LastNode:{0}",xElementFromStream.LastNode);
					/* xml.LastNode =
					 	<Data>
							<row No="1" Network_id="6" service_x0020_group="Communication / Messaging" Avg_x0020_Data_x0020_Volume_x0020_per_x0020_Session_x0020__x0028_MB_x0029_="0.01" ROWID="-979132663" />
							<row No="2" Network_id="5" service_x0020_group="Download / Upload / Gaming" Avg_x0020_Data_x0020_Volume_x0020_per_x0020_Session_x0020__x0028_MB_x0029_="0.47" ROWID="-876054502" />
							<row No="3" Network_id="4" service_x0020_group="Browsing" Avg_x0020_Data_x0020_Volume_x0020_per_x0020_Session_x0020__x0028_MB_x0029_="0.13" ROWID="-788535925" />
							<row No="4" Network_id="3" service_x0020_group="Streaming" Avg_x0020_Data_x0020_Volume_x0020_per_x0020_Session_x0020__x0028_MB_x0029_="1.98" ROWID="1697245990" />
							<row No="5" Network_id="2" service_x0020_group="Mail" Avg_x0020_Data_x0020_Volume_x0020_per_x0020_Session_x0020__x0028_MB_x0029_="0.08" ROWID="-867832989" />
							<row No="6" Network_id="1" service_x0020_group="Others" Avg_x0020_Data_x0020_Volume_x0020_per_x0020_Session_x0020__x0028_MB_x0029_="0.01" ROWID="1497011326" />
					 	<Data>
					*/

					var memStream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes (ev.Result.ResultObject.ToString()));

					// Read the XML from memstream with XElement from XLinq
					XElement xElementFromStream = XElement.Load(memStream);

					// Assign Metadata and Data children to 2 lists that will feed the Chart
					if (xElementFromStream != null) 
					{ 
						// ********* XML MetaData ********
						System.Collections.Generic.IEnumerable<XElement> xmlMetaDataSerie = 
							xElementFromStream.Descendants("MetaData").Descendants("col");;

						// Add the name tag content to a list to pass it to the chart
						foreach(XElement col in xmlMetaDataSerie) 
						{
							//Console.WriteLine("Metadata col :{0}", col.ToString());
							//Console.WriteLine("  - Metadata col id :{0}", col.Attribute("id").Value.ToString());
							//Console.WriteLine("  - Metadata col name :{0}", col.Attribute("name").Value.ToString());
							metadataColListName.Add(col.Attribute("name").Value.ToString());
							metadataColListId.Add(col.Attribute("id").Value.ToString());
						}
						Console.WriteLine("Total Metadata Columns: {0}", metadataColListName.Count);
						i=0;
						foreach (string column in metadataColListName)
						{
							Console.WriteLine(" - metadataColList[{0}]: Name={1} | Id={2}", i, 
							                  metadataColListName[i], metadataColListId[i]);
							i++;
						}


						// ********* XML Data ********
						System.Collections.Generic.IEnumerable<XElement> xmlDataSerie = 
							xElementFromStream.Descendants("Data").Descendants("row");;
						
						// Add the name tag content to a list to pass it to the chart
						foreach(XElement row in xmlDataSerie) 
						{
							//Console.WriteLine("Data row :{0}", row.ToString());
							metadataRowListName.Add(row.Attribute("service_x0020_group").Value.ToString());
							metadataRowListValue.Add(row.Attribute("Avg_x0020_Data_x0020_Volume_x0020_per_x0020_Session_x0020__x0028_MB_x0029_").Value.ToString());
						}
						
						Console.WriteLine("Total Data Rows: {0}", metadataRowListName.Count);
						i=0;
						foreach (string row in metadataRowListName)
						{
							Console.WriteLine(" - metadataRowList[{0}]: Name={1} | Value={2}", i, 
							                  metadataRowListName[i], metadataRowListValue[i]);

							i++;
						}

						// Update Pie chart from the main UI Thread
						// To do so, need to use  NSObject.InvokeOnMainThread
						//  as Access to UI elements should be limited to the same thread 
						// that is running the main loop
						InvokeOnMainThread (delegate {
							loadingOverlay.Hide ();
							View.AddSubview(chart_DSC);

							i=0;
							pie_DSC.Clear();
							foreach (string row in metadataRowListName)
							{
								Console.WriteLine("Callback Return");
								Console.WriteLine(" - metadataRowList[{0}]: Name={1} | Value={2}", i, 
								                  metadataRowListName[i], metadataRowListValue[i]);
								//Adding one y one series name and values - using randm colors (not specified in the call)
								pie_DSC.Add(Convert.ToDouble(metadataRowListValue[i]),metadataRowListName[i]);
								i++;
							}
							// Changing Fomat of the pie to %
							pie_DSC.Marks.Style = Steema.TeeChart.Styles.MarksStyles.Percent;
							//pie_DSC.Labels.TrimToSize();


						});
					}
				}

			}; // End call back

			// Filters
			DSCIndicButton.TouchUpInside += (sender, e) => {
				Console.WriteLine("Indicator Button clicked");
			};

			DSCDateButton.TouchUpInside += (sender, e) => {
				Console.WriteLine("Date Button clicked");

				actionSheetDatePicker = new ActionSheetDatePicker (this.View);
				actionSheetDatePicker.Show ();
				actionSheetDatePicker.Title = "Choose Date:";
				actionSheetDatePicker.DatePicker.Mode = UIDatePickerMode.Date;

				// Limit dates seclection to what we have on the demo platform
				//actionSheetDatePicker.DatePicker.MinimumDate = DateTime.Today.AddDays (-7);
				//actionSheetDatePicker.DatePicker.MaximumDate = DateTime.Today.AddDays (7);			
				actionSheetDatePicker.DatePicker.MinimumDate = DateTime.Parse("2012-08-06").AddDays(-14);
				actionSheetDatePicker.DatePicker.MaximumDate = DateTime.Parse("2012-08-06").AddDays (14);			

				actionSheetDatePicker.DatePicker.ValueChanged += (s2, e2) => {
					 
					DSCDateLabel.Text = (s2 as UIDatePicker).Date.ToString ();
					datePickerResult = new string[3];

					// Need to convert single day selection
					// from 2012-08-20 04:00:00 +0000 
					// to Days~08/06/2012~08/06/2012
					// Month
					datePickerResult[0] = (s2 as UIDatePicker).Date.ToString().Substring(5,2);
					// Day
					datePickerResult[1] = (s2 as UIDatePicker).Date.ToString().Substring(8,2);
					// Year
					datePickerResult[2] = (s2 as UIDatePicker).Date.ToString().Substring(0,4);
					Console.WriteLine("Date: {0}/{1}/{2}", datePickerResult[0], datePickerResult[1], datePickerResult[2]); 

					// Regenerate chart with new date
				};
			};

			DSCCustButton.TouchUpInside += (sender, e) => {
				Console.WriteLine("Customer Type Button clicked");
			};

			DSCAgeButton.TouchUpInside += (sender, e) => {
				Console.WriteLine("Age Button clicked");
			};
		}


		public override void DidRotate(UIInterfaceOrientation fromInterfaceOrientation) 
		{
			// Refresh Chart rotating the device
			r1 = new System.Drawing.RectangleF(0,0,this.View.Bounds.Width/2,this.View.Bounds.Height/2);						
			chart_DSC.Frame = r1;

		}

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations			
			return true;
		}

		public DataSrvcConsViewController (IntPtr handle) : base (handle)
		{
		}

		// DataProvider Client
		public static DataProviderServiceClient GetClient()
		{
			BasicHttpBinding binding = new BasicHttpBinding();
			var endpointAddress = new EndpointAddress("http://saxm.comscore.com/DataProviderService.svc");
			var client = new DataProviderServiceClient(binding, endpointAddress);
			return client;
		}
	}
}
