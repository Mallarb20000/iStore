using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using Testing3;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsPayment
        clsPayment AnPayment = new clsPayment();
        //get the data from the session object
        AnPayment = (clsPayment)Session["AnPayment"];
        //display the Transaction Status for the entry
        Response.Write(AnPayment.TransactionStatus);
    }

    protected void BtnFind_Click(object sender, EventArgs e)
    {

    }
}