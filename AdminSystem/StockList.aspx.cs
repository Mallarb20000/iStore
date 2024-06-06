using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time 
        if (IsPostBack == false)
        {

            //upated the list box
            DisplayStocks();



        }
    }
        void DisplayStocks()
        {
            //create an istance of the Address collection
            clsStockCollection Stocks = new clsStockCollection();
            //set the data source to list of stocks in the collection
            lstStockList.DataSource = Stocks.StockList;
            //set the name of the primary key
            lstStockList.DataValueField = "ProductID";
            //set the data field to display
            lstStockList.DataTextField = "ProductName";
            //bind the data to the list 
            lstStockList.DataBind();

        }



    protected void lstStockList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record 
        Session["ProductID"] = -1;
        //redirect to the data entry page 
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //get the primary key valuse of the record to be edited 
        Int32 ProductID;
        //if the record has been selected from the list
        if (lstStockList.SelectedIndex != -1) 
        {
        //GET THE PRIMARY KEY VALUE OF THE RECORD TO BE EDITED 
        ProductID = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object 
            Session["ProductID"] = ProductID;
            //redirect to the edit page 
            Response.Redirect("StockDataEntry.aspx");
        }
        else  //if no record has been selected
        {
            LblError1.Text = "Please select a record from the list to edit";
        }

    }

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        //get the primary key valuse of the record to be deleted
        Int32 ProductID;
        //if the record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //GET THE PRIMARY KEY VALUE OF THE RECORD TO BE DELETED
            ProductID = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object 
            Session["ProductID"] = ProductID;
            //redirect to the delete page 
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else  //if no record has been selected
        {
            //display an error message 
            LblError1.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        {
            clsStockCollection  AnStock = new clsStockCollection();
           AnStock.ReportByProductName(txtFilter.Text);
            lstStockList.DataSource = AnStock.StockList;
            lstStockList.DataValueField = "ProductID";
            lstStockList.DataTextField = "ProductName";
            lstStockList.DataBind();
        }

    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        {
            clsStockCollection AnStock = new clsStockCollection();
            AnStock.ReportByProductName("");
            txtFilter.Text = "";
            lstStockList.DataSource = AnStock.StockList;
            lstStockList.DataValueField = "ProductID";
            lstStockList.DataTextField = "ProductName";
            lstStockList.DataBind();
        }

    }




}