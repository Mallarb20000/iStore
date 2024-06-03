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
        //if this is the first time the page is displayed
        PaymentID = Convert.ToInt32(Session[PaymentID]);
        if (IsPostBack == false)
        {
            if (PaymentID != -1)
            {
                //update the listbox
                DisplayPayments();
            }
        }
    }

    protected void BtnFind_Click(object sender, EventArgs e)
    {

    }

    void DisplayPayments()
    {
        clsPaymentCollection Payments = new clsPaymentCollection();
        PaymentListBox.DataSource = Payments.PaymentList;
        PaymentListBox.DataValueField = "PostCode";
        PaymentListBox.DataTextField = "PostCode";
        PaymentListBox.DataBind();
    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        Session["PaymentID"] = -1;
        Response.Redirect("PaymentDataEntry.aspx");
    }

    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        Session["PaymentID"] = PaymentID;
        Response.Redirect("PaymentDataEntry.aspx");
    }
}