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

public partial class _1_List : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack==false)
        {
            //update the list box
            DisplayCustomers();
        }
    }
    void DisplayCustomers()
    {
        clsCmsCollection Customers = new clsCmsCollection();
        lstCustomersList.DataSource= Customers.CustomerList;
        lstCustomersList.DataValueField = "CustomerId";
        lstCustomersList.DataValueField = "PostCode";
        lstCustomersList.DataBind();    
    }


    protected void lstCustomersList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}