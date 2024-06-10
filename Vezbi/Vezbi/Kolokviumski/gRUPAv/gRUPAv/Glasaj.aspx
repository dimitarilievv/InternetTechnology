<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="gRUPAv.Glasaj" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="mt-3">
    <img src="finki_logo.png" />
</div>
<div class="mt-3">
    <asp:Label ID="lblProfesor" runat="server" Text=""></asp:Label>
</div>
<div class="mt-3">
    <asp:ListBox ID="lbPredmeti" runat="server" AutoPostBack="True" OnSelectedIndexChanged="lbPredmeti_SelectedIndexChanged"></asp:ListBox>
    <asp:ListBox ID="lbKrediti" runat="server" AutoPostBack="True"></asp:ListBox>
</div>
<div class="mt-3">
    <asp:Button ID="kopce" runat="server" Text="Glasaj" OnClick="kopce_Click" />
</div>

    <hr />

<div class="mt-3">
    Predmet: <br />
    <asp:TextBox ID="predmet" runat="server"></asp:TextBox>
</div>
<div class="mt-3">
     Krediti: <br />
    <asp:TextBox ID="krediti" runat="server"></asp:TextBox>
</div>
<div class="mt-3">
    <asp:Button ID="Dodadi" runat="server" Text="Dodadi" OnClick="Dodadi_Click" />
</div>
<div class="mt-3">
    <asp:Button ID="Izbrisi" runat="server" Text="Izbrisi" OnClick="Izbrisi_Click" />
</div>
<div class="mt-3">

</div>
</asp:Content>
