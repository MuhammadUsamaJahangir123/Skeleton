using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed

        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }
        //create new instance of clsUustomerUser
        clsCustomerUser AnUser = new clsCustomerUser();
        //get data from the session object
        AnUser = (clsCustomerUser)Session["AnUser"];
        //display the user name
        Response.Write("Logged in as: " + AnUser.UserName);
    }
        void DisplayCustomers()
        {
            //create an instance of the Customer Collection
            clsCustomerCollection Customers = new clsCustomerCollection();  
            //set the data sourc to list of addresses in the collection
            lstCustomerList.DataSource = Customers.CustomerList;
            //set the name of the primay key
            lstCustomerList.DataValueField = "customerID";
            //set the data field to display
            lstCustomerList.DataTextField = "firstName";
            //bind the data to the list
            lstCustomerList.DataBind();
            
        }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the seesion object to indicate this is a new record
        Session["customerID"] = -1;
        //redirect to the data entry page
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //varaible to store the primary key to value of the record to be edited
        Int32 customerID;
        //if record has been sleceted from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            customerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["customerID"] = customerID;
            //redirect to the edit page
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else // if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 customerID;
        //if a  record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            customerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["customerID"] = customerID;
            //redirect to the delete page
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else //if no record has been selected 
        {
            //display an error message 
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the cusomter object
        clsCustomerCollection AnCustomer = new clsCustomerCollection();
        //retrieve the value of post code from the presentation layer
        AnCustomer.ReportByfirstName(txtEnterfirstName.Text);
        //set the data source to the list of customers in the collection
        lstCustomerList.DataSource = AnCustomer.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "customerID";
        //set the name of the field to display 
        lstCustomerList.DataTextField = "firstName";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of  the customer object
        clsCustomerCollection AnCustomer = new clsCustomerCollection();
        //set an emtpy string
        AnCustomer.ReportByfirstName("");
        //clear any existing filter to tidy up the interface 
        txtEnterfirstName.Text = "";
        //set the data source to the list of customers in the collection
        lstCustomerList.DataSource = AnCustomer.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "customerID";
        //set the name of the field to display 
        lstCustomerList.DataTextField = "firstName";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnReturnMainMenu_Click(object sender, EventArgs e)
    {
        //redirect to main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}
