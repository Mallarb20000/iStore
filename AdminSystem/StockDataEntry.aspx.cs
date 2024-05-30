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


    protected void BtnOK_Click1(object sender, EventArgs e)
    {
        //create a new istance of clsStock
        clsStock AnStock = new clsStock();
        // capture the ProductName
        string ProductName = TxtProductName.Text;
        //capture the ProductDescription
        string ProductDescription = TxtDescription.Text;
        //capture the ProductPrice
        string ProductPrice = TxtPrice.Text;
        //capture the ProductQuantity
        string ProductQuantity = TxtQuantity.Text;
        // capture the ProductImg
        string ProductImg = ImgProduct.FileName;
        //capture Active check box 
        string Active = chkActive.Text;
        //variable to store any error message 
        string Error = "";
        //validate the data 
        Error = AnStock.Valid(ProductName, ProductPrice, ProductQuantity, ProductDescription);
        if (Error == "")
        {
            // capture the ProductName
            AnStock.ProductName = ProductName;
            //capture the ProductDescription
            AnStock.ProductDescription = ProductDescription;
            //capture the ProductPrice
            AnStock.ProductPrice = Convert.ToInt32(ProductPrice);
            //capture the ProductQuantity
            AnStock.ProductQuantity = Convert.ToInt32(ProductQuantity);
            //store the stock in the session object
            Session["AnStock"] = AnStock;
            //navigate to the Stock Detail View  page
            Response.Redirect("StockList.aspx");

        }


        else
        {

            //display the error message 
            lblError.Text = Error;
        }
        
    }


    protected void BtnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the stock class
        clsStock AnStock = new clsStock();
        //create a variable to store the primary key
        Int32 ProductID;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key enteed by the user
        ProductID = Convert.ToInt32(TxtProductID.Text);
        //find the record
        Found = AnStock.Find(ProductID);
        //if found
        if (Found == true)
        {
            //display the values of the propertis in the form
            TxtProductID.Text = AnStock.ProductID.ToString();
            TxtProductName.Text = AnStock.ProductName;
            TxtDescription.Text = AnStock.ProductDescription;
            TxtPrice.Text = AnStock.ProductPrice.ToString();
            TxtQuantity.Text = AnStock.ProductQuantity.ToString();
           // ImgProduct.FileName = AnStock.ProductImg;
            //chkActive.Checked = AnStock.Active;
        }
    }
}