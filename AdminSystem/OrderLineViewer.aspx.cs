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
        clsOrderLine AnOrderLine = new clsOrderLine();
        //get the datat from the session object
        AnOrderLine = (clsOrderLine)Session["AnOrderLine"];
        //Display the orderID for this entry
        Response.Write(AnOrderLine.OrderLineID);
        Response.Write(AnOrderLine.OrderID);
        Response.Write(AnOrderLine.ProductID);
        Response.Write(AnOrderLine.Quantity);
        

    }
}