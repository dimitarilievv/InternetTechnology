<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Koli.aspx.cs" Inherits="FinalenProektt.Koli" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<asp:Label ID="carName" runat="server" Text=""></asp:Label><br />
    <asp:ListBox ID="modelCar" runat="server" AutoPostBack="True" OnSelectedIndexChanged="modelCar_SelectedIndexChanged"></asp:ListBox>
    <asp:ListBox ID="priceCar" runat="server" AutoPostBack="True"></asp:ListBox><br />
    Total:<asp:Label ID="total" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="addModel" runat="server" Text="Add it to the cart" OnClick="addModel_Click" />
    <br />
    <asp:Button ID="Back" runat="server" Text="Back" OnClick="Back_Click" />
   
    <hr />
    
   <asp:ListBox ID="cart" runat="server" AutoPostBack="True" Visible="False"></asp:ListBox>
     <br /> 
    <asp:Button ID="Buy" runat="server" Text="Buy" OnClick="Buy_Click" />
</asp:Content>
