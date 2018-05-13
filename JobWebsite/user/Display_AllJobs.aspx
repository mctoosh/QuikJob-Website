<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="Display_AllJobs.aspx.cs" Inherits="user_Display_AllJobs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">
    <asp:Repeater ID="rptMain" runat="server">
        <HeaderTemplate>
            <ul>
        </HeaderTemplate>
        <ItemTemplate>
            
          <li class="product"> <a href="Job_Description.aspx?id=<%#Eval("JobId")%>"><img src="../<%#Eval("Job_Image")%>" height="210" width="230" /></a>
            <div class="product-info">
              <h3><%#Eval("Job_Type") %></h3>
              <div class="product-desc">
                <h4><%#Eval("Job_Description") %></h4>
                <p><%#Eval("Job_Address") %></p>
                <strong class="price"><%#Eval("Job_Name")%></strong> 
              </div>
            </div>
          </li>

        </ItemTemplate>
        <FooterTemplate>
           </ul>
        </FooterTemplate>
    </asp:Repeater>




</asp:Content>

