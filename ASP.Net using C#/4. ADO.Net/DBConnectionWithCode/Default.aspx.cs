using System;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using System.Data;          //For database connection
using System.Data.OleDb;    //Database type OleDb since Access database is used.

public partial class _Default : System.Web.UI.Page 
{
    //Declaring global variable for each disconnected database connection object
    public OleDbCommand cmd;
    public OleDbConnection con;
    public OleDbDataAdapter dap;
    public DataSet ds;

    protected void Page_Load(object sender, EventArgs e)
    {
        retrieveData();   
    }

    private void retrieveData()
    {
        con = new OleDbConnection(" Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:/a coding/NET using C#/ASP.Net using C#/ADO.Net/Emp.mdb ");
        con.Open();

        dap = new OleDbDataAdapter("select * from Employee", con);

        ds = new DataSet();
        dap.Fill(ds);

        GridView1.DataSource = ds;
        GridView1.DataBind();
    }

    //insert button
    protected void ButtonInsert_Click(object sender, EventArgs e)
    {
        con = new OleDbConnection(" Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:/a coding/NET using C#/ASP.Net using C#/ADO.Net/Emp.mdb ");
        con.Open();

        String insertQuery = "";
        insertQuery = " insert into Employee values("+TextBoxID.Text+", '"+TextBoxName.Text+"', '"+TextBoxCity.Text+"') ";
        
        cmd = new OleDbCommand(insertQuery, con);
        cmd.ExecuteNonQuery();
        
        con.Close();
        LabelStatus.Text = "Data Inserted";

        retrieveData();
    }

    //update button
    protected void ButtonUpdate_Click(object sender, EventArgs e)
    {
        con = new OleDbConnection(" Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:/a coding/NET using C#/ASP.Net using C#/ADO.Net/Emp.mdb ");
        con.Open();

        String updateQuery = "";
        updateQuery = " update Employee set EmpName='" + TextBoxName.Text + "', EmpCity='" + TextBoxCity.Text + "' where ID=" + TextBoxID.Text;

        cmd = new OleDbCommand(updateQuery, con);
        cmd.ExecuteNonQuery();

        LabelStatus.Text = "Data Updated with ID= " + TextBoxID.Text;

        retrieveData();
    }
    
    //delete button
    protected void ButtonDelete_Click(object sender, EventArgs e)
    {
        con = new OleDbConnection(" Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:/a coding/NET using C#/ASP.Net using C#/ADO.Net/Emp.mdb ");
        con.Open();

        String deleteQuery = "";
        deleteQuery = " delete from Employee where ID="+TextBoxID.Text;

        cmd = new OleDbCommand(deleteQuery, con);
        cmd.ExecuteNonQuery();

        LabelStatus.Text = "Data Deleted with ID= "+TextBoxID.Text;

        retrieveData();
    }
}
