using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
   
        clsSupplier ASupplier = new clsSupplier();
        //capture Name
        ASupplier.SupplierName = txtSupplierName.Text;
        //capture supplier Id
        ASupplier.SupplierId = Convert.ToInt32(txtSupplierId.Text);
        //Capture the date they joined
        ASupplier.DateAdded = Convert.ToDateTime(DateTime.Now);
        //Capture their contact details
        ASupplier.ContactInfo = txtSupplierContact.Text;
        //Capture active check box
        ASupplier.Active = chkActivity.Checked;


        //store the Values
        Session["ASupplier"] = ASupplier;
        //Navigate to the view page
        Response.Redirect("SupplierViewer.aspx");



    }
    protected void txtSupplierId_TextChanged(object sender, EventArgs e){}
    protected void txtSupplierName_TextChanged(object sender, EventArgs e) { }
    protected void txtContactInfo_TextChanged(object sender, EventArgs e) { }
    protected void txtDateAdded_TextChanged(object sender, EventArgs e) { }
    protected void txtActive_TextChanged(object sender, EventArgs e) { }


    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}