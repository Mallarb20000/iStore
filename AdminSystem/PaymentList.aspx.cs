using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        if (IsPostBack == false)
        {
            //update the listbox
            DisplayPayments();
        }
        clsPaymentUser AnUser = new clsPaymentUser();
        AnUser = (clsPaymentUser)Session["AnUser"];
        Response.Write("Logged in as : " + AnUser.UserName);
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
        Int32 PaymentID;
        if(PaymentListBox.SelectedIndex != -1)
        {
            PaymentID= Convert.ToInt32(PaymentListBox.SelectedIndex);
            Session["PaymentID"] = PaymentID;
            Response.Redirect("PaymentDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
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

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the recrod to be deleted
        Int32 PaymentID;
        //if a record has been selected from the list
        if (PaymentListBox.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            PaymentID = Convert.ToInt32(PaymentListBox.SelectedValue);
            //store the data in the session object
            Session["PaymentID"] = PaymentID;
            //redirect to the delete page
            Response.Redirect("PaymentConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }
}