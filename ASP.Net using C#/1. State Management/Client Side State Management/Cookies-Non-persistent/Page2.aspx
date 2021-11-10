<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Page2.aspx.cs" Inherits="Page2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="DisplayNameLabel" runat="server" Text="Label"></asp:Label>
        
        <br /><br />
        &nbsp;<asp:Label ID="Label3" runat="server" Text="Address"></asp:Label>
        
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="DisplayAddressLabel" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
