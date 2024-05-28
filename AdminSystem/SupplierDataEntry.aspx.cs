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
        //capture supplier Id
        string supplierId = txtSupplierId.Text;
        //capture name
        string supplierName = txtSupplierName.Text; 
        //capture date
        string supplierDate = txtSupplierDAte.Text;
        //capture contact
        string supplierContact = txtSupplierContact.Text;
        //Capture active check box
        string supplierActivity = chkActivity.Text;
        //Capture postcode
        string supplierPostCode = txtSupplierPostCode.Text;
        //Capture Shipping Time
        string supplierShippingTime = txtSupplierShippingTime.Text;
        //variable to store any error messages
        string Error = "";
        //validate data
        Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
        if (Error == "")


        {

            //capture Name
            ASupplier.SupplierName = txtSupplierName.Text;
            //capture supplier Id
            ASupplier.SupplierId = Convert.ToInt32(txtSupplierId.Text);
            //Capture the date they joined
            ASupplier.SupplierDate = Convert.ToDateTime(supplierDate);
            //Capture their contact details
            ASupplier.SupplierContact = txtSupplierContact.Text;
            //Capture active check box
            ASupplier.SupplierActivity = chkActivity.Checked;
            //Capture the postcode
            ASupplier.SupplierPostCode = txtSupplierPostCode.Text;
            //Capture the shipping time
            ASupplier.SupplierShippingTime = Convert.ToInt32(supplierShippingTime);
            clsSupplierCollection SupplierList = new clsSupplierCollection();
            SupplierList.ThisSupplier = ASupplier;
            SupplierList.Add();
            Response.Redirect("SupplierList.aspx");


            //store the Values
            Session["ASupplier"] = ASupplier;
            //Navigate to the view page
            Response.Redirect("SupplierViewer.aspx");



        }
        else
        {
            //display error message 
            lblError.Text = Error;
        }
    }
    protected void txtSupplierId_TextChanged(object sender, EventArgs e) { }
    protected void txtSupplierName_TextChanged(object sender, EventArgs e) { }
    protected void txtContactInfo_TextChanged(object sender, EventArgs e) { }
    protected void txtDateAdded_TextChanged(object sender, EventArgs e) { }
    protected void txtActive_TextChanged(object sender, EventArgs e) { }
    protected void txtSupplierShippingTime_TextChanged(object sender, EventArgs e) { }
    protected void txtSupplierPostCode_TextChanged(object sender, EventArgs e) { }



    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)

    {
        //new instance of supplier class
        clsSupplier ASupplier = new clsSupplier();
        //Create a variable to store primary key
        Int32 SupplierId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by user
        SupplierId = Convert.ToInt32(txtSupplierId.Text);
        //find the record
        Found = ASupplier.Find(SupplierId);
        //if found
        if (Found == true)
        {
            //display the values of the property in the form
            txtSupplierName.Text = ASupplier.SupplierName;
            txtSupplierContact.Text = ASupplier.SupplierContact;
            txtSupplierDAte.Text = ASupplier.SupplierDate.ToString();
            chkActivity.Checked = ASupplier.SupplierActivity;
            txtSupplierId.Text = ASupplier.SupplierId.ToString();
            


        }

    }




    protected void btnFind_Click1(object sender, EventArgs e)
    {
        //new instance of supplier class
        clsSupplier ASupplier = new clsSupplier();
        //Create a variable to store primary key
        Int32 SupplierId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by user
        SupplierId = Convert.ToInt32(txtSupplierId.Text);
        //find the record
        Found = ASupplier.Find(SupplierId);
        //if found
        if (Found == true)
        {
            //display the values of the property in the form
            txtSupplierName.Text = ASupplier.SupplierName;
            txtSupplierContact.Text = ASupplier.SupplierContact;
            txtSupplierDAte.Text = ASupplier.SupplierDate.ToString();
            chkActivity.Checked = ASupplier.SupplierActivity;
            txtSupplierId.Text = ASupplier.SupplierId.ToString();
            txtSupplierPostCode.Text = ASupplier.SupplierPostCode;
            txtSupplierShippingTime.Text = ASupplier.SupplierShippingTime.ToString();



        }

    }
}