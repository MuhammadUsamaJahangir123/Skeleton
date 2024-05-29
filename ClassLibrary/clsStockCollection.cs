using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.Remoting.Channels;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();

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
        public clsStock ThisStock { get; set; }

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