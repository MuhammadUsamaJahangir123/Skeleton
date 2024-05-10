using System;

namespace ClassLibrary
{
    public class clsOrderProcessing
    {
        //private data member for the address id property
        private Int32 mOrderId;
        //private data member for the Customer id property
        private Int32 mCustomerId;
        //private data member for staff id property
        private Int32 mStaffId;
        //private data member for OrderDate property
        private DateTime mOrderDate;
        //private data member for OrderDate property
        private Boolean mShippingStatus;
        //private data member for OrderDate property
        private Decimal mTotalAmount;



        public bool ShippingStatus {
            get
            { //this line of code sends data out of the property
                return mShippingStatus;
            }
            set
            {
                // this line of code allows data into the property
                mShippingStatus = value;
            }
        }
        public DateTime OrderDate {
            get
            { //this line of code sends data out of the property
                return mOrderDate;
            }
            set
            {
                // this line of code allows data into the property
                mOrderDate = value;
            }
        }
        public decimal TotalAmount {
            get
            { //this line of code sends data out of the property
                return mTotalAmount;
            }
            set
            {
                // this line of code allows data into the property
                mTotalAmount = value;
            }
        }
        public Int32 OrderID {
            get
            { //this line of code sends data out of the property
                return mOrderId;
            }
            set
            {
                // this line of code allows data into the property
                mOrderId = value;
            }
        }
        public int CustomerID {
            get
            { //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            {
                // this line of code allows data into the property
                mCustomerId = value;
            }
        }
        public int StaffID {
            get
            { //this line of code sends data out of the property
                return mStaffId;
            }
            set
            {
                // this line of code allows data into the property
                mStaffId = value;
            }
        }

        public bool Find(int OrderId)
        {
            
            mOrderId = 21;
            mCustomerId = 11;
            mStaffId= 15;
            mShippingStatus= true;
            //always return true
            return true;
        }
        public bool Find(DateTime orderDate)
        {
            mOrderDate = DateTime.Parse("23/12/2022");
            //always return true
            return true;
        }

        public bool Find(Boolean ShippingStatus) 
        {
            mShippingStatus = true;
            //always return true
            return true;
        }

        public bool Find(Decimal TotalAmount)
        {
            mTotalAmount = 25;
            //always return true
            return true;
        }







    }
}