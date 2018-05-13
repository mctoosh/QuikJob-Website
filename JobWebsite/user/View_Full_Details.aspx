<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="View_Full_Details.aspx.cs" Inherits="user_View_Full_Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">

     <asp:Repeater ID="r2" runat="server">
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
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
    
   <br /> <br />
    
    <asp:Repeater ID="r1" runat="server">
        <HeaderTemplate>
            <table border="1">
                <tr style="background-color:grey; color:white">
                    <td style="padding-right:10px; padding-left:10px">Job Image</td>
                    <td style="padding-right:10px; padding-left:10px">Job Name</td>
                    <td style="padding-right:10px; padding-left:10px">Job Description</td>
                    <td style="padding-right:10px; padding-left:10px">Job Address</td>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
            <td style="padding-right:10px; padding-left:10px">
                <img src="../<%#Eval("Job_Image") %>" height="100" width="100" />
            </td>
            <td style="padding-right:10px; padding-left:10px">
                <%#Eval("Job_Name") %>
            </td>
            <td style="padding-right:10px; padding-left:10px">
                <%#Eval("Job_Description") %>
            </td>
            <td style="padding-right:10px; padding-left:10px">
                <%#Eval("Job_Address") %>
            </td>
                </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>

</asp:Content>

