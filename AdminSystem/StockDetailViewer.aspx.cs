using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new istance of clsStock
        clsStock AnStock = new clsStock();
        //get the data from the session object
        AnStock = (clsStock)Session["AnStock"];
        //disply the ProductID for this entry
        Response.Write(AnStock.ProductID);
        //disply the ProductName for this entry
        Response.Write(AnStock.ProductName);
        //disply the ProductDescription for this entry
        Response.Write(AnStock.ProductDescription);
        //disply the ProductPrice for this entry
        Response.Write(AnStock.ProductPrice);
        //disply the ProductQuantity for this entry
        Response.Write(AnStock.ProductQuantity);
        //disply the ProductImg for this entry
        Response.Write(AnStock.ProductImg);



    }
}