<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Menu Navigation control"></asp:Label>
        <br />
        <asp:Menu ID="Menu1" runat="server">
            <Items>
                <asp:MenuItem Text="Files" Value="Files">
                    <asp:MenuItem Text="New" Value="New"></asp:MenuItem>
                    <asp:MenuItem Text="Open" Value="Open"></asp:MenuItem>
                    <asp:MenuItem Text="Save" Value="Save"></asp:MenuItem>
                    <asp:MenuItem Text="Save As" Value="Save As"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Edit" Value="Edit">
                    <asp:MenuItem Text="Copy" Value="Copy"></asp:MenuItem>
                    <asp:MenuItem Text="Paste" Value="Paste"></asp:MenuItem>
                    <asp:MenuItem Text="Cut" Value="Cut"></asp:MenuItem>
                    <asp:MenuItem Text="Select All" Value="Select All"></asp:MenuItem>
                </asp:MenuItem>
            </Items>
        </asp:Menu>
        
        <br /><br /><br />
        <asp:Label ID="Label2" runat="server" Text="TreeView Navigation Control"></asp:Label>    
        <br />
        <asp:TreeView ID="TreeView1" runat="server">
            <Nodes>
                <asp:TreeNode Expanded="False" Text="Files" Value="Files">
                    <asp:TreeNode Text="New" Value="New"></asp:TreeNode>
                    <asp:TreeNode Text="Open" Value="Open"></asp:TreeNode>
                    <asp:TreeNode Text="Save" Value="Save"></asp:TreeNode>
                    <asp:TreeNode Text="Save As" Value="Save As"></asp:TreeNode>
                </asp:TreeNode>
                <asp:TreeNode Expanded="False" Text="Edit" Value="Edit">
                    <asp:TreeNode Text="Copy" Value="Copy"></asp:TreeNode>
                    <asp:TreeNode Text="Paste" Value="Paste"></asp:TreeNode>
                    <asp:TreeNode Text="Cut" Value="Cut"></asp:TreeNode>
                    <asp:TreeNode Text="Select All" Value="Select All"></asp:TreeNode>
                </asp:TreeNode>
            </Nodes>
        </asp:TreeView>
        
    
    </div>
    </form>
</body>
</html>
