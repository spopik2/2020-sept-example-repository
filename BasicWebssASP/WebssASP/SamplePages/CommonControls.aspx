<%@ page title="Common Controls" language="C#" masterpagefile="~/Site.Master" autoeventwireup="true" codebehind="CommonControls.aspx.cs" inherits="WebssASP.SamplePages.CommonControls" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <h1>Common Web Form Controls and using event driven logic</h1>
    </div>
    <%-- Textbox --%>
    <div class="row">
        <div class="col-md-6 text-right">
            <asp:Label ID="Label1" runat="server" Text="Enter a selection choice 1 to 4:"></asp:Label>&nbsp;&nbsp;
        </div>
        <div class="col-md-6 text right">
            <asp:TextBox ID="NumberChoice" runat="server" width="50px" height="30px" ToolTip="Enter a number between 1 and 4"></asp:TextBox>&nbsp;&nbsp;
            <asp:Button ID="SubmitNumberChoice" runat="server" Text="Submit number choice" CssClass="btn btn-success" OnClick="SubmitNumberChoice_Click" />
        </div>
    </div>
    <%-- Radio Button List--%>
    <div class="row">
        <div class="col-md-6 text-right">
            <asp:Label ID="Label2" runat="server" Text="Radio Buttons of choice:"></asp:Label>&nbsp;
        </div>
        <div class="col-md-6 text-left">
            <asp:RadioButtonList ID="RadioButtonListChoice" runat="server"
                RepeatDirection="Horizontal" RepeatLayout="Flow" CellSpacing="5">
                <asp:ListItem Value="1">&nbsp;COMP1008&nbsp;</asp:ListItem>
                <asp:ListItem Value="2">&nbsp;CPSC1517&nbsp;</asp:ListItem>
                <asp:ListItem Value="3">&nbsp;DMIT1508&nbsp;</asp:ListItem>
                <asp:ListItem Value="4">&nbsp;DMIT2018&nbsp;</asp:ListItem>
            </asp:RadioButtonList>
        </div>
    </div>
    <%-- Check Box --%>
    <div class="row">
        <div class="col-md-6 text-right">
            <asp:Label ID="Label3" runat="server" Text="Checkbox of choice:"></asp:Label>&nbsp;&nbsp;
        </div>
        <div class="col-md-6 text-left">
            <asp:CheckBox ID="CheckBoxChoice" runat="server" Text="(check if a programming language)">
            </asp:CheckBox>
        </div>
    </div>
    <%-- Label --%>

    <div class="row">
        <div class="col-md-6 text-right">
            <asp:Literal ID="Literal1" runat="server" Text="Read only display using a label:"></asp:Literal>
        </div>
        <div class="col-md-6 text-left">
            <asp:Label ID="DisplayReadOnly" runat="server"></asp:Label>
        </div>
    </div>
    <%-- DDL Collection --%>
    <div class="row">
        <div class="col-md-6 text-right">
            <asp:Label ID="Label4" runat="server" Text="DDL Collection:"></asp:Label>&nbsp;&nbsp;
        </div>
        <div class="col-md-6 text-left">
            <asp:DropDownList ID="CollectionList" runat="server">

            </asp:DropDownList> 
            <asp:LinkButton ID="LinkButtonChoice" runat="server">Submit Collection Choice</asp:LinkButton>
        </div>
    </div>
    <%-- output area for messages --%>
    <div class="row">
        <div class="col-md-12 text-center">
            <br /><br />
            <asp:Label ID="MessageLabel" runat="server"></asp:Label>&nbsp;
        </div>
    </div>
</asp:Content>
