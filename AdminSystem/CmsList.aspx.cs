﻿using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class _1_List : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack==false)
        {
            //update the list box
            DisplayCustomers();
        }

        clsTstUser AnUser = new clsTstUser();
        AnUser = (clsTstUser)Session["AnUser"];
        Response.Write("Logged in as: "+AnUser.UserName);
    }
    void DisplayCustomers()
    {
        clsCmsCollection Customers = new clsCmsCollection();
        lstCustomersList.DataSource= Customers.CustomerList;
        lstCustomersList.DataValueField = "CustomerId";
        lstCustomersList.DataValueField = "PostCode";
        lstCustomersList.DataBind();    
    }


    protected void lstCustomersList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        Session["CustomerId"] = -1;
        Response.Redirect("CmsDataEntry.aspx");
    }

    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        Int32 CustomerId;
        if (lstCustomersList.SelectedIndex != -1)
        {
            CustomerId = Convert.ToInt32(lstCustomersList.SelectedValue);
            Session["CustomerId"]= CustomerId;
            Response.Redirect("CmsDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a ecord from the list to edit";
        }
    }

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        Int32 CustomerId;
        if(lstCustomersList.SelectedIndex != -1)
        {
            CustomerId = Convert.ToInt32(lstCustomersList.SelectedValue);
            Session["CustomerId"] = CustomerId;
            Response.Redirect("CmsConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }

    }

    protected void BtnFltr_Click(object sender, EventArgs e)
    {
        clsCmsCollection aCustomer = new clsCmsCollection();
        aCustomer.ReportByPostCode(txtBoxPc.Text);
        lstCustomersList.DataSource = aCustomer.CustomerList;
        lstCustomersList.DataValueField = "CustomerId";
        lstCustomersList.DataTextField = "PostCode";
        lstCustomersList.DataBind();    
    }

    protected void BtnClr_Click(object sender, EventArgs e)
    {
        clsCmsCollection aCustomer = new clsCmsCollection();
        aCustomer.ReportByPostCode("");
        txtBoxPc.Text = "";
        lstCustomersList.DataSource = aCustomer.CustomerList;
        lstCustomersList.DataValueField = "CustomerId";
        lstCustomersList.DataTextField = "PostCode";
        lstCustomersList.DataBind();
    }

    protected void BtnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}