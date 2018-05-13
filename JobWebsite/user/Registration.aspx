<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="user_Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">

    <table>
        <tr>
            <td>
                First Name

            </td>
            <td>
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstName" ErrorMessage="Please Enter Firstname" ForeColor="Red" >*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator Display ="Dynamic" ControlToValidate="txtFirstName" ID="RegularExpressionValidator1" ValidationExpression="^[\s\S]{0,22}$" runat="server" ErrorMessage="Maximum 22 characters allowed" ForeColor="Red" ></asp:RegularExpressionValidator>
                  </td>
        </tr>

         <tr>
            <td>
                Last Name

            </td>
            <td>
                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastName" ErrorMessage="Please Enter Lastname" ForeColor="Red" >*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator Display ="Dynamic" ControlToValidate="txtLastName" ID="RegularExpressionValidator2" ValidationExpression="^[\s\S]{0,22}$" runat="server" ErrorMessage="Maximum 22 characters allowed" ForeColor="Red" ></asp:RegularExpressionValidator>
                 </td>
        </tr>

         <tr>
            <td>
                Email

            </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtEmail" ErrorMessage="Please Enter Email Address" ForeColor="Red">*</asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator Display ="Dynamic" ControlToValidate="txtEmail" ID="RegularExpressionValidator4" ValidationExpression="^[\s\S]{0,40}$" runat="server" ErrorMessage="Maximum 40 characters allowed" ForeColor="Red" ></asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="validateEmail" runat="server" ErrorMessage="Invalid email." ControlToValidate="txtEmail" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" ForeColor="Red" />        
                  </td>
        </tr>

         <tr>
            <td>
                Address

            </td>
            <td>
                <asp:TextBox ID="txtAddress" runat="server" Height="88px" TextMode="MultiLine" Width="134px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAddress" ErrorMessage="Please Enter Job Address" ForeColor="Red">*</asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator Display ="Dynamic" ControlToValidate="txtAddress" ID="RegularExpressionValidator3" ValidationExpression="^[\s\S]{0,40}$" runat="server" ErrorMessage="Maximum 40 characters allowed" ForeColor="Red" ></asp:RegularExpressionValidator>
                 </td>
        </tr>

         <tr>
            <td>
                Postcode

            </td>
            <td>
                <asp:TextBox ID="txtPostcode" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtPostcode" ErrorMessage="Please Enter Postcode" ForeColor="Red" >*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator Display ="Dynamic" ControlToValidate="txtPostcode" ID="RegularExpressionValidator5" ValidationExpression="^[\s\S]{0,22}$" runat="server" ErrorMessage="Maximum 22 characters allowed" ForeColor="Red" ></asp:RegularExpressionValidator>
                 </td>
        </tr>

         <tr>
            <td>
                Password

            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtPassword" ErrorMessage="Please Enter Password" ForeColor="Red">*</asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator Display ="Dynamic" ControlToValidate="txtPassword" ID="RegularExpressionValidator6" ValidationExpression="^[\s\S]{0,40}$" runat="server" ErrorMessage="Maximum 40 characters allowed" ForeColor="Red" ></asp:RegularExpressionValidator>
                  </td>
        </tr>

         <tr>
            <td>
                Age

            </td>
            <td>
                <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtAge" ErrorMessage="Please Enter Password" ForeColor="Red">*</asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator Display ="Dynamic" ControlToValidate="txtAge" ID="RegularExpressionValidator7" ValidationExpression="^[\s\S]{0,40}$" runat="server" ErrorMessage="Maximum 40 characters allowed" ForeColor="Red" ></asp:RegularExpressionValidator>
                  </td>
        </tr>

         <tr>
            <td>
                Phone Number

            </td>
            <td>
                <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtPhoneNumber" ErrorMessage="Please Enter Lastname" ForeColor="Red" >*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator Display ="Dynamic" ControlToValidate="txtPhoneNumber" ID="RegularExpressionValidator8" ValidationExpression="^[\s\S]{0,22}$" runat="server" ErrorMessage="Maximum 22 characters allowed" ForeColor="Red" ></asp:RegularExpressionValidator>
                 </td>
        </tr>

         <tr>
            <td>
                CV

            </td>
            <td>
                <asp:FileUpload ID="fldJobImage" runat="server" />
            </td>
        </tr>

        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
            </td>
        </tr>

        <tr>
            <td colspan="2" align="center">
                <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label></td>
        </tr>

             <tr>
            <td colspan="2" align="center">
                <asp:hyperlink ID="HplRegister" NavigateUrl="userLogin.aspx" runat="server">Login here</asp:hyperlink>
            </td>
        </tr>

    </table>

</asp:Content>

