﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32("OrderID");
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrderCollection OrderList = new clsOrderCollection();
       OrderList.ThisOrder.Find(OrderID);
        OrderList.Delete();
        Response.Redirect("OrderList.aspx");
    }

    protected void BtnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }
}