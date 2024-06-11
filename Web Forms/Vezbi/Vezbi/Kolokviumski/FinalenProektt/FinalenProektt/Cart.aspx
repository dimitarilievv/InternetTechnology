<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="FinalenProektt.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h2>Cart</h2>
<asp:ListBox ID="cart1" runat="server" AutoPostBack="True"></asp:ListBox><br />
    <asp:Button ID="Delete" runat="server" Text="Delete" OnClick="Delete_Click" /><br />
    Total price:<asp:Label ID="total" runat="server" Text=""></asp:Label><br />

    <asp:Button ID="back" runat="server" Text="Back" OnClick="back_Click" />
</asp:Content>
