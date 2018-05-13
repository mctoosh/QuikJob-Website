<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="userLogin.aspx.cs" Inherits="user_userLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">

    <table>
        <tr>
            <td>
                Enter Email Address
            </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>

            </td>
        </tr>

        <tr>
            <td>
                Enter Password
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>

            </td>
        </tr>

        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            </td>
        </tr>

        <tr>
            <td colspan="2" align="center">
                <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
            </td>
        </tr>

         <tr>
            <td colspan="2" align="center">
                <asp:hyperlink ID="HplRegister" NavigateUrl="Registration.aspx" runat="server">Register here</asp:hyperlink>
            </td>
        </tr>
    </table>

</asp:Content>

