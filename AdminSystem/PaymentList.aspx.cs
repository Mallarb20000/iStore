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
    Int32 PaymentID;
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

    protected void BtnApplyFilter_Click(object sender, EventArgs e)
    {
            //create an instance of the address object
            clsPaymentCollection AnPayment = new clsPaymentCollection(); 
            //retrieve the value of post code from the presentation layer
            AnPayment.ReportByPostCode(txtPaymentID.Text);
            //set the data source to the list of addresses in the collection
            PaymentListBox.DataSource = AnPayment.PaymentList;
            //set the name of the primary key
            PaymentListBox.DataValueField = "PaymentID"; 
            //set the name of the field to display
            PaymentListBox.DataTextField = "PostCode";
            //bind the data to the list
            PaymentListBox.DataBind();
        }

    protected void BtnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsPaymentCollection AnPayment = new clsPaymentCollection();
        //retrieve the value of post code from the presentation layer
        AnPayment.ReportByPostCode("");
        txtPaymentID.Text = "";
        //set the data source to the list of addresses in the collection
        PaymentListBox.DataSource = AnPayment.PaymentList;
        //set the name of the primary key
        PaymentListBox.DataValueField = "PaymentID";
        //set the name of the field to display
        PaymentListBox.DataTextField = "PostCode";
        //bind the data to the list
        PaymentListBox.DataBind();
    }
}