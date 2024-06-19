using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnlogin_Click(object sender, EventArgs e)
    {
        // create an instance 
        clsOrderUser AnUser = new clsOrderUser();
        //create the variables
        string Username = TextBox1.Text;
        string Password = TextBox2.Text;
        Boolean Found = false;
        Username = Convert.ToString(TextBox1.Text);
        Password = Convert.ToString(TextBox2.Text);
        Found = AnUser.FindUser(Username, Password);
        if (TextBox1.Text == "")
        {
            lblError.Text = "Enter a password";
        }
        else if (Found == true)
        {
            Response.Redirect("OrderList.aspx");
        }
    }
}