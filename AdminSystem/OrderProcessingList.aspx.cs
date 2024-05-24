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
            DisplayOrderProcessings();
        }

    }
    void DisplayOrderProcessings()
    {
        //create an instance of the OrderProcessing Collection
        clsOrderProcessingCollection OrderProcessings = new clsOrderProcessingCollection();
        //set the data sourc to list of OrderProcessings in the collection
        lstOrderProcessingList.DataSource = OrderProcessings.OrderProcessingList;
        //set the name of the primay key
        lstOrderProcessingList.DataValueField = "OrderId";
        //set the data field to display
        lstOrderProcessingList.DataTextField = "ShippingAddress";
        //bind the data to the list
        lstOrderProcessingList.DataBind();

    }

    protected void lstOrderProcessingList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderId"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderProcessingDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 OrderId;
        //if a record has been selected from the list
        if (lstOrderProcessingList.SelectedIndex != -1)
        {
            //Get the primary key value of the record to edit
            OrderId = Convert.ToInt32(lstOrderProcessingList.SelectedValue);
            //store the data in the sesion object
            Session["OrderId"] = OrderId;
            //redirect to the edit page
            Response.Redirect("OrderProcessingDataEntry.aspx");

        }
        else   //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 OrderId;
        if (lstOrderProcessingList.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            OrderId = Convert.ToInt32(lstOrderProcessingList.SelectedValue);
            //stoer the data in the session object
            Session["OrderId"] = OrderId;
            //redirect to the delete page
            Response.Redirect("OrderProcessingConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an eror message
            lblError.Text = "Please select a record from the list to delete";

        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the OrderProcessing object
        clsOrderProcessingCollection AnOrderProcessing = new clsOrderProcessingCollection();
        //retrieve the value of post code from the presentation layer
        AnOrderProcessing.ReportByShippingAddress(txtInput.Text);
        //set the data source to the list of shipping addresses in the collection
        lstOrderProcessingList.DataSource = AnOrderProcessing.OrderProcessingList;
        //set the name of the primary key
        lstOrderProcessingList.DataValueField = "OrderId";
        //set the name of the field to display
        lstOrderProcessingList.DataTextField = "ShippingAddress";
        //bind the data to the list
        lstOrderProcessingList.DataBind();

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the OrderProcessing object
        clsOrderProcessingCollection AnOrderProcessing = new clsOrderProcessingCollection();
        //set an empty string
        AnOrderProcessing.ReportByShippingAddress("");
        //clear any existing filter to tidy up the interface
        txtInput.Text = "";
        //set the data source to the list of orderprocessing in the collection
        lstOrderProcessingList.DataSource = AnOrderProcessing.OrderProcessingList;
        //set the name of the primary key
        lstOrderProcessingList.DataValueField = "OrderId";
        //set the name of the field to display
        lstOrderProcessingList.DataTextField = "ShippingAddress";
        //bind the data to the list
        lstOrderProcessingList.DataBind();

    }
}