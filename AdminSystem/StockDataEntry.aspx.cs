using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to sotore the PK w page lvl scope
    Int32 ProductId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get  the numb pf the stock to be processed
        ProductId = Convert.ToInt32(Session["ProductId"]);
        if (IsPostBack == false)
        {
            //if this is the not a new record
            if (ProductId != -1)
            {
                //display the current data for the record
                DisplayStock();
            }
        }


    }

    void DisplayStock()
    {
        //create an instance of the stock book
        clsStockCollection Stock = new clsStockCollection();
        //find the record to update
        Stock.ThisStock.Find(ProductId);
        //display the data for the record
        txtProductId.Text = Stock.ThisStock.ProductId.ToString();
        txtProductName.Text = Stock.ThisStock.ProductName.ToString();
        txtProductPrice.Text = Stock.ThisStock.ProductPrice.ToString();
        txtStockQuantity.Text = Stock.ThisStock.StockQuantity.ToString();
        txtDateAdded.Text = Stock.ThisStock.DateAdded.ToString();
        chkIsAvailable.Checked = Stock.ThisStock.IsAvailable;
        chkRestock.Checked = Stock.ThisStock.Restock;


    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock 
        clsStock AnStock = new clsStock();

        int ProductId = Convert.ToInt32(txtProductId.Text);
        string ProductName = txtProductName.Text;
        string ProductPrice = txtProductPrice.Text;
        string StockQuantity = txtStockQuantity.Text;
        string DateAdded = txtDateAdded.Text;
        string IsAvailable  = chkIsAvailable.Text;
        string Resttock = chkRestock.Text;
        //variable to store any error msgs
        string Error = "";
        //validate the data
        Error = AnStock.Valid(ProductName, DateAdded);
        if (Error == "")
        {
            //capture the product id
            AnStock.ProductId = ProductId;
            //capture the Product Name
            AnStock.ProductName = ProductName;
            //capture the product price
            AnStock.ProductPrice = Convert.ToDecimal(ProductPrice);
            //capture the stock quantity
            AnStock.StockQuantity = Convert.ToInt32(StockQuantity);
            //capture the date added
            AnStock.DateAdded = Convert.ToDateTime(DateAdded);
            //capture the availbility
            AnStock.IsAvailable = chkIsAvailable.Checked;
            //capture the restock
            AnStock.Restock = chkRestock.Checked;
            //create a new instance of stock collection
            clsStockCollection StockList = new clsStockCollection();

            //if this is a new record i.e proudctid = -1 then add the data
            if (ProductId == -1)
            {
                //set the This Stock property
                StockList.ThisStock = AnStock;
                //add the new record
                StockList.Add();

            }
            //otherwise it must be an update
            else
            {
                //find the record to update 
                StockList.ThisStock.Find(ProductId);
                //set the this stock property
                StockList.ThisStock = AnStock;
                //update the record
                StockList.Update();
            }

            //navigate to the List page
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display the error msg
            lblError.Text = Error;
        }
     
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //reatec an instance od the Stock class
        clsStock AnStock = new clsStock();
        //create a variable to store the primary key
        Int32 ProductId;
        //create a variable to store the result of the find operatio
        Boolean Found = false;
        //get the primary key entered by the suer
        ProductId = Convert.ToInt32(txtProductId.Text);
        //find the rceord
        Found = AnStock.Find(ProductId);
        //if found
        if (Found == true)
        {
            //display the aluevs of the properties in the form
            txtProductName.Text = AnStock.ProductName;
            txtProductPrice.Text = AnStock.ProductPrice.ToString();
            txtStockQuantity.Text = AnStock.StockQuantity.ToString();
            txtDateAdded.Text = AnStock.DateAdded.ToString();
            chkIsAvailable.Checked = AnStock.IsAvailable;
            chkRestock.Checked = AnStock.Restock;
           

        }
    }
}