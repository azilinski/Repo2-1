<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="XMLPracticePage.aspx.cs" Inherits="xml_Files_XMLPracticePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" DataSourceID="XmlDataSource1"></asp:GridView>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/xml Files/XMLPractice.xml" TransformFile="~/xml Files/XSLTPractice.xslt"></asp:XmlDataSource>
</asp:Content>

