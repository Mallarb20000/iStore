using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegSuppliers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnAddSupplier_Click(object sender, EventArgs e)
    {
        ClsSuppliersCollection suppliersCollection = new ClsSuppliersCollection();
        ClsSupplier newSupplier = new ClsSupplier();

        string validationMessage = newSupplier.Valid(
            txtSupplierName.Text,
            txtContactName.Text,
            txtContactEmail.Text,
            chkIsActive.Checked.ToString(),
            txtJoinDate.Text,
            txtRating.Text,
            txtPassword.Text
        );

        if (string.IsNullOrEmpty(validationMessage))
        {
            newSupplier.SupplierName = txtSupplierName.Text;
            newSupplier.ContactName = txtContactName.Text;
            newSupplier.ContactEmail = txtContactEmail.Text;
            newSupplier.IsActive = chkIsActive.Checked;
            newSupplier.JoinDate = DateTime.Parse(txtJoinDate.Text);
            newSupplier.Rating = int.Parse(txtRating.Text);
            newSupplier.Password = txtPassword.Text;

            suppliersCollection.ThisSupplier = newSupplier;
            suppliersCollection.Add();

            lblMessage.ForeColor = System.Drawing.Color.Green;
            lblMessage.Text = "Supplier added successfully!";
            ClearForm();
        }
        else
        {
            lblMessage.ForeColor = System.Drawing.Color.Red;
            lblMessage.Text = validationMessage;
        }
    }

    private void ClearForm()
    {
        txtSupplierName.Text = string.Empty;
        txtContactName.Text = string.Empty;
        txtContactEmail.Text = string.Empty;
        chkIsActive.Checked = false;
        txtJoinDate.Text = string.Empty;
        txtRating.Text = string.Empty;
        txtPassword.Text = string.Empty;
    }
    protected void btnOpenLogin_Click(object sender, EventArgs e)
    {
        // Clear the session and redirect to login page

        Response.Redirect("LoginSupplier.aspx");
    }
}