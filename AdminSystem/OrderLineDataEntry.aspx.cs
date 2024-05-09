using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrderProcessing
        clsOrderLine AnOrderLine = new clsOrderLine();
        //store the data in the session object

        AnOrderLine.OrderLineID = Convert.ToInt32(txtOrderLineId.Text);
        AnOrderLine.OrderID = Convert.ToInt32(txtOrderId.Text);
        AnOrderLine.ProductID = Convert.ToInt32(txtProductId.Text);
        AnOrderLine.Quantity = Convert.ToInt32(txtQuantity.Text);


        //navigate to the view page
        Session["AnOrderLine"] = AnOrderLine;
        //navigate to the view page
        Response.Redirect("OrderLineViewer.aspx");
    }
}