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

        public string Valid(string firstName, string lastName, string email, string phoneNo, string joinedDate)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;

            //if the firstName is blank
            if (firstName.Length == 0)
            {
                //record the error
                Error = Error + "The first name may not be blank: ";
            }
            //if the firstName is long
            if (firstName.Length > 16)
            {
                //record the error
                Error = Error + "The first name must be less than 16 characters: ";
            }

           

            //create an instance of DateTime to compare with DateTemp
            //in the if statement
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //coppy the joinedDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(joinedDate);

                if (DateTemp < DateComp) //compare joinedDate with Date
                {
                    //record the error
                    Error = Error + "The date cannot be in the past: ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future: ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date is not a valid date: ";
            }



            //if the LASTNAME is blank
            if (lastName.Length == 0)
            {
                //record the error
                Error = Error + "The last name may not be blank: ";
            }
            //if the LASTNAME is long
            if (lastName.Length > 16)
            {
                //record the error
                Error = Error + "The last name must be less than 16 characters: ";
            }

            //if the EMAIL is blank
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "The email may not be blank: ";
            }
            //if the EMAIL is long
            if (email.Length > 25)
            {
                //record the error
                Error = Error + "The email must be less than 25 characters: ";
            }


            //if the PHONE NO is blank
            if (phoneNo.Length == 0)
            {
                //record the error
                Error = Error + "The phone number may not be blank: ";
            }
            //if the PHONE NO is long
            if (phoneNo.Length > 16)
            {
                //record the error
                Error = Error + "The phone number must be less than 25 characters: ";
            }



            //return any error messages
            return Error;
        }
    }
}