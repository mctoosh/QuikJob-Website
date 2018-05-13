<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="Add_Jobs.aspx.cs" Inherits="admin_Add_Jobs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">
    <h3> Add Jobs Page</h3>

    <table>
        <tr>
            <td style="height: 30px">Job Name</td>
            <td style="height: 30px"><asp:TextBox ID="txtJobName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtJobName" ErrorMessage="Please Enter Job Name" ForeColor="Red" >*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator Display ="Dynamic" ControlToValidate="txtJobName" ID="RegularExpressionValidator1" ValidationExpression="^[\s\S]{0,22}$" runat="server" ErrorMessage="Maximum 22 characters allowed" ForeColor="Red" ></asp:RegularExpressionValidator>
            </td>
        </tr>

         <tr>
            <td>Job Type</td>
            <td><asp:TextBox ID="txtJobType" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtJobType" ErrorMessage="Please Enter Job Type" ForeColor="Red">*</asp:RequiredFieldValidator>
             <asp:RegularExpressionValidator Display ="Dynamic" ControlToValidate="txtJobType" ID="RegularExpressionValidator2" ValidationExpression="^[\s\S]{0,22}$" runat="server" ErrorMessage="Maximum 22 characters allowed" ForeColor="Red" ></asp:RegularExpressionValidator> 
            </td>
        </tr>

         <tr>
            <td>Job Description</td>
            <td><asp:TextBox ID="txtJobDescription" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtJobDescription" ErrorMessage="Please Enter Job Description" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator Display ="Dynamic" ControlToValidate="txtJobDescription" ID="RegularExpressionValidator3" ValidationExpression="^[\s\S]{0,100}$" runat="server" ErrorMessage="Maximum 100 characters allowed" ForeColor="Red" ></asp:RegularExpressionValidator>
                  </td>
        </tr>

        <tr>
            <td>Job Address</td>
            <td><asp:TextBox ID="txtJobAddress" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtJobAddress" ErrorMessage="Please Enter Job Address" ForeColor="Red">*</asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator Display ="Dynamic" ControlToValidate="txtJobAddress" ID="RegularExpressionValidator4" ValidationExpression="^[\s\S]{0,40}$" runat="server" ErrorMessage="Maximum 40 characters allowed" ForeColor="Red" ></asp:RegularExpressionValidator>
              </td>
        </tr>

         <tr>
            <td>Job Postcode</td>
            <td><asp:TextBox ID="txtJobPostcode" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtJobPostcode" ErrorMessage="Please Enter Job Postcode" ForeColor="Red">*</asp:RequiredFieldValidator>
              <asp:RegularExpressionValidator Display ="Dynamic" ControlToValidate="txtJobPostcode" ID="RegularExpressionValidator5" ValidationExpression="^[\s\S]{0,22}$" runat="server" ErrorMessage="Maximum 22 characters allowed" ForeColor="Red" ></asp:RegularExpressionValidator> 
                 </td>
        </tr>

        <tr>
            <td>Job Image</td>
            <td>
                <asp:FileUpload ID="fldJobImage" runat="server" />
            </td>
        </tr>

        <tr>
            <td>Select Category</td>
            <td>
                <asp:DropDownList ID="ddl1" runat="server"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ddl1" ErrorMessage="Please select a Category" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="btnUpload" runat="server" text="Upload" OnClick="btnUpload_Click" />
            </td>
        </tr>

         <tr>
            <td colspan="2" align="center">
                <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>

            </td>
        </tr>

    </table>

</asp:Content>

