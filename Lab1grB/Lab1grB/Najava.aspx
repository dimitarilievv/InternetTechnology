<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="Lab1grB.Najava" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Login ID="Login1" runat="server">
        <LayoutTemplate>
            <table cellpadding="1" cellspacing="0" style="border-collapse:collapse;>
                <tr>
                    <td>
                        <table cellpadding="0">
                            <tr>
                                <td align="center" colspan="2">Najava</td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Ime:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="Login1" ForeColor="Red">Vnesi ime!</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <caption>
                                <br />
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Lozinka:</asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ForeColor="Red" ToolTip="Password is required." ValidationGroup="Login1">Vnesi lozinka!</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <caption>
                                    <br />
                                    <tr>
                                        <td align="right">
                                            <asp:Label ID="Label1" runat="server" AssociatedControlID="Password">Email:</asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TextBox1" runat="server" TextMode="Email"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Email is required." ForeColor="Red" ToolTip="Email is required." ValidationGroup="Login1">Vnesi validen email!</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <caption>
                                        <br />
                                        <tr>
                                            <td align="center" colspan="2">
                                                <asp:Button ID="LoginButton" runat="server" CommandName="Login" OnClick="LoginButton_Click" Text="Log In" ValidationGroup="Login1" Width="100px" />
                                            </td>
                                        </tr>
                                    </caption>
                                </caption>
                            </caption>
                        </table>
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
    </asp:Login>
</asp:Content>
