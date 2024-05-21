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
}