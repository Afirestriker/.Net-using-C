<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!-- Navigating through pages using Hyperlink control -->
        <br />
        Welcome to Default1.aspx
        
        <br />
        <asp:HyperLink ID="HyperlinkDefault2" runat="server" NavigateUrl="~/Default2.aspx">Redirect to Default2.aspx</asp:HyperLink>
        
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://www.google.com" >Google</asp:HyperLink>
    </div>
    </form>
</body>
</html>
