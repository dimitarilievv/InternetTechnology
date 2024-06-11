<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Opcii.aspx.cs" Inherits="FinalenProektt.Opcii" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<asp:Label ID="lbKoli" runat="server" Text=""></asp:Label><br />
    <asp:LinkButton ID="bmw" runat="server" OnClick="bmw_Click">BMW</asp:LinkButton><br />
    <asp:LinkButton ID="audi" runat="server" OnClick="audi_Click">AUDI</asp:LinkButton><br />
    <asp:LinkButton ID="mercedes" runat="server" OnClick="mercedes_Click">Mercedes</asp:LinkButton><br />
</asp:Content>
