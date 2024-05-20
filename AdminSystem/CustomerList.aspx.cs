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
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }
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
}
