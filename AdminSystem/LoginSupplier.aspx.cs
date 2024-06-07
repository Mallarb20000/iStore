using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoginSupplier : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string contactEmail = txtContactEmail.Text;
        string password = txtPassword.Text;
        ClsSuppliersCollection suppliersCollection = new ClsSuppliersCollection();

        if (suppliersCollection.IsEmailRegistered(contactEmail))
        {
            ClsSupplier supplier = suppliersCollection.SuppliersList.Find(s => s.ContactEmail == contactEmail && s.Password == password);
            if (supplier != null)
            {
                // Store supplier ID in session
                Session["SupplierId"] = supplier.SupplierId;
                Session["SupplierName"] = supplier.SupplierName;
                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Login successful!";
                // Redirect to ManageSupplier page
                Response.Redirect("ManageSupplier.aspx");
            }
            else
            {
                lblMessage.Text = "Invalid email or password.";
            }
        }
        else
        {
            lblMessage.Text = "Email is not registered.";
        }
    }
    protected void btnOpenSignup_Click(object sender, EventArgs e)
    {
        // Clear the session and redirect to login page

        Response.Redirect("RegSuppliers.aspx");
    }
}