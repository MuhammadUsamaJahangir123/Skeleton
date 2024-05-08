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
        clsCustomer AnCustomer = new clsCustomer();

        AnCustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //capture the customer first name
        AnCustomer.FirstName = txtFirstName.Text;
        //capture the customer last name
        AnCustomer.LastName = txtLastName.Text;
        //capture the customer Email
        AnCustomer.Email = txtEmail.Text;
        //capture the date
        AnCustomer.DateJoined = Convert.ToDateTime(DateTime.Now);
        //capture if the subscribed
        AnCustomer.Subscribe = chkSubscribe.Checked;
        Session["AnCustomer"] = AnCustomer;
        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");

    }

    protected void txtCustomerID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtFirstName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtLastName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtEmail_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtJoinedDate_TextChanged(object sender, EventArgs e)
    {

    }

    protected void chkSubscribe_CheckedChanged(object sender, EventArgs e)
    {

    }
}