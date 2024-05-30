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
}