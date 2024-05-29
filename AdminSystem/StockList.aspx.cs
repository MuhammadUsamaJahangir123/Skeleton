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
            DisplayStocks();
        }

    }
    void DisplayStocks()
    {
        //create an instance of the STock Collection
        clsStockCollection Stocks = new clsStockCollection();
        //set the data source to list stocks in the collection
        lstStockList.DataSource = Stocks.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "ProductId";
        //set the data field to displY
        lstStockList.DataTextField = "ProductName";
        //bind the data to the list
        lstStockList.DataBind();
    }
}