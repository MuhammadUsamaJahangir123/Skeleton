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
        //reacte new instance of cls stock user
        clsStockUser AnUser = new clsStockUser();
        //get data from sesh obj
        AnUser = (clsStockUser)Session["AnUser"];
        //display the user nsme
        Response.Write("Logged in as: " + AnUser.UserName);

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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store - 1 into the session objet toc indicate this is a new record
        Session["ProductId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //ariavble to store the PK val of the record 2b edited
        Int32 ProductId;
        //if a record has been selecteed from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the PK val of the record to edit
            ProductId = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session obj
            Session["ProductId"] = ProductId;
            //response to the edit page
            Response.Redirect("StockDataEntry.aspx");

        }
        else //if no records found/seleted
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //ariable vto store the pk value of the record to be delted
        Int32 ProductId;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the pk value of the record delete
            ProductId = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the sess object
            Session["ProductId"] = ProductId;
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else//if no reordc ha been slected
        {
            //display errpr msg
            lblError.Text = "Please select a record from the list to delete";
        }

    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsStockCollection AnStock = new clsStockCollection();
        //retrieve the value of productname from the presentation layer
        AnStock.ReportByProductName(txtBoxEnter.Text);
        //set the data source to the list of stocks in the collections
        lstStockList.DataSource = AnStock.StockList;
        //set the name of the PK
        lstStockList.DataValueField = "ProductId";
        //set the name of the field to display
        lstStockList.DataTextField = "ProductName";
        //bind the data to the list
        lstStockList.DataBind();

    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //reatce an instance of the stock object
        clsStockCollection AnStock = new clsStockCollection();
        //set an empty string
        AnStock.ReportByProductName("");
        //clear any existing filter to tidy up the iterface
        txtBoxEnter.Text = "";
        //set the data source to the list of stocks in the collection
        lstStockList.DataSource= AnStock.StockList;
        //set the name of the PK
        lstStockList.DataValueField = "ProductId";
        //set the name of the field to display
        lstStockList.DataTextField = "ProductName";
        //bind tge data to the list
        lstStockList.DataBind();

    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}