using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ManageSupplier : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["SupplierId"] != null)
        {
            lblWelcome.Text = "Welcome, " + Session["SupplierName"];
            if (!IsPostBack)
            {
                LoadSupplierDetails((int)Session["SupplierId"]);
            }
        }
        else
        {
            Response.Redirect("LoginSupplier.aspx");
        }
    }

    protected void LoadSupplierDetails(int supplierId)
    {
        ClsSupplier supplier = new ClsSupplier();
        if (supplier.Find(supplierId))
        {
            txtSupplierName.Text = supplier.SupplierName;
            txtContactName.Text = supplier.ContactName;
            txtContactEmail.Text = supplier.ContactEmail;
            chkIsActive.Checked = supplier.IsActive;
            txtJoinDate.Text = supplier.JoinDate.ToString("yyyy-MM-dd");
            txtRating.Text = supplier.Rating.ToString();
            txtPassword.Text = supplier.Password;
        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        ClsSuppliersCollection suppliersCollection = new ClsSuppliersCollection();
        ClsSupplier supplier = new ClsSupplier();

        string validationMessage = supplier.Valid(
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
            supplier.SupplierId = (int)Session["SupplierId"];
            supplier.SupplierName = txtSupplierName.Text;
            supplier.ContactName = txtContactName.Text;
            supplier.ContactEmail = txtContactEmail.Text;
            supplier.IsActive = chkIsActive.Checked;
            supplier.JoinDate = DateTime.Parse(txtJoinDate.Text);
            supplier.Rating = int.Parse(txtRating.Text);
            supplier.Password = txtPassword.Text;

            suppliersCollection.ThisSupplier = supplier;
            suppliersCollection.Update();

            lblMessage.ForeColor = System.Drawing.Color.Green;
            lblMessage.Text = "Supplier details updated successfully!";
        }
        else
        {
            lblMessage.ForeColor = System.Drawing.Color.Red;
            lblMessage.Text = validationMessage;
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        ClsSuppliersCollection suppliersCollection = new ClsSuppliersCollection();
        suppliersCollection.Delete((int)Session["SupplierId"]);

        // Clear the session and redirect to login page
        Session.Clear();
        Response.Redirect("LoginSupplier.aspx");
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        // Clear the session and redirect to login page
        Session.Clear();
        Response.Redirect("LoginSupplier.aspx");
    }
}