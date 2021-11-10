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
            <tr>
                <td> <asp:Label ID="LabelID" runat="server" Text="ID: "></asp:Label> </td>
                <td> <asp:TextBox ID="TextBoxID" runat="server" ></asp:TextBox> 
                     <asp:RequiredFieldValidator ID="RFVTextBoxID" runat="server" ControlToValidate="TextBoxID" ErrorMessage="ID is required"
                          Text="*" ></asp:RequiredFieldValidator>
                </td>
            </tr>
            
            <tr>
                <td> <asp:Label ID="LabelName" runat="server" Text="Name: "></asp:Label> </td>
                <td> <asp:TextBox ID="TextBoxName" runat="server" ></asp:TextBox> 
                     <asp:RequiredFieldValidator ID="RFVTextBoxName" runat="server" ControlToValidate="TextBoxName" ErrorMessage="Name is required"
                          Text="*" ></asp:RequiredFieldValidator>
                </td>
            </tr>
            
            <tr>
                <td> <asp:Label ID="LabelCity" runat="server" Text="City: "></asp:Label> </td>
                <td> <asp:TextBox ID="TextBoxCity" runat="server"></asp:TextBox> </td>
            </tr>
            
            <tr>
                <td colspan="2"><br /> <asp:Button ID="ButtonInsert" runat="server" Text="INSERT" OnClick="ButtonInsert_Click" /> 
                                 &nbsp; 
                                 <asp:Button ID="ButtonUpdate" runat="server" Text="UPDATE" 
                        onclick="ButtonUpdate_Click" />
                                 &nbsp;
                                 <asp:Button ID="ButtonDelete" runat="server" Text="DELETE" 
                        onclick="ButtonDelete_Click" />
                </td>
            </tr>
            
            <tr>
                <td colspan="2"> <asp:Label ID="LabelStatus" runat="server" ></asp:Label> </td>
            </tr>
        </table>
        
        <br />
        <asp:ValidationSummary ID="VS" runat="server" />
        
    </div>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="ID" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" 
                SortExpression="ID" />
            <asp:BoundField DataField="Emp_Name" HeaderText="Emp_Name" 
                SortExpression="Emp_Name" />
            <asp:BoundField DataField="Emp_City" HeaderText="Emp_City" 
                SortExpression="Emp_City" />
            <asp:BoundField DataField="Emp_Phone" HeaderText="Emp_Phone" 
                SortExpression="Emp_Phone" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
        SelectCommand="SELECT * FROM [Employee] ORDER BY [ID]"></asp:SqlDataSource>
    </form>
</body>
</html>
