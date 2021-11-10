<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body> <!-- Ashish Agrawal Roll.No 49 Hidden Field -->
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Click" onclick="Button1_Click" />
        <asp:HiddenField ID="HiddenField1" runat="server" Value="0" />    
        <br /><br />
        <asp:Button ID="Button2" runat="server" Text="Next page" PostBackUrl="~/Page2.aspx" />
    </div>
    </form>
</body>
</html>
