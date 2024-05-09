using System;

namespace ClassLibrary
{
    public class clsOrderProcessing
    {
        //private data member for the address id property
        private Int32 mOrderId;
        //private data member for the Customer id property
        private Int32 mCustomerId;


        public bool ShippingStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
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
        public int StaffID { get; set; }

        public bool Find(int OrderId)
        {
            //always return true
            mOrderId = 21;
            mCustomerId = 11;
            return true;
        }

        
        
        
    }
}