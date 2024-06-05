using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 customerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        customerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (customerID != -1)
            { //update the list box
                DisplayCustomers();
            }
            else
            { 
                //disables the find method and button when adding a cusomter
                txtCustomerID.Text = customerID.ToString();
                txtCustomerID.Enabled = false;
                btnFind.Enabled = false;
            }
        }
    }
    void DisplayCustomers()
    {
        //create an instance of the customer Book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to update
        CustomerBook.ThisCustomer.Find(customerID);
        //display the data for the record
        txtCustomerID.Text = CustomerBook.ThisCustomer.customerID.ToString();
        txtFirstName.Text = CustomerBook.ThisCustomer.firstName.ToString();
        txtLastName.Text = CustomerBook.ThisCustomer.lastName.ToString();
        txtEmail.Text = CustomerBook.ThisCustomer.email.ToString();
        txtPhoneNo.Text = CustomerBook.ThisCustomer.PhoneNo.ToString();
        txtJoinedDate.Text = CustomerBook.ThisCustomer.joinedDate.ToString();
        chkSubscribe.Checked = CustomerBook.ThisCustomer.subscribe;
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();

        //AnCustomer.customerID = Convert.ToInt32(txtCustomerID.Text);
        //capture the customer first name
        string firstName = txtFirstName.Text;
        //capture the customer last name
        string lastName = txtLastName.Text;
        //capture the customer Email
        string email = txtEmail.Text;
        //capture the date
        string joinedDate = txtJoinedDate.Text;
        //capture if the subscribed
        string subscribe = chkSubscribe.Text;
        //capture the phone no
        string PhoneNo = txtPhoneNo.Text;
        //Variable to store any error messages
        string Error = "";
        //Validate Data
        Error = AnCustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
        if (Error == "")
        {
            //Capture customerID
            AnCustomer.customerID = customerID;
            //Capture email
            AnCustomer.email = email;
            //Capture first Name
            AnCustomer.firstName = firstName;
            //capture last name
            AnCustomer.lastName = lastName;
            //capture phone no
            AnCustomer.PhoneNo = PhoneNo;
            //capture joineddate
            AnCustomer.joinedDate = Convert.ToDateTime(joinedDate);
            //Capture subscribe
            AnCustomer.subscribe = chkSubscribe.Checked;
            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            //if this is a new record i.e customerID = -1 then add the data
            if (customerID == -1)
            {
                //set the ThisCustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //add the new record
                CustomerList.Add();
            } // otherwise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(customerID);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //update the record
                CustomerList.Update();
            }
            //redirect back to the list page
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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

    protected void btnReturnMainMenu_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirct to the main menu
        Response.Redirect("CustomerList.aspx");
    }
}