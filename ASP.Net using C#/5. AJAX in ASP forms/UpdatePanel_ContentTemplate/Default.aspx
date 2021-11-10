<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>UpdatePanel ContentTemplate</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!-- Progam to demonstare the need of AJAX controls in ASP.Net
             AJAX controls allow partial post-back, as in the below program
             1. First ScriptManager is mandatory for working with Ajax Controls, (used to managed all ajax controls"
                There can be only one ScriptManager per page.
             
             2. UpdatePanel control is a container control, using which parital post-back is achieved.
                When post-back is trigger inside UpdatePanel only controls that inside UpdatePanel are reloaed/post-back not the whole page.
                To work with UpdatePanel the ContentTemplate or Trigger either one of them must be embedded inside UpdatePanel
                UpdatePanel has an property called as UpdateMode, that denotes which UpdatePanel to be post-back whenever post-back event occur.
                 
             3. UpdateMode = "Always" => Represent that this control will be updated each time the post-back is trigger whether it is  from other UpdatePanel
                UpdateMode = "Conditional" => Represent that this control will be affected by outside event, though it has trigger through other UpdatePanel
         -->
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        
        <asp:Label ID="LabelText1" runat="server" Text="Update Panel 1 (UpdateMode (default value) = Always)"></asp:Label>
        <!-- UpdatePanel1 -->
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" > 
            <ContentTemplate>
                <asp:Label ID="Label1" runat="server" > </asp:Label>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Button_UP1" 
                    onclick="Button1_Click" />
            </ContentTemplate>
        </asp:UpdatePanel>
        
        <br /><br />
        
        <asp:Label ID="LabelText2" runat="server" Text="Update Panel 2 (UpdateMode value = Conditional)"></asp:Label>
        <!-- UpdatePanel 2 -->
        <br />
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional"> 
            <ContentTemplate>
                <asp:Label ID="Label2" runat="server"></asp:Label>
                <br />
                <asp:Button ID="Button2" runat="server" Text="Button_UP2" />
            </ContentTemplate>
        </asp:UpdatePanel>
        
        <br /><br />
        <!-- Without Update Panel -->
        <asp:Label ID="LabelText3" runat="server" Text="Without Update Panel"></asp:Label>
        <br /><br />
        <asp:Label ID="Label3" runat="server"></asp:Label>
        <br />
        <asp:Button ID="Button3" runat="server" Text="Button_WithoutUP" />
        
    </div>
    </form>
</body>
</html>
