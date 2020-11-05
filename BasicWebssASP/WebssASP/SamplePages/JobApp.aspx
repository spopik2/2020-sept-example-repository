<%@ page title="Job Application" language="C#" masterpagefile="~/Site.Master" autoeventwireup="true" codebehind="JobApp.aspx.cs" inherits="WebssASP.SamplePages.JobApp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Job Application</h1>
    <div class="row">
        <div class="col-offset-1 col-10">
            <blockquote class="alert alert-info" style="font-style: italic">
                This page will illustrate some simple controls to fill out an online job apllication.
                The form will use a basic 2 column bootstrap layout. The form investigates the processing for a 
                CheckBoxList control. Data display will be a simple string.
            </blockquote>
        </div>
    </div>
    <div class="row">
        <div class="col-1">
            <asp:Label ID="Label1" runat="server" Text="Name (Last, First)"></asp:Label>&nbsp;
            <asp:TextBox ID="FullName" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>&nbsp;
            <asp:TextBox ID="EmailAddress" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="Phone (Best Contact)"></asp:Label>&nbsp;
            <asp:TextBox ID="Phone" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label4" runat="server" Text="Full or Part-time"></asp:Label>&nbsp;
            <asp:RadioButtonList ID="FullOrPartTime" runat="server" RepeatLayout="Flow" RepeatDirection="Horizontal">
                <asp:ListItem Value="1">&nbsp;Full-time&nbsp;</asp:ListItem>
                <asp:ListItem Value="2">&nbsp;Part-time&nbsp;</asp:ListItem>
            </asp:RadioButtonList><br />
            <div class="row">
                <div class="col-md-1">
                    <asp:Label ID="Label5" runat="server" Text="Position(s)"></asp:Label>&nbsp;
                </div>
                <div class="col-md-2">
                    <asp:CheckBoxList ID="Jobs" runat="server">
                        <asp:ListItem>Sales</asp:ListItem>
                        <asp:ListItem>Manufacturing</asp:ListItem>
                        <asp:ListItem>Accounting</asp:ListItem>
                        <asp:ListItem>Shipping/Receiving</asp:ListItem>
                        <asp:ListItem>Supervisor</asp:ListItem>
                    </asp:CheckBoxList>
                </div>
            </div>
    </div>
    <div class="col-6">
        <asp:Button ID="Submit" runat="server" Text="Submit"
            class="btn btn-secondary" OnClick="Submit_Click" />
        &nbsp;&nbsp;
            <asp:Button ID="Clear" runat="server" Text="Clear"
                class="btn btn-light" OnClick="Clear_Click" />
        <br />
        <br />
        <asp:Label ID="MessageLabel" runat="server"></asp:Label>
    </div>
    </div>
</asp:Content>
