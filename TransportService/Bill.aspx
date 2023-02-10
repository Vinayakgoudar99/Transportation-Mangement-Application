<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Bill.aspx.cs" Inherits="TransportService.Bill" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <div class="container">
        <div class="row">
            <h2>Generated Bill</h2>
            <hr />
        </div >
        <div class="row">
            Total Bill Generated:  <asp:TextBox Enabled="false" ID="txtTotalbill" runat="server" Width="105px"></asp:TextBox>
        </div>
    </div>
</asp:Content>

