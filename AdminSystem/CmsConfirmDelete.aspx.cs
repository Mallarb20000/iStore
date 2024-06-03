using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if his is the first time the page is displayed
        if (IsPostBack==false)
        {
            //update he list box
            DisplayCustomers();
        }
    }
    void DisplayCustomers()
    {
        clsCmsCollection Customers = new clsCmsCollection();
        lstCustomersList.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomersList.DataValueField = "AddressNo";
        //det the data field to display
        lstCustomersList.DataTextField = "PostCode";
        //bind the data to the List
        lstCustomersList.DataBind();


    }

    protected void lstCustomersList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}