using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using Testing3;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        //create a new instance of clsPayment
        clsPayment AnPayment = new clsPayment();
        //capture the Payment Status
        AnPayment.TransactionStatus = TXTTransactionStutas.Text;
        //store the status in the bsession object
        Session["AnPayment"] = AnPayment;
        //navigate to the list page
        Response.Redirect("PaymentList.aspx");
    }
}