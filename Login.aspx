<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication4.Login" %>

       <asp:Content ContentPlaceHolderID="MainContent" runat="server">
           <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate">
               
           </asp:Login>
       </asp:Content>
