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

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsOrderLine AnOrderLine = new clsOrderLine();
        //create a variable to store the primary key
        Int32 OrderLineId;
        //create a varaible to store the results of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderLineId = Convert.ToInt32(txtOrderLineId.Text);
        //find the record 
        Found = AnOrderLine.Find(OrderLineId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtOrderId.Text = AnOrderLine.OrderID.ToString();
            txtProductId.Text = AnOrderLine.ProductID.ToString();
            txtQuantity.Text = AnOrderLine.Quantity.ToString();
        }

        else
        {
            lblError.Text = "Order Line ID not found";
        }

    }
}