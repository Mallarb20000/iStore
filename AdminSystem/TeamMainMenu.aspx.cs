using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("EMSRegister.aspx");
    }

    protected void btnstock_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockDetailViewer.aspx");
    }

    protected void BtnCms_Click(object sender, EventArgs e)
    {
        Response.Redirect("CmsViewer.aspx");
    }

    protected void btnPaymentManagementSystem_Click(object sender, EventArgs e)
    {
        Response.Redirect("PaymentManagementLogin.aspx");
    }
}