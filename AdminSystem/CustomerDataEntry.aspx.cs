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

        AnCustomer.customerID = Convert.ToInt32(txtCustomerID.Text);
        //capture the customer first name
        AnCustomer.firstName = txtFirstName.Text;
        //capture the customer last name
        AnCustomer.lastName = txtLastName.Text;
        //capture the customer Email
        AnCustomer.email = txtEmail.Text;
        //capture the date
        AnCustomer.joinedDate = Convert.ToDateTime(DateTime.Now);
        //capture if the subscribed
        AnCustomer.subscribe = chkSubscribe.Checked;
        //capture the phone no
        AnCustomer.PhoneNo = txtPhoneNo.Text;

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

    protected void txtPhoneNo_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsCustomer AnCustomer = new clsCustomer();
        //create a variable to store the primary key
        Int32 customerID;
        //create a varaible to store the results of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        customerID =Convert.ToInt32(txtCustomerID.Text);
        //find the record 
        Found = AnCustomer.Find(customerID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtFirstName.Text = AnCustomer.firstName;
            txtLastName.Text = AnCustomer.lastName;
            txtEmail.Text = AnCustomer.email;   
            txtPhoneNo.Text = AnCustomer.PhoneNo;
            txtJoinedDate.Text = AnCustomer.joinedDate.ToString();
            chkSubscribe.Checked = AnCustomer.subscribe;
        }
    }
}