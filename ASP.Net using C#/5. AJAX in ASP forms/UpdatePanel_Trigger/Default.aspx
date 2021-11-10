<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>UpdatePanel Trigger</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        
        <asp:ScriptManager ID="ScriptManger1" runat="server"> </asp:ScriptManager>
        
        <asp:UpdatePanel ID="UpdatePanelTrigger" runat="server"> 
            <ContentTemplate>
                <asp:Label ID="LabelTime" runat="server"> </asp:Label> <br />
                <asp:Button ID="ButtonClick" runat="server" Text="Button Inside UpdatePanel" />
            </ContentTemplate>
            
            <Triggers>
                 <asp:AsyncPostBackTrigger ControlID="ButtonOutsideUP" EventName="click" />
            </Triggers>
        </asp:UpdatePanel>
        
        <br />
        <asp:Button ID="ButtonOutsideUP" runat="server" Text="Button Outside UpdatePanel" />
        
    </div>
    </form>
</body>
</html>
