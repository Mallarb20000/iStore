using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class _1_DataEntry : System.Web.UI.Page
{
    public int CustomerId { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            if (CustomerId != -1)
            {
                DisplayCustomers();
            }
        }


    }
    void DisplayCustomers()
    {
        clsCmsCollection CustomerBook = new clsCmsCollection();
        CustomerBook.ThisCustomer.Find(CustomerId);
        TxtCustomerId.Text=CustomerBook.ThisCustomer.CustomerId.ToString();
        TxtDateAdded.Text = CustomerBook.ThisCustomer.DateAdded.ToString();
        TxtCustomerName.Text = CustomerBook.ThisCustomer.CustomerName;
        TxtCustomerEmail.Text = CustomerBook.ThisCustomer.CustomerEmail;
        TxtCustomerPassword.Text = CustomerBook.ThisCustomer.CustomerPassword;
        TxtPostCode.Text = CustomerBook.ThisCustomer.PostCode;
        ChkActive.Checked = CustomerBook.ThisCustomer.Membership;

    }
    protected void TxtCustomerEmail_TextChanged(object sender, EventArgs e)
    {
        // Your event handler logic here
    }
    protected void TxtPostCode_TextChanged(object sender, EventArgs e)
    {
        // Your event handler logic here
    }
    protected void ChkActive_CheckedChanged(object sender, EventArgs e)
    {
        // Your event handler logic here
    }
    protected void BtnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the class we want to test
        clsCms aCustomer = new clsCms();
        Int32 CustomerId;
        // Create a boolean variable to store the results of the validation
        Boolean Found = false;
        // get the primary key entered by the user
        CustomerId = Convert.ToInt32(TxtCustomerId.Text);
        // find the record
        Found = aCustomer.Find(CustomerId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form 
            TxtCustomerId.Text = aCustomer.CustomerId.ToString();
            TxtDateAdded.Text = aCustomer.DateAdded.ToString();
            TxtCustomerName.Text = aCustomer.CustomerName;
            TxtCustomerEmail.Text= aCustomer.CustomerEmail;
            TxtCustomerPassword.Text = aCustomer.CustomerPassword;
            TxtPostCode.Text = aCustomer.PostCode;
            ChkActive.Checked = aCustomer.Membership;


        }
    }



    protected void BtnOk_Click(object sender, EventArgs e)
    {
        //create a new istance of class
        clsCms aCustomer = new clsCms();
        string DateAdded = TxtDateAdded.Text;
        string CustomerName = TxtCustomerName.Text;
        string CustomerEmail = TxtCustomerEmail.Text;
        string CustomerPassword = TxtCustomerPassword.Text;
        string CustomerPostCode = TxtPostCode.Text;
        string Membership = ChkActive.Text;
        //variable to store any error message 
        string Error = "";
        //validate the data 
        Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);
        if (Error == "")
        {
            aCustomer.CustomerId = CustomerId;   
            aCustomer.CustomerName = CustomerName;
            aCustomer.DateAdded = Convert.ToDateTime(DateTime.Now);
            aCustomer.CustomerEmail = CustomerEmail;
            aCustomer.CustomerPassword = CustomerPassword;
            aCustomer.PostCode = CustomerPostCode;
            aCustomer.Membership = ChkActive.Checked;
            clsCmsCollection CustomerList = new clsCmsCollection();
            // create a new instance of the class collection
           if (CustomerId == -1)
            {
                CustomerList.ThisCustomer= aCustomer;
                CustomerList.Add();
            }
           else
            {
                CustomerList.ThisCustomer.Find(CustomerId);
                CustomerList.ThisCustomer = aCustomer;  
                CustomerList.Update();
            }
            Response.Redirect("CmsList.aspx");

        }


        else
        {


            //display the error message 
            lblError.Text = Error;
            lblError.Text = "An error occurred!";

        }
    }
}