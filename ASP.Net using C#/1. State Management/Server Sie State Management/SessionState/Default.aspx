﻿<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <asp:Label ID="UserNameLabel" runat="server" Text="UserName"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="UserNameTextBox" runat="server" ></asp:TextBox>
        
        <br /><br />
        <asp:Label ID="PasswordLabel" runat="server" Text="Pass"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password" ></asp:TextBox>
        
        <br /><br />
        <asp:Button ID="LoginButton" runat="server" Text="Log In" 
            onclick="LoginButton_Click" />
    </div>
    </form>
</body>
</html>
