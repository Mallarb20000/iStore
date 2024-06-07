using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsTstStockUser AnUser = new clsTstStockUser();
        string UserName = TextBox1.Text;
        string Password = TextBox2.Text;
        Boolean Found = false;
        UserName = Convert.ToString(TextBox1.Text);
        Password = Convert.ToString(TextBox2.Text);
        Found = AnUser.FindUser(UserName, Password);
        Session["AnUser"] = AnUser;
        Response.Redirect("StockList.aspx");

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}