using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the following property
        private Int32 mStaffID;
        private DateTime mJoinedDate;
        private string mFirstName;
        private string mLastName;
        private Boolean mAvailability;
        private string mEmail;
        private string mPhoneNo;


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
        public DateTime JoinedDate
        {
            get
            {
                //this line of code senda data out of the property
                return mJoinedDate;
            }
            set
            {
                //this line of code allows data into the property
                mJoinedDate = value;
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

        public string PhoneNo 
        {
            get
            {
                //this line of code sends data out of the property
                return mPhoneNo;
            }
            set
            {
                //this line of code allows data into the property
                mPhoneNo = value;
            }
        }

        public bool Find(int StaffID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staff id to search for
            DB.AddParameter("@StaffID", StaffID);
            //execute the stored procedure
            DB.Execute("sproc_tbStaff_FilterByStaffID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mJoinedDate = Convert.ToDateTime(DB.DataTable.Rows[0]["JoinedDate"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);
                mPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["PhoneNo"]);

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
    }
}