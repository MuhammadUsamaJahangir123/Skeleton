using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        //Private data member for the supplier id property
        private Int32 mSupplierId;
        private DateTime mDateAdded;
        private Boolean mActive;
        private String mSupplierName;
        private String mContactInfo;




        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
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
        public string ContactInfo
        {
            get
            {
                return mContactInfo;
            }
            set
            {
                mContactInfo = value;
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

        public bool Find(int supplierId)
        {
            //set the private data members to the test data value
            mSupplierId = 21;
            mDateAdded = Convert.ToDateTime("02/03/2024");
            mContactInfo = "Gurjot@gmail.com";
            mSupplierName = "Gurj";
            mActive = true;
            //  always return true
            return true;

        }
        


       

    }
}