<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="AddRoutes.aspx.cs" Inherits="TransportService.AddRoutes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <div class="container">
        <div>
            <h2>Register Routes</h2>
            <hr />
        </div>
        <div>
           <%-- <div>
              Route: <asp:TextBox runat="server" ID="txtRoute" CssClass="form-control" Height="26px" OnTextChanged="txtRoute_TextChanged" Width="220px"></asp:TextBox>
             </div>--%>
            Route :<asp:TextBox ID="txtRoute" runat="server" CssClass="form-control"></asp:TextBox>
            <div>
                No Of Pickup Stops: <asp:TextBox runat="server"  ID="txtNoOfStops" CssClass="form-control"/>
            </div>
            <div>
                Amount: <asp:TextBox runat="server"  ID="txtAmount" CssClass="form-control"/>
            </div>
            <div>
                <asp:Button text="Add Route" ID="btnRoute" runat="server"  CssClass="btn btn-success" OnClick="btnRoute_Click"/>
             </div>
        <div>
            </div>
        <hr />
        <div>
            <h2>Register Pickup Stops</h2>
        </div>
        <hr />
        <div>
            <p>
              Route : <asp:DropDownList ID="dpRoutes" runat="server" Width="142px" AutoPostBack="True" OnSelectedIndexChanged="dpRoutes_SelectedIndexChanged"></asp:DropDownList>
            </p>
            <p>
              Pickup No :<asp:TextBox runat="server"  ID="txtNo" CssClass="form-control"/>
            </p>
            <p>
                PickupPoints Name: <asp:TextBox runat="server"  ID="txtPickupPoint" CssClass="form-control"/>
            </p>

            <p>
                <asp:Button Text="Add PickupPoint" runat="server" CssClass="btn btn-success" OnClick="Unnamed1_Click" />
            </p>
        </div>
    </div>
</asp:Content>

