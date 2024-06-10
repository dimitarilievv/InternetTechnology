<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Plakjanje.aspx.cs" Inherits="Fiilmovi_zadaca.Plakjanje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="row">
        <div class="col-xs-12 text-center">
            <h1>Proizvodi vo kosnica</h1>
        </div>
    </div>
       <div class="row">
        <div class="col-xs-12 text-center">
            <asp:ListBox ID="Kosnica" runat="server" AutoPostBack="True"></asp:ListBox>
        </div>
    </div>
        <div class="row">
        <div class="col-xs-12 text-center">
            <asp:LinkButton ID="Back" runat="server" OnClick="Back_Click">Nazad</asp:LinkButton>
        </div>
    </div>
     <div class="row">
        <div class="col-xs-12 text-center">
            <asp:Button ID="Kupi" runat="server" Text="" OnClick="Kupi_Click" />
        </div>
</div>
</asp:Content>
