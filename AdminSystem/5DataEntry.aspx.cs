﻿using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsRegister clsReg = new clsRegister();

        clsReg.username = txtUsername.Text;

        Session ["clsreg"] = clsReg;

        Response.Redirect("5List.aspx");
    }
}