<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adminLogin.aspx.cs" Inherits="admin_adminLogin" %>

<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="UTF-8">
    <title>Quik Job Admin Login</title>
    
        <link rel="stylesheet" href="logincss/style.css">

  </head>

  <body>

    
<form id="f1" runat="server">
  <header>Login</header>
  <label>Username <span>*</span></label>
  <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
  <label>Password <span>*</span></label>
  <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
    <br />
  <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/>
    <br />
    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    <br />
</form>
    
    
    
    
  </body>
</html>
