using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted 
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the stock to deleted from the session object
        ProductID = Convert.ToInt32(Session["ProductID"]);
    }

    protected void BtnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the stock collection class
        clsStockCollection StockBook = new clsStockCollection();
        //find the record to delete 
        StockBook.ThisStock.Find(ProductID);
        //delete the record 
        StockBook.Delete();
        //redirect back to the main page 
        Response.Redirect("StockList.aspx");

    }

    protected void BtnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page 
        Response.Redirect("StockList.aspx");
    }
}