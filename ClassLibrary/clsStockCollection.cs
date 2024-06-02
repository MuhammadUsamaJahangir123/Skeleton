using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //priate vmember data for this stock
        clsStock mThisStock = new clsStock();

        //public property for the STock List
        public List<clsStock> StockList
        {
            get
            {
                //set the private data
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return StockList.Count;
            }
            set
            {
                //worry abt l8r
            }
        }
        public int Add()
        {
            //adds a record to the DB based on the values of mThisStock
            //connect to the DB
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedures
            DB.AddParameter("@ProductName", mThisStock.ProductName);
            DB.AddParameter("@ProductPrice", mThisStock.ProductPrice);
            DB.AddParameter("@StockQuantity", mThisStock.StockQuantity);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@IsAvailable", mThisStock.IsAvailable);
            DB.AddParameter("@Restock", mThisStock.Restock);

            //execute the query returning the pk value
            return DB.Execute("sproc_tbStock_Insert");

        }

        public void Update()
        {
            //update an existing record based on the values of thisStock
            //connect to the DB
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored proced
            DB.AddParameter("@ProductId", mThisStock.ProductId);
            DB.AddParameter("@IsAvailable", mThisStock.IsAvailable);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@ProductName", mThisStock.ProductName);
            DB.AddParameter("@ProductPrice", mThisStock.ProductPrice);
            DB.AddParameter("@StockQuantity", mThisStock.StockQuantity);
            DB.AddParameter("@Restock", mThisStock.Restock);
            //execute the stored proced
            DB.Execute("sproc_tbStock_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by this stock
            //connect to the db
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proced
            DB.AddParameter("@ProductId", mThisStock.ProductId);
            //executev stored proced
            DB.Execute("sproc_tbStock_Delete");
        }

        public clsStock ThisStock
        {
            get
            {
                //return the private data
                return mThisStock;
            }
            set
            {
                //set the private data
                mThisStock = value;
            }
        }

        //constructor for the class
        public clsStockCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tbStock_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Stock
                clsStock AnStock = new clsStock();
                //read in the fields for the current record
                AnStock.ProductId = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductId"]);
                AnStock.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                AnStock.ProductPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["ProductPrice"]);
                AnStock.StockQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["StockQuantity"]);
                AnStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnStock.IsAvailable = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsAvailable"]);
                AnStock.Restock = Convert.ToBoolean(DB.DataTable.Rows[Index]["Restock"]);
                //add the record to the private data member
                mStockList.Add(AnStock);
                //point at the next record
                Index++;


            }

            
        }
        
    }
    
    
       




    }