<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="Update_User_Details.aspx.cs" Inherits="user_Update_User_Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">
   <table>
       <tr>
           <td>
               FirstName
           </td>
           <td>
               <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
           </td>
       </tr>

       <tr>
           <td>
               LastName
           </td>
           <td>
               <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                </td>
       </tr>

       <tr>
           <td>
               Email
           </td>
           <td>
               <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                 </td>
       </tr>

       <tr>
           <td>
               Address
           </td>
           <td>
               <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
       </tr>

       <tr>
           <td>
               Postcode
           </td>
           <td>
               <asp:TextBox ID="txtPostcode" runat="server"></asp:TextBox>
                 </td>
       </tr>

       <tr>
           <td>
               Age
           </td>
           <td>
               <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                </td>
       </tr>

       <tr>
           <td>
               PhoneNumber
           </td>
           <td>
               <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
                  </td>
       </tr>

       <tr>
           <td colspan="2" align="center">
               <asp:Button ID="btnUpdate" runat="server" Text="Update and Continue" OnClick="btnUpdate_Click" />
           </td>
       </tr>
   </table>
</asp:Content>

