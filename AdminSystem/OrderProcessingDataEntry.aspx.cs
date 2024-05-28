using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Order o be processed
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (OrderId != -1)
            {
                //display the current data for the record
                DisplayOrderProcessing();
            }
        }

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
        decimal TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
        //capture the shipping status
        string ShippingStatus = chkShippingStatus.Text;
        //capture the shipping Address
        string ShippingAddress = txtShippingAddress.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrderProcessing.Valid(OrderDate,ShippingAddress,TotalAmount);
        if (Error == "")
        {   //capture the OrderId
            AnOrderProcessing.OrderId = Convert.ToInt32(OrderId);
            //capture the CustomerId
            AnOrderProcessing.CustomerId = Convert.ToInt32(CustomerId);
            //capture the staffId
            AnOrderProcessing.StaffId = Convert.ToInt32(StaffId);
            //capture the order date
            AnOrderProcessing.OrderDate = Convert.ToDateTime(OrderDate);
            //capture the ShippingAddress
            AnOrderProcessing.ShippingAddress = ShippingAddress;
            //capture the shipping status
            AnOrderProcessing.ShippingStatus = chkShippingStatus.Checked;
            //capture the TotalAmount
            AnOrderProcessing.TotalAmount = Convert.ToDecimal(TotalAmount);
            //create a new instance of the address collection
            clsOrderProcessingCollection OrderProcessingList = new clsOrderProcessingCollection();
            //if this is a new record i.e. OrderId = -1 then add the data
            if (OrderId == -1)
            {
                //set the ThisOrderProcessing property
                OrderProcessingList.ThisOrderProcessing = AnOrderProcessing;
                //add the new record
                OrderProcessingList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                OrderProcessingList.ThisOrderProcessing.Find(OrderId);
                //set the ThisOrderProcessing Property
                OrderProcessingList.ThisOrderProcessing = AnOrderProcessing;
                //update the record
                OrderProcessingList.Update();

            }
            //redirect back to the list page
            Response.Redirect("OrderProcessingList.aspx");
            
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
            txtCustomerId.Text = AnOrderProcessing.CustomerId.ToString();
            txtOrderDate.Text = AnOrderProcessing.OrderDate.ToString();
            txtStaffId.Text = AnOrderProcessing.StaffId.ToString();
            txtTotalAmount.Text = AnOrderProcessing.TotalAmount.ToString();
            chkShippingStatus.Checked = AnOrderProcessing.ShippingStatus;
            txtShippingAddress.Text = AnOrderProcessing.ShippingAddress;
        }

        else
        {
            lblError.Text = "Order ID not found";
        }

    }

    void DisplayOrderProcessing()
    {
        //create an instance of the address book
        clsOrderProcessingCollection OrderProcessingBook = new clsOrderProcessingCollection();
        //find the record to update
        OrderProcessingBook.ThisOrderProcessing.Find(OrderId);
        //display the data for the record
        txtOrderId.Text = OrderProcessingBook.ThisOrderProcessing.OrderId.ToString();
        txtCustomerId.Text = OrderProcessingBook.ThisOrderProcessing.CustomerId.ToString();
        txtStaffId.Text = OrderProcessingBook.ThisOrderProcessing.StaffId.ToString();
        txtOrderDate.Text = OrderProcessingBook.ThisOrderProcessing.OrderDate.ToString();
        txtTotalAmount.Text = OrderProcessingBook.ThisOrderProcessing.TotalAmount.ToString();
        chkShippingStatus.Checked = OrderProcessingBook.ThisOrderProcessing.ShippingStatus;
        txtShippingAddress.Text = OrderProcessingBook.ThisOrderProcessing.OrderId.ToString();
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        //redirect to main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}