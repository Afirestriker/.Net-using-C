<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!-- Representing the working of Response.Redirect() and Server.Transfer() Navigation method -->
        
        <br />
        <asp:Button ID="ButtonResponse" runat="server" Text="Response.Redirect()" 
            onclick="ButtonResponse_Click" />
        
        <br /><br />
        <asp:Button ID="ButtonServer" runat="server" Text="Response.Server()" 
            onclick="ButtonServer_Click" />
        
    </div>
    </form>
</body>
</html>
