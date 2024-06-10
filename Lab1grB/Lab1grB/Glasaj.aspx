<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="Lab1grB.Glasaj" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="mt-3">
        <img src="finki_52_1_2_1_62_0.png" />
    </div>
    <div class="mt-3">
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
    <div class="mt-3">
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
        <asp:ListBox ID="ListBox2" runat="server" AutoPostBack="True"></asp:ListBox>
    </div>
    <div class="mt-3">
        <asp:Button ID="Button1" runat="server" Text="Glasajte" OnClick="Button1_Click" />
    </div>
    <hr>
    <div class="mt-3">
        <asp:Label ID="Label4" runat="server" Text="Predmet"></asp:Label>
    </div>
    <div class="mt-3">
        <asp:TextBox ID="PredmetTextBox" runat="server"></asp:TextBox>
    </div>
    <div class="mt-3">
       <asp:Label ID="Label2" runat="server" Text="Krediti"></asp:Label>
    </div>
    <div class="mt-1">
        <asp:TextBox ID="KreditiTextBox" runat="server"></asp:TextBox>
    </div>
    <div class="mt-3">
        <asp:Button ID="Button2" runat="server" Text="Dodadi" OnClick="Button2_Click" />
    </div>
    <div class="mt-3">
        <asp:Button ID="Button3" runat="server" Text="Izbrisi" OnClick="Button3_Click" />
    </div>
</asp:Content>
