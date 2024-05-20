using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        //Private data member for the supplier id property
        private Int32 mSupplierId;
        private DateTime mSupplierDate;
        private Boolean mSupplierActivity;
        private String mSupplierName;
        private String mSupplierContact;
        private Int32 mSupplierShippingTime;
        private String mSupplierPostCode;







        public bool SupplierActivity
        {
            get
            {
                return mSupplierActivity;
            }
            set
            {
                mSupplierActivity = value;
            }
        }

        public DateTime SupplierDate
        {
            get
            {
                return mSupplierDate;
            }
            set
            {
                mSupplierDate = value;
            }
        }
        public int SupplierId
        {
            get
            {
                //This line of code sends data out of the property
                return mSupplierId;
            }
            set
            {
                //This line of code allows data into the property
                mSupplierId = value;
            }
        }
        public string SupplierContact
        {
            get
            {
                return mSupplierContact;
            }
            set
            {
                mSupplierContact = value;
            }
        }
        public string SupplierName
        {
            get
            {
                return mSupplierName;
            }
            set
            {
                mSupplierName = value;
            }
        }

        public int SupplierShippingTime
        {
            get
            {
                return mSupplierShippingTime;
            }
            set
            {
                mSupplierShippingTime = value;
            }
        }

        public string SupplierPostCode
        {
            get
            {
                return mSupplierPostCode;
            }
            set
            {
                mSupplierPostCode = value;
            }
        }

        public bool Find(int SupplierId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staff id to search for
            DB.AddParameter("@SupplierId", SupplierId);
            //execute the stored procedure
            DB.Execute("sproc_tbSupplier_FilterBySupplierId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
                mSupplierDate = Convert.ToDateTime(DB.DataTable.Rows[0]["SupplierDate"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mSupplierContact = Convert.ToString(DB.DataTable.Rows[0]["SupplierContact"]);
                mSupplierActivity = Convert.ToBoolean(DB.DataTable.Rows[0]["SupplierActivity"]);

                //return that everything Worked Fine
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }

        }

        public string Valid(string supplierId, string supplierName, string supplierDate, string supplierActivity, string supplierContact)
        {
            return "";
        }
    }
}