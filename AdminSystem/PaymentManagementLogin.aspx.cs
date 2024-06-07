using System;
using System.Collections.Generic;
using System.Drawing;
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

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the address user class
        clsPaymentUser AnUser = new clsPaymentUser();
        //create the variables to store the username and password
        string Username = txtUsername.Text;
        string Password = txtPassword.Text;
        //create a variable to store the result of the find user operation
        Boolean Found = false;
        //get the username entered by the user
        Username = Convert.ToString(txtUsername.Text);
        //get the password entered by the user
        Password = Convert.ToString(txtPassword.Text);
        //find the record
        Found = AnUser.FindUser(Username, Password);
        //if username and/or password is empty
        if (txtUsername.Text == "")
        {
            //record the error
            lblError.Text = "Enter a username";
        }
        else if (txtPassword.Text == "")
        {
            //record the error
            lblError.Text = "Enter a Password";
        }

        //if found
        else if (Found == true)
        {
            //redirect to the List Page
            Response.Redirect("PaymentList.aspx");
        }

        else if (Found == false)
        {
            //record the error
            lblError.Text = "Login details are incorrect. Please try again ";
        }
    }
}