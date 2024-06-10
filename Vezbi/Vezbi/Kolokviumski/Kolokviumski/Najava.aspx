<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="Kolokviumski.Najava" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="mt-3">
    Корисничко име:<asp:TextBox ID="Ime" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator 
        class="text-bg-danger"
        ID="RequiredFieldValidator1" 
        runat="server" 
        ErrorMessage="Задолжително поле"
        ControlToValidate="Ime">
    </asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator 
        ID="RegularExpressionValidator2"
        runat="server" 
        class="text-bg-danger"
        ControlToValidate="Ime"
        ValidationExpression=".*[!^/-].*"
        ErrorMessage="Невалиден влез за име" ></asp:RegularExpressionValidator>
</div>
<div class="mt-3">
    Лозинка:<asp:TextBox ID="Lozinka" runat="server" TextMode="Password"></asp:TextBox>
     <asp:RequiredFieldValidator 
         class="text-bg-danger"
        ID="RequiredFieldValidator2" 
        runat="server" 
        ControlToValidate="Lozinka"
        ErrorMessage="Задолжително поле">

    </asp:RequiredFieldValidator>
</div>
<div class="mt-3">
    Емаил:<asp:TextBox ID="Email" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator 
        ID="RequiredFieldValidator3" 
        runat="server" 
        class="text-bg-danger"
        ControlToValidate="Email"
        ErrorMessage="Задолжително поле">
    </asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator 
        ID="RegularExpressionValidator1" 
        runat="server"
        class="text-bg-danger"
        ControlToValidate="Email"
        ValidationExpression="\S+@\S+\.\S+"
        ErrorMessage="Внеси валидна е-маил адреса!">
    </asp:RegularExpressionValidator>
</div>
    <asp:Button ID="NajavaKopce" runat="server" Text="Најави се" OnClick="NajavaKopce_Click" />

<hr />
<div id="container" runat="server" visible="false">
        <div class="mt-3">
        <asp:ListBox ID="lstZanrovi" runat="server" AutoPostBack="True" OnSelectedIndexChanged="lstZanrovi_SelectedIndexChanged">
            <asp:ListItem Value="0">Драма</asp:ListItem>
            <asp:ListItem Value="1">Комедија</asp:ListItem>
            <asp:ListItem Value="2">Акција</asp:ListItem>
        </asp:ListBox>
        <img src="movies.jpg" />
    </div>
    <div class="mt-3" style="display:inline-block">
        <asp:CheckBoxList ID="chkFilmovi" runat="server" AutoPostBack="True"></asp:CheckBoxList>
    </div>
    <div class="mt-3" style="display:inline-block">
        <asp:TextBox ID="txtKolichina1" runat="server" ValidationGroup="isto"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtKolichina2" runat="server" ValidationGroup="isto"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtKolichina3" runat="server" ValidationGroup="isto"></asp:TextBox>
    </div>
    <div class="mt-3">
        <asp:Button ID="Kupi" runat="server" Text="Купи" OnClick="Kupi_Click" ValidationGroup="isto" />
    </div>
    <div class="mt-3">
        <asp:Label ID="lblCena" runat="server" Text=""></asp:Label>
    </div>
</div>

</asp:Content>
