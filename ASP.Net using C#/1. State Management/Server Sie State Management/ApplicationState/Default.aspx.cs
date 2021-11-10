using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ClickButton_Click(object sender, EventArgs e)
    {
        Application["app1"] = Convert.ToInt16(Application["app1"])+ 1;
        //HERE, app1 is an application state key name
        //We are converting the value to int, because the result type of application state is string, but here
        //  we are doing the incrementation of number

        Label1.Text = Application["app1"].ToString();
        //Return type of label is string and hence we are converting the application key to string value.
    }
}
