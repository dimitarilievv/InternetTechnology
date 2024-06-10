<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="12.aspx.cs" Inherits="Kolokviumski._12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="container" style="margin:30px">
    <div class="row" style="width:300px; margin:auto;margin-top:30px;">
        <asp:ListBox ID="lbItems" runat="server"></asp:ListBox>
    </div>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
</div>
</asp:Content>
