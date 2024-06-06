using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the city
        string Town = txtcity.Text;
        //capture the date added
        string DateAdded = txtdate.Text;
        //capture order status
        string OrderStatus = txtorderstat.Text;
        //capture the customer id
        string CustomerID = txtcustomerid.Text;
        // variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(Town, DateAdded, OrderStatus, CustomerID);
        if (Error == "")
        {
            //capture the city
            AnOrder.Town = Town;
            //capture the date added
            AnOrder.DateAdded = Convert.ToDateTime(DateAdded);
            //capture the orderstatus
            AnOrder.OrderStatus = OrderStatus;
            // capture the customerID
            AnOrder.CustomerID = Convert.ToInt32(CustomerID);
            //store the Order in the session object
            Session["AnOrder"]= AnOrder;
            //navigate to view page
            Response.Redirect("OrderViewer.aspx");
        }
        else
        {
            //display the erro message
            lblError.Text = Error;
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        //create an instance of the order class
        clsOrder AnOrder = new clsOrder();
        //create a variable to store the primary key
        Int32 OrderID;
        //create a variable to store the result of ther find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderID = Convert.ToInt32(txtorderid.Text);
        //find the record
        Found = AnOrder.Find(OrderID);
        // if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtcity.Text = AnOrder.Town;
            txtdate.Text = AnOrder.DateAdded.ToString();
        }
    }
}