<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="24.aspx.cs" Inherits="Kolokviumski._24" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="mt-3">
        <h2>Kategorii</h2>
    </div>
    <div class="mt-3">
            <asp:LinkButton ID="Komedija" runat="server" OnClick="Komedija_Click">Komedija</asp:LinkButton>
    </div> 
     <div class="mt-3">
            <asp:LinkButton ID="Akcija" runat="server" OnClick="Akcija_Click">Akcija</asp:LinkButton>
    </div>
    <div class="mt-3">
            <asp:LinkButton ID="NaucnaFantastika" runat="server" OnClick="NaucnaFantastika_Click">Naucna Fantastika</asp:LinkButton>
    </div>
       
    
</asp:Content>
