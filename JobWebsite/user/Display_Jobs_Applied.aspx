<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="Display_Jobs_Applied.aspx.cs" Inherits="user_Display_Jobs_Applied" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">
     <asp:Repeater ID="r1" runat="server">
        <HeaderTemplate>
            <table border="1">
                <tr style="background-color:grey; color:white">
                    <td style="padding-right:10px; padding-left:10px">User ID</td>
                    <td style="padding-right:10px;padding-left:10px">First Name</td>
                    <td style="padding-right:10px;padding-left:10px">Last Name</td>
                    <td style="padding-right:10px;padding-left:10px">Email</td>
                    <td style="padding-right:10px;padding-left:10px">Address</td>
                    <td style="padding-right:10px;padding-left:10px">Postcode</td>
                    <td style="padding-right:10px;padding-left:10px">Age</td>
                    <td style="padding-right:10px;padding-left:10px">PhoneNumber</td>
                    <td style="padding-right:10px;padding-left:10px">User CV</td>
                    <td style="padding-right:10px;padding-left:10px">View Full Details</td>
                    
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td style="padding-right:10px;padding-left:10px"><%#Eval("id") %></td>
                <td style="padding-right:10px;padding-left:10px"><%#Eval("User_Firstname") %></td>
                <td style="padding-right:10px;padding-left:10px"><%#Eval("User_Lastname") %></td>
                <td style="padding-right:10px;padding-left:10px"><%#Eval("User_Email") %></td>
                <td style="padding-right:10px;padding-left:10px"><%#Eval("User_Address") %></td>
                <td style="padding-right:10px;padding-left:10px"><%#Eval("User_Postcode") %></td>
                <td style="padding-right:10px;padding-left:10px"><%#Eval("User_Age") %></td>
                <td style="padding-right:10px;padding-left:10px"><%#Eval("User_PhoneNumber") %></td>
               <td style="padding-right:10px;padding-left:10px"><a href='../<%#Eval("User_CV") %>' download>Download CV Here</a></td>
                <td style="padding-right:10px;padding-left:10px"><a href="View_Full_Details.aspx?id=<%#Eval("id") %>">View Full Details</a></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>

