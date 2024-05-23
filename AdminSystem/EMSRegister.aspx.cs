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
        clsRegister clsReg = new clsRegister();

        clsReg.Username = txtUsername.Text;

        Session["clsreg"] = clsReg;

        Response.Redirect("5List.aspx");
    }

    /*protected void btnFind_Click(object sender, EventArgs e)
     {
         //create instance of register
         clsRegister Aregister = new clsRegister();
         //create a variable to store the primary key
         String username;

         //create a variable to store the result of the find operation
         Boolean Found = false;

         //get the primary key entered by the user
         username = Convert.ToString(txtUsername.Text);

         //find the record
         Found = Aregister.Find(username);

         // if found
             if (Found ==true)
         {
             //display the values of the property in the form 
             txtUsername.Text = Aregister.Username;
             txtfname.Text = Aregister.Name;
             Password.Text = Aregister.Password;

         }*/



    protected void btnFind_Click(object sender, EventArgs e)
    {

    }
}