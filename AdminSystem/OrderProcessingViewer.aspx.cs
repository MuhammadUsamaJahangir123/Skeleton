using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of the clsOrderProcessing
        clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
        //get the datat from the session object
        AnOrderProcessing = (clsOrderProcessing)Session["AnOrderProcessing"];
        //Display the orderID for this entry


       // Response.Write(AnOrderProcessing.OrderID);
       // Response.Write(AnOrderProcessing.StaffID);
       // Response.Write(AnOrderProcessing.CustomerID);
        Response.Write(AnOrderProcessing.TotalAmount);
        Response.Write(AnOrderProcessing.OrderDate);
        Response.Write(AnOrderProcessing.ShippingStatus);
    }
}