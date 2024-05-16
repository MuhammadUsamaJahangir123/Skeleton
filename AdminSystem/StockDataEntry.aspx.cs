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

    protected void txtProductPrice_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create new instance of clsStock
        clsStock AnStock = new clsStock();
        AnStock.ProductName = txtProductName.Text;
        AnStock.ProductPrice = Convert.ToDecimal(txtProductPrice.Text);
        AnStock.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        AnStock.StockQuantity = Convert.ToInt32(txtStockQuantity.Text);

        //capture availbility
        AnStock.IsAvailable = chkIsAvailable.Checked;
        AnStock.Restock = chkRestock.Checked;

        //navigates user to the view page
        Response.Redirect("StockViewer.aspx");
    }
}