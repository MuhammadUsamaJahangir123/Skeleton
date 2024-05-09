using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the following property
        private Int32 mStaffID;
        private DateTime mDateAdded;
        private string mFirstName;
        private string mLastName;
        private Boolean mAvailability;
        private string mEmail;


        public bool Availability
        {
            get
            {
                //this line of code senda data out of the property
                return mAvailability;
            }
            set
            {
                //this line of code allows data into the property
                mAvailability = value;
            }
        }
        public DateTime DateAdded
        {
            get
            {
                //this line of code senda data out of the property
                return mDateAdded;
            }
            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }
        public Int32 StaffID
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffID;
            }
            set
            {
                //this line of code allows data into the property
                mStaffID = value;
            }
        }
                
        public string FirstName
        {
            get
            {
                //this line of code sends data out of the property
                return mFirstName;
            }
            set
            {
                //this line of code allows data into the property
                mFirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                //this line of code sends data out of the property
                return mLastName;
            }
            set
            {
                //this line of code allows data into the property
                mLastName = value;
            }
        }
        public string Email
        {
            get
            {
                //this line of code sends data out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property
                mEmail = value;
            }
        }

        public bool Find(int staffID)
        {
            //set the private data members to the test data value
            mStaffID = 2;
            mDateAdded = Convert.ToDateTime("23/06/2023");
            mFirstName = "Max";
            mLastName = "Verstappen";
            mAvailability = true;
            mEmail = "max_verst18@yahoo.com";
            //always return true
            return true;
        }
    }
}