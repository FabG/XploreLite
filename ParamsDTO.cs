using System;
using Xplore.Framework.Common.DataProvider.DTO;

namespace Xplore_Lite
{
	public class ParamsDTO
	{
		public void CreateParamsDTO (GetDataParamsDTO paramsDto, string filterDate)
		{
			//DateTime format should look like: "Days~08/06/2012~08/06/2012"
			Console.WriteLine("ParamsDTO to create with Date:{0}", filterDate);

			// Pod accessed: http://saxm.comscore.com > Data Services Analysis Dashboard > Data Services Consumption
			
			// Context Info Parameter
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
			var filter4 = new FilterDTO() {Name ="GLOBAL_DATE_Date", Value=filterDate};
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

			//return ParamsDTO;
		}
	}
}

