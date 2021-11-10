<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>Program to represent how CompareValidator and RangeValidator validation control validates data</p>
        <br />
        <table>
            <!-- Row-01 UserName-->
            <tr>
                <td> <asp:Label ID="LabelUserName" runat="server" Text="UserName:"></asp:Label> </td>
                <td> 
                    <asp:TextBox ID="TextBoxUserName" runat="server"></asp:TextBox> 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorUserName" runat="server" ControlToValidate="TextBoxUserName" 
                     ErrorMessage="Name*" ForeColor="Red" Display="Dynamic" ></asp:RequiredFieldValidator>
                </td>
            </tr>
            
            <!-- Row-02 Password-->
            <tr>
                <td> <asp:Label ID="LabelPassword" runat="server" Text="Password:"></asp:Label> </td>
                <td> 
                    <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password"></asp:TextBox> 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" ControlToValidate="TextBoxPassword" 
                     ErrorMessage="Password*" ForeColor="Red" Display="Dynamic" ></asp:RequiredFieldValidator>
                </td>
            </tr>
            
            <!-- Row-03 ConfrimPassword-->
            <tr>
                <td> <asp:Label ID="LabelConfirmPassword" runat="server" Text="Confirm Password:"></asp:Label> </td>
                <td> 
                    <asp:TextBox ID="TextBoxConfirmPassword" runat="server" TextMode="Password"></asp:TextBox> 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorConfirmPassword" runat="server" ControlToValidate="TextBoxConfirmPassword" 
                     ErrorMessage="Required*" ForeColor="Red" Display="Dynamic" ></asp:RequiredFieldValidator>
                   
<!--CompareValidator-->
                    <asp:CompareValidator ID="CompareValidatorConfirmPassword" runat="server" ControlToValidate="TextBoxConfirmPassword" 
                     ControlToCompare="TextBoxPassword" ErrorMessage="Password did not match" Operator="Equal" Type="String" 
                     Display="Dynamic"  ></asp:CompareValidator>
                </td>
            </tr>
            
            <!-- Row-04 DOB -->
            <tr>
                <td> <asp:Label ID="LabelDOB" runat="server" Text="DOB (MM/DD/YYYY):"></asp:Label> </td>
                <td> 
                    <asp:TextBox ID="TextBoxDOB" runat="server"></asp:TextBox> 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorTextBoxDOB" runat="server" ControlToValidate="TextBoxDOB" 
                     ErrorMessage="DOB*" ForeColor="Red" Display="Dynamic" ></asp:RequiredFieldValidator>
<!--RangeValidator-->                    
                    <asp:RangeValidator ID="RangeValidatorTextBoxDOB" runat="server" ControlToValidate="TextBoxDOB" 
                     ErrorMessage="DOB must be between (01/01/2000) - (12/31/2004)" MinimumValue="01/01/2000" 
                        MaximumValue="12/31/2004" Type="Date" Display="Dynamic" ></asp:RangeValidator>
                </td>
            </tr>            
            
            <!-- Row-05 CreateUserButton -->
            <tr>
                <td> <asp:Button ID="ButtonCreateUser" runat="server" Text="Create User" 
                        onclick="ButtonCreateUser_Click" /> </td>
                <td> <asp:Label ID="LabelStatus" runat="server" ForeColor="Green"></asp:Label> </td>
            </tr>
            
        </table>
    </div>
    </form>
</body>
</html>