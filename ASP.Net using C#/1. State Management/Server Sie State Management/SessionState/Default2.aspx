﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Welcome&nbsp;&nbsp;&nbsp;
        <asp:Label ID="usernameLabel" runat="server" ></asp:Label>
        
        <br /><br />
        <asp:Button ID="SignOutButton" runat="server" Text="Sign Out" 
            onclick="SignOutButton_Click" />
    &nbsp;
    </div>
    </form>
</body>
</html>
