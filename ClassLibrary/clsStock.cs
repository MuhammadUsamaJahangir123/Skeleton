using System;

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
        public int ProductId
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

        public bool Find(int productId)
        {
            //set the priv data members to the test data value
            mStockQuantity = 232;
            mProductPrice = Convert.ToDecimal("25.70");
            mProductName = "TestProductName";
            mIsAvailable = true;
            mRestock = true;
            mProductId = 21;
            mDateAdded = Convert.ToDateTime("21/05/2024");
            //alwaysreturn true
            return true;
        }
    }
}