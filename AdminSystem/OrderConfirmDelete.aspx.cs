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

    protected void Button1_Click(object sender, EventArgs e)
    {

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