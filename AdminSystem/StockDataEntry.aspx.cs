using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void BtnAddProduct_Click1(object sender, EventArgs e)
    {
        //create a new istance of clsStock
        clsStock AnStock = new clsStock();
        // capture the ProductID
        AnStock.ProductID = TxtProductID.Text;
        // capture the ProductName
        AnStock.ProductName = TxtProductName.Text;
        //capture the ProductDescription
        AnStock.ProductDescription = TxtDescription.Text;
        //capture the ProductPrice
        AnStock.ProductPrice = Convert.ToInt32(TxtPrice.Text);
        //capture the ProductQuantity
        AnStock.ProductQuantity= Convert.ToInt32(TxtQuantity.Text);
        // capture the ProductImg
        AnStock.ProductImg = FileUploadUploadImage.FileName;
        //store the stock in the session object
        Session["AnStock"] = AnStock;
        //navigate to the Stock Detail View  page
        Response.Redirect("StockDetailViewer.aspx");
    }

}