<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Filmovi.aspx.cs" Inherits="Fiilmovi_zadaca.Filmovi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<asp:Label ID="Kategorija" runat="server" Text=""></asp:Label>
    <br />
    <asp:ListBox ID="Naslovi" runat="server" OnSelectedIndexChanged="Naslovi_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>
    <asp:ListBox ID="Ceni" runat="server" AutoPostBack="True"></asp:ListBox>
    <hr />
    Total:
    <asp:Label ID="Total" runat="server" Text=""></asp:Label>
    <asp:Button ID="VratiSe" runat="server" Text="Vrati se nazad" OnClick="VratiSe_Click" />
    <hr />
    <asp:Button ID="Dodadi" runat="server" Text="Dodadi" OnClick="Dodadi_Click" />
    <div>
        <asp:ListBox ID="Kosnicka" runat="server" AutoPostBack="True" Height="140px" Width="313px"></asp:ListBox>
    </div>
    <asp:Button ID="PlatiButton" runat="server" Text="Plati" OnClick="PlatiButton_Click" />
</asp:Content>
