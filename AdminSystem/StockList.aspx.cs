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
}