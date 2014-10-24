<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TotalItemSalesByMenuCategoryReport.aspx.cs" Inherits="DemoPages_TotalItemSalesByMenuCategoryReport" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <rsweb:ReportViewer ID="TotalSalesVeiwer" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="878px">
        <LocalReport ReportPath="Reports\TotalItemSalesByMenuCategory.rdlc">
            <DataSources>
                <rsweb:ReportDataSource DataSourceId="ODSTotalItemSales" Name="ItemSalesDS" />
            </DataSources>
        </LocalReport>
    </rsweb:ReportViewer>
<asp:ObjectDataSource ID="ODSTotalItemSales" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetReportTotalItemSalesByMenuCategory" TypeName="eRestaurantSystem.BLL.eRestaurantController" OnSelecting="ObjectDataSource1_Selecting"></asp:ObjectDataSource>
</asp:Content>

