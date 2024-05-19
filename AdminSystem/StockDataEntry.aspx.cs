using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AnStock = new clsStock();
        //capture the Product Name
        AnStock.ProductName = txtProductName.Text;
        //capture the product price
        AnStock.ProductPrice = Convert.ToDecimal(txtProductPrice.Text);
        //capture the stock quantity
        AnStock.StockQuantity = Convert.ToInt32(txtStockQuantity.Text);
        //capture the date added
        AnStock.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        //capture the availbility
        AnStock.IsAvailable = chkIsAvailable.Checked;
        //capture the restock
        AnStock.Restock = chkRestock.Checked;
        //capture the product id
        AnStock.ProductId = Convert.ToInt32(txtProductId.Text);
        //store the stock in the session object
        Session["AnStock"] = AnStock;
        //navigate to the view page
        Response.Redirect("StockViewer.aspx");
    }
}