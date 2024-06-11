<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="zad1.aspx.cs" Inherits="IT_2024.zad1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row mt-3">
        <asp:ListBox ID="Destinations" runat="server" SelectionMode="Multiple">
            <asp:ListItem Value="200">Битола</asp:ListItem>
            <asp:ListItem Value="90">Велес</asp:ListItem>
            <asp:ListItem Value="190">Охрид</asp:ListItem>
            <asp:ListItem Value="220">Ресен</asp:ListItem>
        </asp:ListBox>

    </div>

     <div class="row mt-3">
         <asp:Button ID="SumbitDestination" runat="server" Text="Зачувај!" OnClick="SumbitDestinationClick" />
    </div>

     <div class="row mt-3">
         <asp:Label ID="SelectedDestinationLabel" runat="server" Text=""></asp:Label>
    </div>

</asp:Content>
