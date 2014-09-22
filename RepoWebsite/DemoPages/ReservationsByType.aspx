<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ReservationsByType.aspx.cs" Inherits="DemoPages_ReservationsByType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="Description" DataValueField="EventCode"></asp:DropDownList>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="SpecialEvent_List" TypeName="eResturauntSystem.BLL.eResturauntController"></asp:ObjectDataSource>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2" PageSize="25">
        <Columns>
            <asp:BoundField DataField="ReservationId" HeaderText="ID" ReadOnly="True" SortExpression="ReservationId">
            <HeaderStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="CustomerName" HeaderText="Customer Name" SortExpression="CustomerName" />
            <asp:BoundField DataField="ReservationDate" DataFormatString="{0:MMM dd, yyyy}" HeaderText="Reservation Date" SortExpression="ReservationDate">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:TemplateField AccessibleHeaderText="Number in Party">
                <ItemTemplate>
                    <asp:TextBox id="Test" runat="server" Text='<%# Eval("NumberInParty") %>'></asp:TextBox>
                </ItemTemplate>                
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Contact #">
                <ItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("ContactPhone") %>'></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="ReservationStatus" HeaderText="ReservationStatus" SortExpression="ReservationStatus" />
            <asp:BoundField DataField="EventCode" HeaderText="EventCode" SortExpression="EventCode" />

        </Columns>
        <PagerSettings FirstPageText="First" LastPageText="Last" Mode="NumericFirstLast" PageButtonCount="20" />
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Reservation_List" TypeName="eResturauntSystem.BLL.eResturauntController"></asp:ObjectDataSource>
</asp:Content>

