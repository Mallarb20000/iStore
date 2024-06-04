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

    //variable to store the primary key eith page level scope
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the stock to procesed 
        ProductID = Convert.ToInt32(Session["ProductId"]);
        if (IsPostBack ==false)
        {
            //if this is the not a new record 
            if (ProductID != -1)
            {
                //display the current data for the record
                DisplayStock();
            }
        }

    }


    void DisplayStock()
    {
        //create an istance of the stock book
        clsStockCollection StockBook = new clsStockCollection();
        //find the record to update 
        StockBook.ThisStock.Find(ProductID);
        //display the data for the record 
        TxtProductID.Text = StockBook.ThisStock.ProductID.ToString();
        TxtProductName.Text = StockBook.ThisStock.ProductName;
        TxtDescription.Text = StockBook.ThisStock.ProductDescription;
        TxtPrice.Text = StockBook.ThisStock.ProductPrice.ToString();
        TxtQuantity.Text = StockBook.ThisStock.ProductQuantity.ToString();
        //ImgProduct.FileName = StockBook.ThisStock.ProductImg;
        chkActive.Checked = StockBook.ThisStock.Active;
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
            //capture the productid
            AnStock.ProductID = ProductID;
            // capture the ProductName
            AnStock.ProductName = ProductName;
            //capture the ProductDescription
            AnStock.ProductDescription = ProductDescription;
            //capture the ProductPrice
            AnStock.ProductPrice = Convert.ToInt32(ProductPrice);
            //capture the ProductQuantity
            AnStock.ProductQuantity = Convert.ToInt32(ProductQuantity);
            //capture the ProductImg
            AnStock.ProductImg = ProductImg;
            //capture Active
            AnStock.Active = chkActive.Checked;
            //create the new instance of the Stock Collection
            clsStockCollection StockList = new clsStockCollection();
            
            //if this is a new record i.e. Productid = -1 then add the data 
            if (ProductID == -1)
            {
                //set the ThisStock property
                StockList.ThisStock = AnStock;
                //add the new record
               StockList.Add();

            }
            
            else
            {
                //find the record to update 
                StockList.ThisStock.Find(ProductID);
                //set the ThisStock property
                StockList.ThisStock = AnStock;
                //Update teh record
                StockList.Update(); 
            }
            //redirect back to the list page 
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