<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Books.aspx.cs" Inherits="Vezbi.Books" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="mt-3">
        Ime:
        <br />
        <asp:TextBox ID="Ime" runat="server"></asp:TextBox> 
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Poleto e zadolzitelno" ControlToValidate="Ime"></asp:RequiredFieldValidator>

    </div>
    <div class="mt-3">
        Cena:
        <br />
        <asp:TextBox ID="Cena" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Poleto e zadolzitelno" ControlToValidate="Cena"></asp:RequiredFieldValidator>
    </div>
    <div class="mt-3">
        <asp:Button ID="Dodadi" runat="server" Text="Dodadi" OnClick="Dodadi_Click" /> 
    </div>
    <br />
    <div class="mt-3">
        <asp:Label ID="CenaLabela" runat="server" Text=""></asp:Label>
    </div>
    <br />
    <div class="mt-3">
        <asp:ListBox ID="Knigi" runat="server" Height="146px" Width="211px" OnSelectedIndexChanged="Knigi_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>
    </div>
    <div class="mt-3">
        <br />
        <asp:Button ID="Izbrisi" runat="server" Text="Izbrisi" OnClick="Izbrisi_Click" /> 
    </div>
</asp:Content>
