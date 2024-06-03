using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    Int32 PaymentID;

    protected void Page_Load(object sender, EventArgs e)
    {
        PaymentID = Convert.ToInt32("PaymentID");
    }

    protected void BtnYes_Click(object sender, EventArgs e)
    {
        clsPaymentCollection PaymentList = new clsPaymentCollection();
        PaymentList.Name.Find(PaymentID);
        PaymentList.Delete();
        Response.Redirect("PaymentList.aspx");
    }

    protected void BtnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("PaymentList.aspx");
    }
}