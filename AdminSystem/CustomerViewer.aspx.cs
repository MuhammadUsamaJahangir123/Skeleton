using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //get data from the session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //Display the name
        Response.Write(AnCustomer.customerID);
        Response.Write(AnCustomer.firstName);
        Response.Write(AnCustomer.lastName);
        Response.Write(AnCustomer.email);
        Response.Write(AnCustomer.joinedDate);
        Response.Write(AnCustomer.subscribe);
        Response.Write(AnCustomer.PhoneNo);

    }
}