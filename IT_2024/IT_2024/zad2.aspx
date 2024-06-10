<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="zad2.aspx.cs" Inherits="IT_2024.zad2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="mt-3">
        Име на валута:<asp:TextBox ID="CurrencyName" runat="server"></asp:TextBox>
    </div>

    <div class="mt-3">
        Вредност на валута во денари:<asp:TextBox ID="CurrencyValue" runat="server"></asp:TextBox>
    </div>

    <div class="mt-3">
        <asp:Button ID="SubmitResults" runat="server" Text="Зачувај!" OnClick="SubmitResults_Click" />
    </div>

    <div class="mt-3">
        Достапни валути: <br/>
        <asp:RadioButtonList ID="allCurrencies" runat="server"></asp:RadioButtonList>
    </div>

   <div class="mt-3">
       Број на достапни валути: <br/>
       <asp:Label ID="Counter" runat="server" Text="Label"></asp:Label>
   </div>

    <div class="mt-3">
        <asp:Button ID="RemoveItem" runat="server" Text="Избриши валута!" OnClick="RemoveItem_Click" />
    </div>
</asp:Content>
