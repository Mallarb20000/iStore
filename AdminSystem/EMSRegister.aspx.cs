using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_EMSRegister : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

   

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        clsEMSuser Anuser = new clsEMSuser();
        string Username = txtUsername.Text;
        string password = Password.Text;
        Boolean Found = false;
        Username = Convert.ToString(txtUsername.Text);
        password = Convert.ToString(Password.Text);


        Found = Anuser.FindUser(Username, password);

        Session["AnUser"] = Anuser;
        if(txtUsername.Text=="")
        {
            lblError.Text = "Enter User Name";
        }

        else if(Password.Text=="")
            {
            lblError.Text = "Enter password";
        }
        else if (Found ==true)
        {
            Response.Redirect("EMSList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Login Details are Not correct. Try Again!";
        }
    }

   



    protected void btnFind_Click(object sender, EventArgs e)
    {

    }
}