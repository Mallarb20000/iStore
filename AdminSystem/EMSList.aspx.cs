using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this page is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayRegister();
        }

        clsEMSuser AnUser = new clsEMSuser();
        AnUser = (clsEMSuser)Session["AnUser"];
        Response.Write("Logged in as:" + AnUser.UserName);


    }

    void DisplayRegister()
    {
        //create a instance of the register collection
        clsRegisterCollection AllRegister = new clsRegisterCollection();    

        //set the data source to list of employee in the collection
        lstRegisterList.DataSource = AllRegister.RegisterList;
        // set the name of the primary key
        lstRegisterList.DataValueField = "E_Id";
        //set the data field to display
        lstRegisterList.DataTextField="Name";
        //bind data to the list 
        lstRegisterList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 2into the session object to indicate this a new record 
        Session["E_Id"] = -1;
        //refirect to datatentry page
        Response.Redirect("EMSProfile.aspx");
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        //primary key variable stored 
        Int32 E_Id;
        //if a record has been selected fromt the list 
        if (lstRegisterList.SelectedIndex!=-1)
        {
            //get the primary key value of the record to edit
            E_Id = Convert.ToInt32(lstRegisterList.SelectedValue);
            //store the data in the session
            Session["E_Id"] = E_Id;
            //redirect to the edit page
            Response.Redirect("EMSProfile.aspx");
        }
        else
        {
            lblError.Text="Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //primary key variable stored 
        Int32 E_Id;
        //if a record has been selected fromt the list 
        if (lstRegisterList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            E_Id = Convert.ToInt32(lstRegisterList.SelectedValue);
            //store the data in the session
            Session["E_Id"] = E_Id;
            //redirect to the edit page
            Response.Redirect("EMSConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnFilter_Click(object sender, EventArgs e)
    {
        clsRegisterCollection AllRegister = new clsRegisterCollection();

        AllRegister.Filter(txtFilter.Text);
        lstRegisterList.DataSource = AllRegister.RegisterList;
        //set the name for primary key
        lstRegisterList.DataValueField = "E_Id";
        lstRegisterList.DataTextField = "Username";
        lstRegisterList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsRegisterCollection AllRegister = new clsRegisterCollection();

        AllRegister.Filter("");
        //clear existing filter
        txtFilter.Text = "";
        lstRegisterList.DataSource = AllRegister.RegisterList;
        //set the name for primary key
        lstRegisterList.DataValueField = "E_Id";
        lstRegisterList.DataTextField = "Username";
        lstRegisterList.DataBind();
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}