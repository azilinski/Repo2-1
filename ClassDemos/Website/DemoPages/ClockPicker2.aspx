<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClockPicker2.aspx.cs" Inherits="DemoPages_ClockPicker2" %>
<%@ Register src="../UserControls/MessageUserControl.ascx" tagname="MessageUserControl" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="well">
        <div class="pull-right col-md-5"> 
            <h4>
                <small>Last Billed Date/time:</small>
                <asp:Repeater ID="BillDateRepeater" runat="server" DataSourceID="ODSRepeater" ItemType="System.DateTime">
                    <ItemTemplate>
                        <b class="label label-primary">
                            <%# Item.ToShortDateString() %>
                        </b>
                        <b class="label label-info">
                            <%# Item.ToShortTimeString() %>
                        </b>
                    </ItemTemplate>
                </asp:Repeater>
                <asp:ObjectDataSource ID="ODSRepeater" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetLastBillDateTime" TypeName="eRestaurantSystem.BLL.eRestaurantController"></asp:ObjectDataSource>
            </h4>

                <div class="col-md-7">
        <details open>
            <summary>Tables</summary>
            <asp:GridView ID="SeatingGridView" runat="server" AutoGenerateColumns="False"
                DataSourceID="SeatingObjectDataSource" ItemType="eRestaurant.Entities.DTOs.SeatingSummary">
                <Columns>
                    <asp:BoundField DataField="Table" HeaderText="Table" SortExpression="Table"></asp:BoundField>
                    <asp:BoundField DataField="Seating" HeaderText="Seating" SortExpression="Seating"></asp:BoundField>
                    <asp:CheckBoxField DataField="Taken" HeaderText="Taken" SortExpression="Taken" ItemStyle-HorizontalAlign="Center"></asp:CheckBoxField>
                    <asp:BoundField DataField="BillID" HeaderText="BillID" SortExpression="BillID"></asp:BoundField>
                    <asp:BoundField DataField="BillTotal" HeaderText="BillTotal" SortExpression="BillTotal"></asp:BoundField>
                    <asp:BoundField DataField="Waiter" HeaderText="Waiter" SortExpression="Waiter"></asp:BoundField>
                    <asp:BoundField DataField="ReservationName" HeaderText="ReservationName" SortExpression="ReservationName"></asp:BoundField>
                </Columns>
            </asp:GridView>
        </details>
    </div>
    <asp:ObjectDataSource runat="server" ID="SeatingObjectDataSource" OldValuesParameterFormatString="original_{0}"
        SelectMethod="SeatingByDateTime" TypeName="eRestaurant.BLL.SeatingController">
        <SelectParameters>
            <asp:ControlParameter ControlID="SearchDate" PropertyName="Text" Name="date" Type="DateTime"></asp:ControlParameter>
            <asp:ControlParameter ControlID="SearchTime" PropertyName="Text" DbType="Time" Name="time"></asp:ControlParameter>
        </SelectParameters>
    </asp:ObjectDataSource>

        </div>     
            <h4>Mock Date/Time</h4>
                <asp:LinkButton ID="MockDateTime" runat="server" 
                    CssClass="btn btn-primary">Post-back new date/time</asp:LinkButton>
        &nbsp;&nbsp;
                <asp:LinkButton ID="MockLastBillingDateTime" runat="server" 
                    CssClass="btn btn-default" OnClick="MockLastBillingDateTime_Click">set to Last-Bill date/time:</asp:LinkButton>
        &nbsp;&nbsp;
        <asp:TextBox ID="SearchDate" runat="server" TextMode="Date" Text="2014-10-27"></asp:TextBox>
        <asp:TextBox ID="SearchTime" runat="server" TextMode="Time" Text="15:00" CssClass="clockpicker"></asp:TextBox>
        <%--add clock picker--%>
    <script src="../Scripts/clockpicker.js"></script>
        <script type="text/javascript">
            $('.clockpicker').clockpicker({ donetext: 'Accept' });
        </script>
        <link itemprop="url" href="../Content/standalone.css" rel="stylesheet"/>
        <link itemprop="url" href="../Content/clockpicker.css" rel="stylesheet" />
    </div>    
       <uc1:MessageUserControl ID="MessageUserControl" runat="server" />

</asp:Content>

