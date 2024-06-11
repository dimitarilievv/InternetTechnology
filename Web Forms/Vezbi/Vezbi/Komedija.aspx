<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Komedija.aspx.cs" Inherits="Vezbi.Komedija" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="mt-3">
        <h3>Komedija</h3>
    </div>
    <div class="mt-3">
         FILM 
         <asp:ListBox ID="Filmovi" runat="server" Height="214px" Width="219px" AutoPostBack="True" OnSelectedIndexChanged="Filmovi_SelectedIndexChanged"></asp:ListBox>
         CENA 
         <asp:ListBox ID="Ceni" runat="server" Height="213px" Width="157px" AutoPostBack="True"></asp:ListBox>
    </div>
    <br />
    <div class="mt-3">
        <asp:Label ID="Vkupno" runat="server" Text=""></asp:Label>
         <br />
        <asp:Button ID="Dodadi" runat="server" Text="Dodadi vo kosnicka" OnClick="Dodadi_Click" />
    </div>
    <hr />
    <div class="mt-3">
        Kosnica <br />
        <asp:ListBox ID="Kosnica" runat="server" Height="167px" OnSelectedIndexChanged="Kosnica_SelectedIndexChanged" Width="284px"></asp:ListBox>
    </div>
</asp:Content>
