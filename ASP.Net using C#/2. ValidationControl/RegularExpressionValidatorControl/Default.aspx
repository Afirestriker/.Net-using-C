<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <table>
            <!-- Row-01 UserName -->
            <tr>
                <td><asp:Label ID="LabelUserName" runat="server" Text="UserName"></asp:Label></td>
                <td><asp:TextBox ID="TextBoxUserName" runat="server" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorTextBoxUserName" runat="server" ControlToValidate="TextBoxUserName"
                     ErrorMessage="UserName*" SetFocusOnError="true" Display="Dynamic" ></asp:RequiredFieldValidator>
                </td>
            </tr>
            
            <!-- Row-02 Password-->
            <tr>
                <td><asp:Label ID="LabelPassword" runat="server" Text="Password"></asp:Label></td>
                <td><asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorTextBoxPassword" runat="server" ControlToValidate="TextBoxPassword"
                     ErrorMessage="Password*" SetFocusOnError="true" Display="Dynamic" ></asp:RequiredFieldValidator>
                </td>
            </tr>
            
            <!-- Row-03 Email-id -->
            <tr>
                <td><asp:Label ID="LabelEmail" runat="server" Text="Email ID"></asp:Label></td>
                <td><asp:TextBox ID="TextBoxEmail" runat="server" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorTextBoxEmail" runat="server" ControlToValidate="TextBoxEmail"
                        ErrorMessage="Email*" SetFocusOnError="true" Display="Dynamic" ></asp:RequiredFieldValidator>
 
 <!-- Regular Expression Validator -->                    
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorTextBoxEmail" 
                        runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Email Invalid"
                        Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                        SetFocusOnError="True"></asp:RegularExpressionValidator>
                </td>
            </tr>
            
            <tr>
                <td><asp:Button ID="ButtonSubmit" runat="server" Text="Submit" /></td>
            </tr>
       </table> 
    </div>
    </form>
</body>
</html>
