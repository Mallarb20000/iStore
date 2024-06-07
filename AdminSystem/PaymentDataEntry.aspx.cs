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

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 PaymentID;
    protected void Page_Load(object sender, EventArgs e)
    {
        PaymentID = Convert.ToInt32(Session["PaymentID"]);
        if(IsPostBack == false)
        {
            if (PaymentID != -1)
            {
                DisplayPayment();
            }
        }
    }



    protected void BtnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsPayment
        clsPayment AnPayment = new clsPayment();
        //capture the Name
        string Name = TXTName.Text;
        //capture the Email
        string Email = TXTEmail.Text;
        //capture the PaymentAmount
        string PaymentAmount = TXTPaymentAmount.Text;
        //capture the Post Code
        string PostCode = TXTPostCode.Text;
        //capture the PaymentDate
        string PaymentDate = TXTPaymentDate.Text;
        //capture the TranscationStatus
        string TransactionStatus = TXTTransactionStutas.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus); if (Error == "")
            if (Error == "")
            {
                AnPayment.PaymentID = PaymentID; //DON'T MISS THIS BIT!!!!!!!
                AnPayment.Name = Name;
                AnPayment.Email = Email;
                AnPayment.TransactionStatus = TransactionStatus;
                AnPayment.PostCode = PostCode;
                AnPayment.PaymentAmount = PaymentAmount;
                AnPayment.PaymentDate = Convert.ToDateTime(PaymentDate);
                clsPaymentCollection PaymentList = new clsPaymentCollection();

                if (PaymentID != -1)
                {
                    PaymentList.Name = AnPayment;
                    PaymentList.Add();
                }
                else
                {
                    PaymentList.Name.Find(PaymentID);
                    PaymentList.Name = AnPayment;
                    PaymentList.Update();
                }
                //navigate to the list page
                Response.Redirect("PaymentList.aspx");
            }
            else
            {
                //display the error message
                lblError.Text = Error;
            }
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

    void DisplayPayment()
    {
        //create an instance of the Payment List
        clsPaymentCollection PaymentList = new clsPaymentCollection();
        //find the record to update
        PaymentList.Name.Find(PaymentID);
        //display the data for the record
        TXTEmail.Text = PaymentList.Name.Email.ToString();
        TXTName.Text = PaymentList.Name.Name.ToString();
        TXTPaymentAmount.Text = PaymentList.Name.PaymentAmount.ToString();
        TXTPaymentDate.Text = PaymentList.Name.PaymentDate.ToString();
        TXTPostCode.Text = PaymentList.Name.PostCode.ToString();
        TXTTransactionStutas.Text = PaymentList.Name.TransactionStatus.ToString();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("PaymentList.aspx");
    }
}