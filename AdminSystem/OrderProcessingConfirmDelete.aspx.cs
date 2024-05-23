using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store hte primary key value of the record to be deleted
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        OrderId = Convert.ToInt32(Session["OrderId"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a ne instance of the OrderProcessingBook collection class
        clsOrderProcessingCollection OrderProcessingBook = new clsOrderProcessingCollection();
        //find the record to delete
        OrderProcessingBook.ThisOrderProcessing.Find(OrderId);
        //delete the record
        OrderProcessingBook.Delete();
        //redirect back to the main page
        Response.Redirect("OrderProcessingList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("OrderProcessingList.aspx");


    }
}