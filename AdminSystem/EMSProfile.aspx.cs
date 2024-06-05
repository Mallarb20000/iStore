using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_EMSProfile : System.Web.UI.Page
{
    Int32 E_Id;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed 
        E_Id = Convert.ToInt32(Session["E_Id"]);
        if (IsPostBack ==false)
        {
            //if this is the not a new recod
            if(E_Id !=-1)
            {
                //display the current data
                DisplayRegister();
            }
        }

    }

    void DisplayRegister()
    {
        //create a instance of the register collection
        clsRegisterCollection AllRegister = new clsRegisterCollection();
        //find record to update 
        AllRegister.ThisRegister.Find(E_Id);
        //display the data for the record
        txtUsername.Text = AllRegister.ThisRegister.Username.ToString();
        txtfname.Text = AllRegister.ThisRegister.Name.ToString();
        Password.Text = AllRegister.ThisRegister.Password.ToString();
        txtSalary.Text = AllRegister.ThisRegister.Salary.ToString();
        cbTrained.Checked = AllRegister.ThisRegister.Trained;
        Timestamp.Text = AllRegister.ThisRegister.Timestamp.ToShortDateString();
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
            Password.Text = Aregister.Password;
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
            Aregister.E_Id = E_Id;
            Aregister.Username = Username;
            Aregister.Name = txtfname.Text;
            Aregister.Password = Password.Text;
            Aregister.Salary = Convert.ToInt32(txtSalary.Text);
            Aregister.Trained = cbTrained.Checked;
            Aregister.Timestamp = Convert.ToDateTime(Timestamp.Text);

            //create a anew instance of the address collection
            clsRegisterCollection RegisterList = new clsRegisterCollection();
            
            //if this is a new record
            if (E_Id== -1)
            {
                //set the thisregister property
                RegisterList.ThisRegister = Aregister;
                //add the new record
                RegisterList.Add();
            }

            //otherwise it must be update
            else
            {
                //find the record to update
                RegisterList.ThisRegister.Find(E_Id);
                //set the ThisREgister proprty
                RegisterList.ThisRegister= Aregister;
                //update the record
                RegisterList.Update();  

            }

            
            Response.Redirect("EMSList.aspx");
        }
        else
        {
            //displaying error
            lblError.Text = Error;
        }
        


    }

    
}