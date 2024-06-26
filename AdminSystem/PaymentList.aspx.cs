﻿using System;
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
        // Create an instance of the payment collection object
        clsPaymentCollection paymentCollection = new clsPaymentCollection();

        // Set the data source to the list of all payments in the collection
        PaymentListBox.DataSource = paymentCollection.PaymentList;

        // Set the name of the primary key
        PaymentListBox.DataValueField = "PaymentID";

        // Set the name of the field to display
        PaymentListBox.DataTextField = "PostCode";

        // Bind the data to the list
        PaymentListBox.DataBind();
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
        if (PaymentListBox.SelectedIndex != -1)
        {
            PaymentID = Convert.ToInt32(PaymentListBox.SelectedIndex);
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
        try
        {
            // Retrieve the value of post code from the presentation layer
            string postCode = txtPostCode.Text.Trim();

            if (!string.IsNullOrEmpty(postCode))
            {
                // Create an instance of the payment collection object
                clsPaymentCollection paymentCollection = new clsPaymentCollection();

                // Apply the filter using the post code
                paymentCollection.Filter(postCode);

                // Check if any payments match the filter
                if (paymentCollection.PaymentList.Count > 0)
                {
                    // Set the data source to the list of payments in the collection
                    PaymentListBox.DataSource = paymentCollection.PaymentList;

                    // Set the name of the primary key
                    PaymentListBox.DataValueField = "PaymentID";

                    // Set the name of the field to display
                    PaymentListBox.DataTextField = "PostCode";

                    // Bind the data to the list
                    PaymentListBox.DataBind();
                }
                else
                {
                    // Handle the case where no payments match the filter
                    PaymentListBox.DataSource = null;
                    PaymentListBox.DataBind();
                    // Optionally, display a message to the user
                    lblMessage.Text = "No payments found for the specified post code.";
                }
            }
            else
            {
                // Handle the case where the post code input is empty
                lblMessage.Text = "Please enter a post code to filter.";
            }
        }
        catch (Exception ex)
        {
            // Handle any potential exceptions
            lblMessage.Text = "An error occurred: " + ex.Message;
        }
    }

    protected void BtnClearFilter_Click(object sender, EventArgs e)
    {
        // Create an instance of the payment collection object
        clsPaymentCollection paymentCollection = new clsPaymentCollection();

        // Clear the filter by retrieving all payments (assuming an empty string will return all items)
        paymentCollection.Filter("");

        // Clear the text in the post code text box
        txtPostCode.Text = "";

        // Set the data source to the full list of payments in the collection
        PaymentListBox.DataSource = paymentCollection.PaymentList;

        // Set the name of the primary key
        PaymentListBox.DataValueField = "PaymentID";

        // Set the name of the field to display
        PaymentListBox.DataTextField = "PostCode";

        // Bind the data to the list
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
    protected void BtnBackToMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("PaymentManagementSystem.aspx");
    }
}