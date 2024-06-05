using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1Viewer : System.Web.UI.Page
{
    Int32 E_Id;
    protected void Page_Load(object sender, EventArgs e)
    {
        E_Id = Convert.ToInt32(Session["E_Id"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsRegisterCollection AllRegister = new clsRegisterCollection();
        AllRegister.ThisRegister.Find(E_Id);
        AllRegister.Delete();
        Response.Redirect("EMSList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("EMSList.aspx");
    }
}