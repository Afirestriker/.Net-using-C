using System;
using System.Collections;
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

public partial class HomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String PersonName = Request.QueryString["UserName"];
        Response.Write("WELCOME " + PersonName);

        //Or can directly write as:
        // Response.Write("Welcome " + Request.QueryString["UserName"]);
    }
}
