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
        clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
        //store the data in the session object

        AnOrderProcessing.OrderID = Convert.ToInt32(txtOrderId.Text);
        AnOrderProcessing.CustomerID = Convert.ToInt32(txtCustomerId.Text);
        AnOrderProcessing.StaffID = Convert.ToInt32(txtStaffId.Text);
        AnOrderProcessing.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
        AnOrderProcessing.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
        AnOrderProcessing.ShippingStatus = chkShippingStatus.Checked;

        //navigate to the view page
        Session["AnOrderProcessing"] = AnOrderProcessing;



        Response.Redirect("OrderProcessingViewer.aspx");

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
        //create a variable to store the primary key
        Int32 OrderId;
        //create a varaible to store the results of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderId = Convert.ToInt32(txtOrderId.Text);
        //find the record 
        Found = AnOrderProcessing.Find(OrderId);
        //if found
        if (Found == true)
        {
         
        }
    }
}