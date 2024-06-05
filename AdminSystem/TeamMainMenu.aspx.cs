using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCustomers_Click(object sender, EventArgs e)
    {
        //redirect the user to the address book login page 
        Response.Redirect("CustomerLogin.aspx");
    }

    protected void btnStaff_Click(object sender, EventArgs e)
    {
        //redirect the user to the Staff Login Page
        Response.Redirect("StaffLogin.aspx");
    }

    protected void btnOrderProcessing_Click(object sender, EventArgs e)
    {
        //redirect to main menu
        Response.Redirect("OrderProcessingLogin.aspx");
    }


    protected void btnSupplier_Click(object sender, EventArgs e)
    {
        //redirect the user to supplier login page
        Response.Redirect("SupplierLogin.aspx");
    }

    protected void btnStock_Click(object sender, EventArgs e)
    {
        //redirect user to the stock login  pGE
        Response.Redirect("StockLogin.aspx");
    }
}