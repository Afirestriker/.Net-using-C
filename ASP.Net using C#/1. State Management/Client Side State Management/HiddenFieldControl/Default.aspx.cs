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
    int c;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //on click button click
    protected void Button1_Click(object sender, EventArgs e)
    {
        c = Convert.ToInt16(HiddenField1.Value);  //OR, c = int.Parse(HiddenField1.Value);
        c++;
        HiddenField1.Value = c.ToString();

        Response.Write("Click countt: " + c);
    }
}
