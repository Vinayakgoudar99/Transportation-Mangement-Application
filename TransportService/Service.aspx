<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Service.aspx.cs" Inherits="TransportService.Service" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <div class="container">
        <div>
            <h2>Services</h2>
        </div>
        <div class="align-content-center">
            <p>
                Employee Id: <asp:TextBox ID="txtEmpId" runat="server" CssClass="form-control"></asp:TextBox>  
            </p>
            <p>
                Route: <asp:DropDownList CssClass="form-control" runat="server" id="dpRoute" Width="121px" AutoPostBack="True" OnSelectedIndexChanged="dpRoute_SelectedIndexChanged"></asp:DropDownList>
            </p>
            <p>
                From:  <asp:DropDownList CssClass="form-control" runat="server" id="dpStart" Width="121px" AutoPostBack="True" OnSelectedIndexChanged="dpStart_SelectedIndexChanged" ></asp:DropDownList>
                To :  <asp:DropDownList runat="server" id="dpEnd" Width="136px" OnSelectedIndexChanged="dpEnd_SelectedIndexChanged" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
            </p>
            <p>
                <asp:button text="Submit" runat="server" CssClass="btn btn-primary" OnClick="Unnamed2_Click" />
            </p>
            <p>
               Bill Amount: <asp:TextBox id="txtAmount" Enabled="false" runat="server" CssClass="form-control"></asp:TextBox>
            </p>
        </div>
    </div>
</asp:Content>

