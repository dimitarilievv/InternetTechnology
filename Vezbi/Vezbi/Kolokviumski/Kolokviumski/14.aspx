<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="14.aspx.cs" Inherits="Kolokviumski._14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox ID="tbIndex" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Zadolzitelno pole!" ControlToValidate="tbIndex"></asp:RequiredFieldValidator>
    <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Nevaliden vlez za index" ControlToValidate="tbIndex" MinimumValue="0" MaximumValue="1000"></asp:RangeValidator>

    <asp:Button ID="DeleteItem" runat="server" Text="Izbrisi" OnClick="DeleteItem_Click"  />
    <asp:ListBox ID="lbTitle" runat="server" AutoPostBack="True">
        <asp:ListItem>Modern Operating</asp:ListItem>
        <asp:ListItem>Advanced</asp:ListItem>
        <asp:ListItem>LALALA</asp:ListItem>
    </asp:ListBox>
    <asp:ListBox ID="lbPrice" runat="server">
        <asp:ListItem>45</asp:ListItem>
        <asp:ListItem>50</asp:ListItem>
        <asp:ListItem>70</asp:ListItem>
    </asp:ListBox>
</asp:Content>
