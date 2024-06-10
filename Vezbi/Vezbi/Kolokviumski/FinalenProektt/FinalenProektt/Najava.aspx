<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="FinalenProektt.Najava" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="mt-3">
    Username:<br />
    <asp:TextBox ID="username" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator
        class="text-bg-danger"
        ID="RequiredFieldValidator1" 
        runat="server" 
        ControlToValidate="username"
        ErrorMessage="Username required">
    </asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator 
        class="text-bg-danger"
        ID="RegularExpressionValidator1" 
        runat="server" 
        ControlToValidate="username"
        ValidationExpression="[a-z]{9,11}"
        ErrorMessage="Unvalid username">
    </asp:RegularExpressionValidator>
</div>
<div class="mt-3">
    Password:<br />
    <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator
        class="text-bg-danger"
        ID="RequiredFieldValidator2" 
        runat="server" 
        ControlToValidate="password"
        ErrorMessage="Password required">
    </asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator 
        ID="RegularExpressionValidator2" 
        class="text-bg-danger"
        runat="server" 
        ControlToValidate="password"
        ValidationExpression="[A-Za-z]+[0-9]{3,}[!*@]+"
        ErrorMessage="Unvalid password" >
    </asp:RegularExpressionValidator>
</div>
<div class="mt-3">
    Email:<br />
    <asp:TextBox ID="email" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator
        class="text-bg-danger"
        ID="RequiredFieldValidator3" 
        runat="server" 
        ControlToValidate="email"
        ErrorMessage="Email required">
    </asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator 
        ID="RegularExpressionValidator3"
        class="text-bg-danger"
        runat="server" 
        ControlToValidate="email"
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        ErrorMessage="Unvalid email"></asp:RegularExpressionValidator>
</div>
<div class="mt-3">
    <asp:Button ID="loginButton" runat="server" Text="Login" OnClick="loginButton_Click" />
</div>
</asp:Content>
