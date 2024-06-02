using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_EMSProfile : System.Web.UI.Page
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
            Timestamp.Text = Aregister.Timestamp.ToShortDateString();
        }
    }

   

    protected void btnOK_Click1(object sender, EventArgs e)
    {
        clsRegister Aregister = new clsRegister();

        //capture and vaidate the data first
        string Username = txtUsername.Text;
        string Name = txtName.Text;
        string Salary = txtSalary.Text;
        string Trained = cbTrained.Text;
        string timestamp = Timestamp.Text;

        string Error = "";
        Error = Aregister.Valid(Username, Name, Salary, Trained,timestamp);
        if (Error =="")
        {
            //Capture data from the text boxes
            Aregister.Username = Username;
            Aregister.Name = txtfname.Text;
            Aregister.Salary = Convert.ToInt32(txtSalary.Text);
            Aregister.Trained = cbTrained.Checked;
            Aregister.Timestamp = Convert.ToDateTime(Timestamp.Text);

            //store the data in the session object
            Session["ARegister"] = Aregister;
            Response.Redirect("EMSRegister.aspx");
        }
        else
        {
            //displaying error
            lblError.Text = Error;
        }
        


    }

    
}