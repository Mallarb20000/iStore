using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

    protected void BtnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Payment class
        clsPayment AnPayment = new clsPayment();
        //create a variable to store the primary key
        Int32 PaymentID;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        PaymentID = Convert.ToInt32(txtPaymentID.Text); //find the record
        Found = AnPayment.Find(PaymentID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            TXTEmail.Text = AnPayment.Email;
            TXTName.Text = AnPayment.Name;
            TXTPaymentAmount.Text = AnPayment.PaymentAmount;
            TXTPostCode.Text = AnPayment.PostCode;
            TXTTransactionStutas.Text = AnPayment.TransactionStatus;
            TXTPaymentDate.Text = AnPayment.PaymentDate.ToString();
        }
    }
}