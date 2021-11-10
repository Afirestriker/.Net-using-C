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
    //On login button click
    protected void ButtonLogin_Click(object sender, EventArgs e)
    {
        if (TextBoxUserName.Text == "admin" && TextBoxPass.Text == "admin")
        {
            labelStatus.Text = "Valid";
            Response.Redirect("HomePage.aspx?UserName=" + TextBoxUserName.Text);
        }
        else
        {
            labelStatus.Text = "Invalid Credentials";
        }
    }
}
