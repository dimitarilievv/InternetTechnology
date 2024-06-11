<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="15.aspx.cs" Inherits="Kolokviumski._15" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="row">
    <div class="col-xs-offset-1 col-xs-8">
        <asp:ListBox ID="itemTitle" runat="server" Height="250px" Width="850px"></asp:ListBox>
    </div>
    <div class="col-xs-2">
        <asp:ListBox ID="itemPrice" runat="server" Height="250px" Width="100%"></asp:ListBox>
    </div>
</div>
</asp:Content>
