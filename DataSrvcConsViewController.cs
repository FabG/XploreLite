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

		// TChart
		public TChart chart_DSC = new Steema.TeeChart.TChart();

		System.Drawing.RectangleF r1;

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

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
			chart_DSC.Frame = DSCUIView.Frame;
			this.View.AddSubview(chart_DSC);

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
			
			// Static series
			pie_DSC.Add(44,"Browsing",UIColor.Blue.CGColor);  
			pie_DSC.Add(24,"Streaming",UIColor.Red.CGColor);  
			pie_DSC.Add(16,"Dwnld/Upld/Game",UIColor.Green.CGColor);  
			pie_DSC.Add(6,"Comm/Msg",UIColor.Yellow.CGColor);

			// Data series coming from xomScore SAxM demo website
			// WSDL Service used: http://saxm.comscore.com/DataProviderService.svc?wsdl
			// Proxy created with Silver light: AppDelegate.cs

			// Pod accessed: http://saxm.comscore.com > Data Services Analysis Dashboard > Data Services Consumption

			// Lists to handle the Series name/data points coming from the webservice
			List<String> metadataColListName;
			List<String> metadataColListId;
			List<String> metadataRowListName;
			List<String> metadataRowListValue;
			int i = 0;

			// Context Info Parameter
			var paramsDto =new Xplore.Framework.Common.DataProvider.DTO.GetDataParamsDTO();
			paramsDto.ContextInfo = new string[7];
			paramsDto.ContextInfo[0] = "dashboardID=100001";
			paramsDto.ContextInfo[1] = "podID=0" ;
			paramsDto.ContextInfo[2] = "podModeID=0";
			paramsDto.ContextInfo[3] = "UserId=fguillaume";
			paramsDto.ContextInfo[4] = "versionID=332";
			paramsDto.ContextInfo[5] = "DASH_POD_TYPE=Pod";
			paramsDto.ContextInfo[6] = "podType=SQLPod";

			// Exception Mode Parameter
			paramsDto.ExceptionMode = ExceptionMode.None;

			// Force Data Refresh Parameter
			paramsDto.ForceDataRefresh = false;

			// Page Info Parameter
			var pagingDto = new PagingDTO();
			pagingDto.PageSize = 25;
			pagingDto.RequiredPage = 1;
			paramsDto.PageInfo = pagingDto;

			// Post Exec Filter Parameter
			paramsDto.PostExecFilter = new FilterDTO[0];

			// Pre Exec Filter Parameter
			paramsDto.PreExecFilter = new Xplore.Framework.Common.DataProvider.DTO.FilterDTO[30];

			// Asociate all local filters
			//var filter1 = new FilterDTO() {Name = "GLOBAL_TEXTINPUT_Customer_MDN", Value = this.mdnTextbox.Text};//"0072dcfbe72043bbd0879457c4fc7fbf~0072dcfbe72043bbd0879457c4fc7fbf"};
			//var filter2 = new FilterDTO() {Name = "GLOBAL_DATE_Date", Value = "Days~08/01/2012~08/30/2012"};
			//var filter3 = new FilterDTO() {Name ="POD_TRUNCATE_ROW_LIMIT", Value="500"};
			var filter1 = new FilterDTO() {Name ="TREE_LEVEL_LOCAL_TREE_DataServicesHierarchy", Value="1"};
			var filter2 = new FilterDTO() {Name ="LOCAL_TREE_DataServicesHierarchy", Value="CIMXM_DATA_SERVICES_HIERARCHY~ROOT"};
			var filter3 = new FilterDTO() {Name ="GLOBAL_DROPDOWN_Indicators", Value="Avg Data Volume per Session (MB)"};
			var filter4 = new FilterDTO() {Name ="GLOBAL_DATE_Date", Value="Days~08/06/2012~08/06/2012"};
			var filter5 = new FilterDTO() {Name ="DROPDOWN_CustomerType_ALL_ITEMS", Value="true"};
			var filter6 = new FilterDTO() {Name ="GLOBAL_DROPDOWN_CustomerType", Value="EM~LC~NA~RS~Unknown"};
			var filter7 = new FilterDTO() {Name ="DROPDOWN_BillingType_ALL_ITEMS", Value="true"};
			var filter8 = new FilterDTO() {Name ="GLOBAL_DROPDOWN_BillingType", Value="POS~PRE~Unknown"};
			var filter9 = new FilterDTO() {Name ="DROPDOWN_SegmentType_ALL_ITEMS", Value="true"};
			var filter10 = new FilterDTO() {Name ="GLOBAL_DROPDOWN_SegmentType", Value="GGCC~MICROPYME~PYME~SOHO~TOP_SME~"};
			var filter11 = new FilterDTO() {Name ="DROPDOWN_CustomerOption_ALL_ITEMS", Value="true"};
			var filter12 = new FilterDTO() {Name ="GLOBAL_DROPDOWN_CustomerOption", Value="0~1"};
			var filter13 = new FilterDTO() {Name ="DROPDOWN_Gender_ALL_ITEMS", Value="true"};
			var filter14 = new FilterDTO() {Name ="GLOBAL_DROPDOWN_Gender", Value="Male~Female~Other"};
			var filter15 = new FilterDTO() {Name ="DROPDOWN_Age_ALL_ITEMS", Value="true"};
			var filter16 = new FilterDTO() {Name ="GLOBAL_DROPDOWN_Age", Value="(dsub.age BETWEEN 0 AND 17)~(dsub.age BETWEEN 18 AND 24)~(dsub.age BETWEEN 25 AND 34)~(dsub.age BETWEEN 35 AND 54)~(dsub.age &gt;= 55)~(dsub.age = -1)"};
			var filter17 = new FilterDTO() {Name ="TREE_LEVEL_GLOBAL_TREE_TariffPlan", Value="1"};
			var filter18 = new FilterDTO() {Name ="GLOBAL_TREE_TariffPlan", Value="CIMXM_TARIFF_TREE_ID~ROOT"};
			var filter19 = new FilterDTO() {Name ="TREE_LEVEL_GLOBAL_TREE_Options", Value="1"};
			var filter20 = new FilterDTO() {Name ="GLOBAL_TREE_Options", Value="CIMXM_OPTIONS_TREE_ID~ROOT"};
			var filter21 = new FilterDTO() {Name ="TREE_LEVEL_GLOBAL_TREE_Device", Value="1"};
			var filter22 = new FilterDTO() {Name ="GLOBAL_TREE_Device", Value="CIMXM_DEVICE_TREE_ID~ROOT"};
			var filter23 = new FilterDTO() {Name ="TREE_LEVEL_GLOBAL_TREE_OS", Value="1"};
			var filter24 = new FilterDTO() {Name ="GLOBAL_TREE_OS", Value="CIMXM_OS_TREE_ID~ROOT"};
			var filter25 = new FilterDTO() {Name ="TREE_LEVEL_GLOBAL_TREE_Location", Value="1"};
			var filter26 = new FilterDTO() {Name ="GLOBAL_TREE_Location", Value="CIMXM_LOCATION_TREE_ID~ROOT"};
			var filter27 = new FilterDTO() {Name ="DROPDOWN_Roaming_ALL_ITEMS", Value="true"};
			var filter28 = new FilterDTO() {Name ="GLOBAL_DROPDOWN_Roaming", Value="2~1~-1"};
			var filter29 = new FilterDTO() {Name ="DROPDOWN_NetworkType_ALL_ITEMS", Value="true"};
			var filter30 = new FilterDTO() {Name ="GLOBAL_DROPDOWN_NetworkType", Value="2~1~3~-1"};

			paramsDto.PreExecFilter[0]=filter1;
			paramsDto.PreExecFilter[1]=filter2;
			paramsDto.PreExecFilter[2]=filter3;
			paramsDto.PreExecFilter[3]=filter4;
			paramsDto.PreExecFilter[4]=filter5;
			paramsDto.PreExecFilter[5]=filter6;
			paramsDto.PreExecFilter[6]=filter7;
			paramsDto.PreExecFilter[7]=filter8;
			paramsDto.PreExecFilter[8]=filter9;
			paramsDto.PreExecFilter[9]=filter10;
			paramsDto.PreExecFilter[10]=filter11;
			paramsDto.PreExecFilter[11]=filter12;
			paramsDto.PreExecFilter[12]=filter13;
			paramsDto.PreExecFilter[13]=filter14;
			paramsDto.PreExecFilter[14]=filter15;
			paramsDto.PreExecFilter[15]=filter16;
			paramsDto.PreExecFilter[16]=filter17;
			paramsDto.PreExecFilter[17]=filter18;
			paramsDto.PreExecFilter[18]=filter19;
			paramsDto.PreExecFilter[19]=filter20;
			paramsDto.PreExecFilter[20]=filter21;
			paramsDto.PreExecFilter[21]=filter22;
			paramsDto.PreExecFilter[22]=filter23;
			paramsDto.PreExecFilter[23]=filter24;
			paramsDto.PreExecFilter[24]=filter25;
			paramsDto.PreExecFilter[25]=filter26;
			paramsDto.PreExecFilter[26]=filter27;
			paramsDto.PreExecFilter[27]=filter28;
			paramsDto.PreExecFilter[28]=filter29;
			paramsDto.PreExecFilter[29]=filter30;

			// Request ID Parameter
			paramsDto.RequestId = "1355922890930";

			// Sort Info
			paramsDto.SortInfo = new SortDTO[0];

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
						metadataColListName = new List<String>();
						metadataColListId = new List<String>();

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

						foreach (string column in metadataColListName)
						{
							Console.WriteLine(" - metadataColList[{0}]: Name={1} | Id={2}", i, 
							                  metadataColListName[i], metadataColListId[i]);
							i++;
						}



						// ********* XML Data ********
						// Get the Data properties for Series Names and Points
						System.Collections.Generic.IEnumerable<XElement> xmlDataSerie = 
							xElementFromStream.Descendants("Data").Descendants("row");;
						metadataRowListName = new List<String>();
						metadataRowListValue = new List<String>();
						
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

						//Pass Serie Names and values to chart

					} 



				}


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
