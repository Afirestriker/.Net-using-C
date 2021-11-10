<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AJAX TimerControl</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        
        <asp:ScriptManager ID="ScriptManager1" runat="server" ></asp:ScriptManager>
        
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="LabelTimer" runat="server"></asp:Label>
            </ContentTemplate>
            
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
            </Triggers>
        </asp:UpdatePanel>
        
        <asp:Timer ID="Timer1" runat="server" Interval="100"></asp:Timer>
    </div>
    </form>
</body>
</html>
