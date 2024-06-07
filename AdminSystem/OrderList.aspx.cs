using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    // variable to store the primary key
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address
        OrderID = Convert.ToInt32(Session["OrderID"]);

        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //if this is the not a new record
            if (OrderID != -1)
            {
                //display current data
                DisplayOrders();
            }
            
        }
    }

    void DisplayOrders()
    {
        //create an instance of the address collection
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find the record to update
        OrderBook.ThisOrder.Find(OrderID);
        lstOrderList.DataSource = OrderBook.OrderList;
        lstOrderList.DataValueField = "id";
        lstOrderList.DataTextField = "name";
        lstOrderList.DataBind();

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record
        Int32 OrderID;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record 
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the edit page
            Response.Redirect("OrderDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list";
        }
    }

    protected void btnadd_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record
        Int32 OrderID;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record 
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            //store -1 the data in the session object
            Session["OrderID"] = -1;
            //redirect to the edit page
            Response.Redirect("OrderDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the recrod to be deleted
        Int32 OrderID;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the delete page
            Response.Redirect("OrderViewer.aspx");
        }
        else //if no record has been selected
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    

    protected void BtnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsOrderCollection AnOrder = new clsOrderCollection();
        //retrieve the value of post code from the presentation layer
        AnOrder.ReportByPostCode(txtorderid.Text);
        //set the data source to the list of addresses in the collection
        lstOrderList.DataSource = AnOrder.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderID";
        //set the name of the field to display
        lstOrderList.DataTextField = "PostCode";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void BtnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsOrderCollection AnOrder = new clsOrderCollection();
        //retrieve the value of post code from the presentation layer
        AnOrder.ReportByPostCode("");
        txtorderid.Text = "";
        //set the data source to the list of addresses in the collection
        lstOrderList.DataSource = AnOrder.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderID";
        //set the name of the field to display
        lstOrderList.DataTextField = "PostCode";
        //bind the data to the list
        lstOrderList.DataBind();
    }
}