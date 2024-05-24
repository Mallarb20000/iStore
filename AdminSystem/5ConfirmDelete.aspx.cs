using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        
        //create instance of register
        clsRegister Aregister = new clsRegister();
        //create a variable to store the primary key
        Int32 E_Id;

        //create a variable to store the result of the find operation
        Boolean Found = false;

        //get the primary key entered by the user
        E_Id = Convert.ToInt32(txtE_Id.Text);

        //find the record
        Found = Aregister.Find(E_Id);

        // if found
            if (Found ==true)
        {
            //display the values of the property in the form 
            txtUsername.Text = Aregister.Username;
            txtfname.Text = Aregister.Name;
            // Password.Text = Aregister.Password;
            txtSalary.Text = Aregister.Salary.ToString();
            cbTrained.Checked = Aregister.Trained;

        }
    }
}