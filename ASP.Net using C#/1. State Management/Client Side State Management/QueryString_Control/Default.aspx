<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="LabelUserName" runat="server" Text="UserName"></asp:Label>
        <asp:TextBox ID="TextBoxUserName" runat="server" 
            style="margin-left: 60px; margin-top: 16px"></asp:TextBox>
            
        <br /> <br />
        <asp:Label ID="labelPass" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="TextBoxPass" runat="server" TextMode="Password"
            style="margin-left: 66px"> </asp:TextBox>
        
        <br /><br />
        <asp:Button ID="ButtonLogin" runat="server" Text="Login"
            style="margin-left:130px" onclick="ButtonLogin_Click" />
        
        <br /><br />
        <asp:Label ID="labelStatus" runat="server"
            style="margin-left:130px "></asp:Label>
    </div>
    </form>
</body>
</html>
