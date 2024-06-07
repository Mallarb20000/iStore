using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
    }




    protected void BtnYes_Click(object sender, EventArgs e)
    {
        clsCmsCollection CustomerBook = new clsCmsCollection();
        CustomerBook.ThisCustomer.Find(CustomerId);
        CustomerBook.Delete();
        Response.Redirect("CmsList.aspx");
    }

    protected void BtnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CmsList.aspx");

    }
}