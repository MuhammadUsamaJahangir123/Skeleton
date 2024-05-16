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
        //capture the customerID
        string CustomerId = txtCustomerId.Text;
        //capture the staff Id
        string StaffId = txtStaffId.Text;
        //capture the order date
        string OrderDate = txtOrderDate.Text;
        //capture the total amount
        string TotalAmount = txtTotalAmount.Text;
        //capture the shipping status
        string ShippingStatus = chkShippingStatus.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrderProcessing.Valid(OrderDate);
        if (Error == "")
        {
            //capture the order date
            AnOrderProcessing.OrderDate = Convert.ToDateTime(OrderDate);
            //store the OrderProcessing in the session object
            Session["AnOrderProcessing"] = AnOrderProcessing;
            //navigate to the view page
            Response.Redirect("OrderProcessingViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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

    protected void btnFind_Click(object sender, EventArgs e)
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
            //display the values of the properties in the form
            txtCustomerId.Text = AnOrderProcessing.CustomerID.ToString();
            txtOrderDate.Text = AnOrderProcessing.OrderDate.ToString();
            txtStaffId.Text = AnOrderProcessing.StaffID.ToString();
            txtTotalAmount.Text = AnOrderProcessing.TotalAmount.ToString();
            chkShippingStatus.Checked = AnOrderProcessing.ShippingStatus;
        }

        else
        {
            lblError.Text = "Order ID not found";
        }

    }
}