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
    string c;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonCountt_Click(object sender, EventArgs e)
    {
        int countt=0;

        if (ViewState["c"] == null)
        {
            c = c + 1;   
        }
        else
        {
            countt = (int)(ViewState["c"]) + 1;
        }
        ViewState["c"] = countt;

        Response.Write("<br/>Countt: " + countt);
        
    }
}
