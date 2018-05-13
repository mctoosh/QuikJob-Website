<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="Add_Category.aspx.cs" Inherits="admin_Add_Category" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">

    <table>
        <tr>
            <td>Enter Category Name</td>
            <td><asp:TextBox ID="txtCategory" runat="server"></asp:TextBox></td>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCategory" ErrorMessage="Please Enter Job Category Name" ForeColor="Red" >*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator Display ="Dynamic" ControlToValidate="txtCategory" ID="RegularExpressionValidator1" ValidationExpression="^[\s\S]{0,22}$" runat="server" ErrorMessage="Maximum 22 characters allowed" ForeColor="Red" ></asp:RegularExpressionValidator>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="btnAddCat" runat="server" Text="Add Category" OnClick="btnAddCat_Click" />
            </td>
        </tr>
    </table>


    <asp:Datalist ID="dd1" runat="server">
        <HeaderTemplate>
            <table>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><%#Eval("Job_Catagory") %></td>
                <td>
                    <a href="Delete.aspx?category=<%#Eval("Job_Catagory") %>">Delete </a>
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
        


    </asp:Datalist>


</asp:Content>

