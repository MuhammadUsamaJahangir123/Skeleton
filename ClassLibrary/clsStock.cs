﻿using System;
using System.Dynamic;

namespace ClassLibrary
{
    public class clsStock
    {
       


        //private data member for the date added property
        private DateTime mDateAdded;
        //dateAdded public property
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends fata out of the propertu
                return mDateAdded;
            }
            set
            {
                //this line of code allows data into the porperty
                mDateAdded = value;
            }
        }

        //private data member for the product id property
        private Int32 mProductId;
        //ProductId public property
        public Int32 ProductId
        {
            get
            {
                //this line of code sends data out of the property
                return mProductId;
            }
            set
            {
                //this line of code allows data into the property
                mProductId = value;
            }
        }
        //private data member for the Restock Property
        private bool mRestock;
        //Restock public property
        public bool Restock
        {
            get
            {
                //this line of code sends data out of the property
                return mRestock;
            }
            set
            {
                mRestock = value;
            }
        }
        //private data member for the restock property
        private bool mIsAvailable;
        //restock public property
        public bool IsAvailable
        {
            get
            {
                //this line of code aends data out of the property
                return mIsAvailable;
            }
            set
            {
                mIsAvailable = value;
            }
        }

        //private data member for productname property
        private string mProductName;
        //ProductName public property
        public string ProductName
        {
            get
            {
                //this line of code amends data out the property
                return mProductName;
            }
            set
            {
                mProductName = value;
            }
        }
        //private data member for the product price property
        private decimal mProductPrice;
        //product price public property
        public decimal ProductPrice
        {
            get
            {
                //this line of code amends data out the property
                return mProductPrice;
            }
            set
            {
                mProductPrice = value;
            }
        }

        private int mStockQuantity;
        public int StockQuantity
        {
            get
            {
                //this line of ode amends data out the property
                return mStockQuantity;
            }
            set
            {  
                mStockQuantity = value;
            }
        }

        /******** FIND METHOD***********/
        public bool Find(int ProductId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter fore the product id to search for
            DB.AddParameter("@ProductId", ProductId);
            //execute the stored procedure
            DB.Execute("sproc_tbStock_FilterByProductId");
            //if one record is found , there shld b one or zero
            if (DB.Count == 1)
            //set the priv data members to the test data value
            {
                //copy the fata from the DB to the priv data members
                mStockQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["StockQuantity"]);
                mProductPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["ProductPrice"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mIsAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["IsAvailable"]);
                mRestock = Convert.ToBoolean(DB.DataTable.Rows[0]["Restock"]);
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                //return that everythin worked ok
                return true;
            }
            // if no record was found
            else
            {

                //return false indicating there is a problem
                return false;
            }

             
        }
        public string Valid(string productName, string dateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //if the productname is blank
            if (productName.Length == 0)
            {
                //record the error
                Error = Error + "The Product Name may not be blank : ";
            }
            //if the productname is greater than 50
            if (productName.Length > 50)
            {
                //record the rror
                Error = Error + "The product name must be less than 50 characters : ";
            }
            //CreateInstanceBinder an instance of date tiime t compare wit datetemp
            //in the if statements
            DateTime DateComp = DateTime.Now.Date;
            try
            {
                //copy the dateadded value t the datetemp  variable
                DateTemp = Convert.ToDateTime(dateAdded);

                if (DateTemp < DateComp) //comparen dateadded wth date
                {
                    //record the error
                    Error = Error + "The Date Cannot be in the past : ";
                }
                //checkto see if the faye is greater than todays date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the errpr
                Error = Error + "The Date was not a valid date : ";
            }
            //return any error msgs
            return Error;
            
        }
    }
}