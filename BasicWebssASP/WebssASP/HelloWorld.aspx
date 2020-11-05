<%@ Page Title="Hello World" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HelloWorld.aspx.cs" Inherits="WebssASP.HelloWorld" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Hello World</h1>
    <div class="row">
         <div class="offset-1">
             <asp:Label ID="PromptLabel" runat="server" Text="Enter your name"></asp:Label>&nbsp;&nbsp;
             <asp:TextBox ID="NameArg" runat="server" ToolTip="Enter your name"
                  placeholder="Your Name"></asp:TextBox>&nbsp;&nbsp;
             <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="PressMe" OnClick="Button1_Click" /><br /><br />
             <asp:Label id="OutputArea" runat="server"></asp:Label>
         </div>
    </div>
</asp:Content>
