using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnsearch_Click(object sender, EventArgs e)
    {
        //create a new instancw of the clsOrder
        clsOrder AnOrder = new clsOrder();
        //Capture the Order search
        AnOrder.Search = Searchbox.Text;
        //store the search in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the view page
        Response.Redirect("OrderViewer.aspx");
    }

    protected void Cart_Click(object sender, EventArgs e)
    {

    }

    protected void Login_Click(object sender, EventArgs e)
    {
        //navigate to the login page
        Response.Redirect("3DataEntry.aspx");
    }

    protected void Add3_Click(object sender, EventArgs e)
    {

    }

    protected void Add2_Click(object sender, EventArgs e)
    {

    }

    protected void Button3_Click(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}