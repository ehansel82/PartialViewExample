<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webform.aspx.cs" Inherits="PartialViewExample.webform" %>
<%@ Register TagPrefix="uc" TagName="Dropdown" 
    Src="~/WebformDropdown.ascx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.1.0.js"></script>
    <script src="Scripts/bootstrap.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>This is a webforms page.</h1>
        <asp:Button ID="Button1" runat="server" Text="Web Forms Button" OnClick="Button1_Click" /> 
        <asp:Label ID="Label1" runat="server" Text="You clicked the button!" Visible="false"></asp:Label>
        <div>
            <uc:Dropdown runat="server"/>
        </div>
    </div>
    </form>
</body>
</html>
