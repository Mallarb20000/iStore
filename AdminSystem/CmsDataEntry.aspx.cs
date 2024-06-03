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
    protected void Page_Load(object sender, EventArgs e)
    {



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
        Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded);
        if (Error == "")
        {
            // capture the ProductName
            aCustomer.CustomerName = CustomerName;
            //capture the ProductDescription
            aCustomer.DateAdded = Convert.ToDateTime(DateTime.Now);
            //capture the ProductPrice
            aCustomer.CustomerEmail = CustomerEmail;
            //capture the ProductQuantity
            aCustomer.CustomerPassword = CustomerPassword;
            //store the stock in the session object
            Session["aCustomer"] = aCustomer;
            //navigate to the Stock Detail View  page
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