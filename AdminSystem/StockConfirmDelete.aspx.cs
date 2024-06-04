using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //ariabvle to store the PK value of the record to be deleted
    Int32 ProductId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the stok cto be deleted from the session object
        ProductId = Convert.ToInt32(Session["ProductId"]);

    }





    protected void btnYesDelete_Click(object sender, EventArgs e)
    {
        //reate ca new instance of the stock collection class
        clsStockCollection Stock = new clsStockCollection();
        //find the record to delere
        Stock.ThisStock.Find(ProductId);
        //delet the recird
        Stock.Delete();
        //redirect bk to main page
        Response.Redirect("StockList.aspx");

    }

    protected void btnNoDelete_Click(object sender, EventArgs e)
    {
        //redirect bk to main page
        Response.Redirect("StockList.aspx");

    }
}