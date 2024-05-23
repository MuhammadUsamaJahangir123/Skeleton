using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 customerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        customerID = Convert.ToInt32(Session["customerID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the customer collection class
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to delete 
        CustomerBook.ThisCustomer.Find(customerID);
        //delete the record 
        CustomerBook.Delete();
        //redirect back to the main page 
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("CustomerList.aspx");
    }
}