<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="gRUPAv.Najava" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="mt-3">
    Ime
    <asp:TextBox ID="ime" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator 
        class="text-bg-danger"
        ID="RequiredFieldValidator1" 
        runat="server" 
        ControlToValidate="ime"
        ErrorMessage="Vnesete ime!">

    </asp:RequiredFieldValidator>
</div>
<div class="mt-3">
    Lozinka
    <asp:TextBox ID="lozinka" runat="server" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator 
        class="text-bg-danger"
        ID="RequiredFieldValidator2" 
        runat="server" 
        ControlToValidate="lozinka"
        ErrorMessage="Vnesete lozinka!">

    </asp:RequiredFieldValidator>
</div>
<div class="mt-3">
    e-adresa
    <asp:TextBox ID="email" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator 
        class="text-bg-danger"
        ID="RequiredFieldValidator3"
        runat="server" 
        ControlToValidate="email"
        ErrorMessage="Vnesete email!">
    </asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator 
        class="text-bg-danger"
        ID="RegularExpressionValidator1" 
        runat="server" 
        ControlToValidate="email"
        ErrorMessage="Nevaliden format" 
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">

    </asp:RegularExpressionValidator>
</div>
    <div class="mt-3">
    <asp:Button ID="kopce" runat="server" Text="Najavete se" OnClick="kopce_Click" />
</div>
    <div>
        <asp:Label ID="veke" runat="server" Text=""></asp:Label>
    </div>
<div>
    <asp:ListBox ID="istiMailovi" runat="server" Visible="False" AutoPostBack="True"></asp:ListBox>
</div>
</asp:Content>
