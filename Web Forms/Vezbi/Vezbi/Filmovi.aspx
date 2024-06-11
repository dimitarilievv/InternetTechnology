<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Filmovi.aspx.cs" Inherits="Vezbi.Filmovi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="mt-3">
        <h2>Kategorii</h2>
    </div>
    <div class="mt-3">
        <asp:HyperLink ID="Komedija" runat="server" NavigateUrl="~/Komedija.aspx" ForeColor="Black">Komedija</asp:HyperLink>
    </div>
      <div class="mt-3">
        <asp:HyperLink ID="Akcija" runat="server" NavigateUrl="~/Akcija.aspx" ForeColor="Black">Akcija</asp:HyperLink>
    </div>
      <div class="mt-3">
        <asp:HyperLink ID="Naucna_Fantastika" runat="server" NavigateUrl="~/Naucna.aspx" ForeColor="Black">Naucna Fantastika</asp:HyperLink>
    </div>
    <hr />
    <asp:ListBox ID="ListBox2" runat="server" OnSelectedIndexChanged="ListBox2_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>
</asp:Content>
