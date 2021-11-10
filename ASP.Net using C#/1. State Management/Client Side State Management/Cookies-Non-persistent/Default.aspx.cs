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
    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        HttpCookie cookieobj1 = new HttpCookie("c");
        cookieobj1["Name"] = NameTextBox.Text;
        cookieobj1["Address"] = AddressTextBox.Text;

        Response.Cookies.Add(cookieobj1);
        Response.Redirect("Page2.aspx");
    }
}
