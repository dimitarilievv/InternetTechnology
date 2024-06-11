<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Kategorii.aspx.cs" Inherits="Fiilmovi_zadaca.Kategorii" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="mt-3">
        <h1>Kategorii</h1>
    </div>
    <div class="mt-3">
        <asp:LinkButton ID="Komedija" runat="server" OnClick="Komedija_Click">Komedija</asp:LinkButton>
    </div>
    <div class="mt-3">
        <asp:LinkButton ID="Akcija" runat="server" OnClick="Akcija_Click">Akcija</asp:LinkButton>
    </div>
    <div class="mt-3">
        <asp:LinkButton ID="NaucnaFantastika" runat="server" OnClick="NaucnaFantastika_Click">Naucna-Fantastika</asp:LinkButton>
    </div>
</asp:Content>
