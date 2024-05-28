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
}