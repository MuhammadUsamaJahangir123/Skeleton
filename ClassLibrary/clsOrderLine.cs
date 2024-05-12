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

        public bool Find(int OrderLineId)
        {

            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order id to search for
            DB.AddParameter("@OrderLineId", OrderLineId);
            //execute the stored procedure
            DB.Execute("sproc_tbOrderLine_FilterByOrderLineId");
            //if one record is found(there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members

                mOrderLineId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineId"]);
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);

                // return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }
    }
}