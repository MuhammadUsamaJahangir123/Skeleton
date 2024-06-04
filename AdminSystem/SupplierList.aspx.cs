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
        if (IsPostBack == false)
        {
            DisplaySupplier();
        }
        clsSupplierUser AnUser = new clsSupplierUser();
        AnUser = (clsSupplierUser)Session["AnUser"];
        Response.Write("Logged in as: " + AnUser.UserName);
    }
    void DisplaySupplier()
    {
        clsSupplierCollection Supplier  = new clsSupplierCollection();
        lstSupplierList.DataSource = Supplier.SupplierList;
        lstSupplierList.DataValueField = "SupplierId";
        lstSupplierList.DataTextField = "SupplierPostCode";
        lstSupplierList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["SupplierId"] = -1;
        Response.Redirect("SupplierDataEntry.aspx");

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 SupplierId;
        if (lstSupplierList.SelectedIndex != -1)
        {
            SupplierId = Convert.ToInt32(lstSupplierList.SelectedValue);
            Session["SupplierId"] = SupplierId;
            Response.Redirect("SupplierDataEntry.aspx");

        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 SupplierId;
        if (lstSupplierList.SelectedIndex != -1)
        {
            SupplierId = Convert.ToInt32(lstSupplierList.SelectedValue);
            Session["SupplierId"] = SupplierId;
            Response.Redirect("SupplierConfirmDelete.aspx");

        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }

    }

    protected void Applybtn_Click(object sender, EventArgs e)
    {
        clsSupplierCollection ASupplier = new clsSupplierCollection();
        ASupplier.ReportByPostCode(txtFilter.Text);
        lstSupplierList.DataSource = ASupplier.SupplierList;
        lstSupplierList.DataValueField = "SupplierId";
        lstSupplierList.DataTextField = "SupplierPostCode";
        lstSupplierList.DataBind();
    }

    protected void Clearbtn_Click(object sender, EventArgs e)
    {
        clsSupplierCollection ASupplier = new clsSupplierCollection();
        ASupplier.ReportByPostCode("");
        txtFilter.Text = "";
        lstSupplierList.DataSource = ASupplier.SupplierList;
        lstSupplierList.DataValueField = "SupplierId";
        lstSupplierList.DataTextField = "SupplierPostCode";
        lstSupplierList.DataBind();

    }

    protected void btnReturnMenu_Click(object sender, EventArgs e)
    {
        //return to main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}