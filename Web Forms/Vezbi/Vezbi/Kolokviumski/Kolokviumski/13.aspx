<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="13.aspx.cs" Inherits="Kolokviumski._13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server" EnableViewState="True">
    <asp:TextBox ID="name" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator 
        class="text-bg-danger"
        ID="RequiredFieldValidator1" 
        runat="server" 
        ControlToValidate="name"
        ErrorMessage="Zadolzitelno pole">
    </asp:RequiredFieldValidator>
    <asp:TextBox ID="price" runat="server"></asp:TextBox>
     <asp:RequiredFieldValidator
         class="text-bg-danger" 
        ID="RequiredFieldValidator2" 
        runat="server" 
        ControlToValidate="price"
        ErrorMessage="Zadolzitelno pole">
      </asp:RequiredFieldValidator>
  <asp:RangeValidator
    class="text-bg-danger" 
    ID="RangeValidator1" 
    runat="server" 
    ControlToValidate="price"
    ErrorMessage="Ne vnesovte validen broj" 
    Type="Integer" 
    MinimumValue="1"
    MaximumValue="999999999"
    SetFocusOnError="true"> 
</asp:RangeValidator>

    <%--<asp:RegularExpressionValidator
        class="text-bg-danger" 
        ID="RegularExpressionValidator1" 
        runat="server" 
        ControlToValidate="price"
        ErrorMessage="Ne vnesovte validen broj" 
        ValidationExpression="^\d*\.?\d+$">
    </asp:RegularExpressionValidator>--%>
    <asp:Button ID="AddItem" runat="server" Text="Dodadi" OnClick="AddItem_Click" />
    <asp:ListBox ID="lbTitle" runat="server"></asp:ListBox>
    <asp:ListBox ID="lbPrice" runat="server"></asp:ListBox>
</asp:Content>
