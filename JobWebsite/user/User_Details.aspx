<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="User_Details.aspx.cs" Inherits="user_User_Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="Server">
    <asp:Repeater ID="r1" runat="server">
        <HeaderTemplate>
            <table>
                <tr>
                    <td>Welcome You Have Successfully Signed In as </td>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><%#Eval("First_Name") %> <%#Eval("Last_Name") %> </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
   <p><a href="Display_AllJobs.aspx">Search For Jobs</a></p>
</asp:Content>

