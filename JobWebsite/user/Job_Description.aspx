<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="Job_Description.aspx.cs" Inherits="user_Job_Description" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">

    

    <asp:Repeater ID="rptMain1" runat="server">
        <HeaderTemplate>
        </HeaderTemplate>
        <ItemTemplate>
            
        <div style="height:300px; width:300px; float:left; border-style:solid; border-width:1px;" >
            <img src='../<%#Eval("Job_Image") %>' height="300" width="300" />
        </div>

        <div style="height:300px; width:400px; float:left; border-style:solid; border-width:1px;">
        Job Name: <%#Eval("Job_Name")%><br />
        Job Type: <%#Eval("Job_Type")%><br />
        Job Description: <%#Eval("Job_Description")%><br />
        Job Address: <%#Eval("Job_Address")%><br />
        Job Postcode: <%#Eval("Job_Postcode")%>
            </div>

        </ItemTemplate>
        <FooterTemplate>
           
        </FooterTemplate>
    </asp:Repeater>
    <br /> 
    
    <asp:Button ID="btnApply" runat="server" Text="Save Job" OnClick="btnApply_Click" />

</asp:Content>

