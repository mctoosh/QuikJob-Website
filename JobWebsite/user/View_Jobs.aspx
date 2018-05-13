<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="View_Jobs.aspx.cs" Inherits="user_View_Jobs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">

    <div>
    
    <asp:DataList ID="dtlList" runat="server">
        <HeaderTemplate>
        <table border="1">
            <tr style="background-color:silver; color:white; font-weight:bold">
                <td>Job Image</td>
                <td>Job Name</td>
                <td>Job Type</td>
                <td>Job Description</td>
                <td>Job Address</td>
                <td>Job Postcode</td>
                <td>Delete</td>
            </tr>

        </HeaderTemplate>

        <ItemTemplate>
            <tr>
                <td>
                    <img src="../<%#Eval("Job_Image") %>" height="100" width="100" />

                </td>
                <td>
                    <%#Eval("Job_Name") %>

                </td>
                <td>
                    <%#Eval("Job_Type") %>

                </td>
                <td>
                    <%#Eval("Job_Description") %>

                </td>
                <td>
                    <%#Eval("Job_Address") %>

                </td>
                <td>
                    <%#Eval("Job_Postcode") %>

                </td>
                <td>
                    <a href="delete_Job.aspx?id=<%#Eval("id") %>">Delete</a>
                </td>
            </tr>

        </ItemTemplate>

        <FooterTemplate>
        </table>
        </FooterTemplate>
    </asp:DataList>
        <br />
       <p align="center">
           <asp:Button ID="btnFApply" runat="server" Text="Apply For Jobs" OnClick="btnFApply_Click" />
       </p>
    </div>
   </asp:Content>
