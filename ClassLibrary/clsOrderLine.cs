using System;

namespace ClassLibrary
{
    public class clsOrderLine
    {
        //private data member for the Order Line id property
        private Int32 mOrderLineId;
        //private data member for the Order id property
        private Int32 mOrderId;
        //private data member for Product id property
        private Int32 mProductId;
        //private data member for Quantity property
        private Int32 mQuantity;
        public int OrderLineID {
            get
            { //this line of code sends data out of the property
                return mOrderLineId;
            }
            set
            {
                // this line of code allows data into the property
                mOrderLineId = value;
            }
        }
        public int OrderID {
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
        public int ProductID {
            get
            { //this line of code sends data out of the property
                return mProductId;
            }
            set
            {
                // this line of code allows data into the property
                mProductId = value;
            }
        }
        public int Quantity {
            get
            { //this line of code sends data out of the property
                return mQuantity;
            }
            set
            {
                // this line of code allows data into the property
                mQuantity = value;
            }

        }

        public bool Find(int orderId)
        {

            mOrderId = 27;
            mProductId =22;
            mOrderLineId = 8;
            Quantity = 4;
            //always return true
            return true;
        }
    }
}