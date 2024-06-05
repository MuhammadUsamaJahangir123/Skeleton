using System;
using System.Diagnostics.Eventing.Reader;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the customer id property
        private Int32 mcustomerID;
        //CustomerID public property
        public Int32 customerID
        {
            get
            {  //This Line of code sends data out of the property
                return mcustomerID;
            }
            set
            { //This line of code allows data into the property
                mcustomerID = value;
            }
        }
        //private data member for the Subscribe
        private bool msubscribe;
        public bool subscribe
        {
            get
            {   //This Line of code sends data out of the property
                return msubscribe;
            }
            set
            {   //This line of code allows data into the property
                msubscribe = value;
            }
        }

        //Private data member for the date added property
        private DateTime mjoinedDate;
        public DateTime joinedDate
        {
            get
            {   //This line of code sends data out of the property
                return mjoinedDate;
            }
            set
            {   //This of code allows data inot the property
                mjoinedDate = value;
            }
        }
        //Private data member for the Firstname property
        private string mfirstName;
        public string firstName
        {
            get
            {  //This line of code sends data out of the property
                return mfirstName;
            }
            set
            {   //This of code allows data inot the property
                mfirstName = value;
            }
        }
        //Private data member for the Lastname property
        private string mlastName;
        public string lastName
        {
            get
            {    //This line of code sends data out of the property
                return mlastName;
            }
            set
            {   //This line of code allows data into the property
                mlastName = value;
            }
        }
        //Private data member for the Email property
        private string memail;
        public string email
        {
            get
            {    //This line of code sends data out of the property
                return memail;
            }
            set
            {   //This line of code allows data into the property
                memail = value;
            }
        }

        //Private data member for the phone no
        private string mPhoneNo;
        public string PhoneNo
        {
            get
            {
                return mPhoneNo;
            }
            set
            {
                mPhoneNo = value;
            }
        }
        //Find it 
        public bool Find(int customerID)
        {
            //create instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for
            DB.AddParameter("@customerID", customerID);
            //execute the stored procedure
            DB.Execute("sproc_tbCustomer_FilterBycustomerID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //Set the private data members to the test data values
                //copy data from database to the private data members
                mcustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["customerID"]);
                mjoinedDate = Convert.ToDateTime(DB.DataTable.Rows[0]["joinedDate"]);
                mfirstName = Convert.ToString(DB.DataTable.Rows[0]["firstName"]);
                mlastName = Convert.ToString(DB.DataTable.Rows[0]["lastName"]);
                memail = Convert.ToString(DB.DataTable.Rows[0]["email"]);
                msubscribe = Convert.ToBoolean(DB.DataTable.Rows[0]["subscribe"]);
                mPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["PhoneNo"]);
                //always return true
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;

            }
        }
    
        public string Valid(string email, string firstName, string lastName, string PhoneNo, string joinedDate)
        {
            //create a string varaible to store the error
            String Error = "";
            //create a temporary variable to store the date values 
            DateTime DateTemp;

            //if firstName is blank
            if (firstName.Length == 0)
            {
                Error = Error + "The First Name may not be blank : ";

            }
            // if the first name is greater then 50
            if (firstName.Length > 50)
            {
                //record error
                Error = Error + "The First Name must not be more then 50 characters : ";
            }
            //if lastname is blank
            if (lastName.Length == 0)
            {
                //record error
                Error = Error + "The Last Name may not be blank : ";
            }
            // if the last name is greater then 50
            if (lastName.Length > 50)
            {
                //record error
                Error = Error + "The Last Name must not be more then 50 characters : ";
            }
            //if email is blank
            if (email.Length == 0)
            {
                //record error
                Error = Error + "The Email may not be blank : ";
            }
            // if the email is greater then 50
            if (email.Length > 50)
            {
                //record error
                Error = Error + "The Email must not be more then 50 characters : ";
            }
            //if PhoneNo is blank
            if (PhoneNo.Length == 0)
            {
                //record error
                Error = Error + "The PhoneNo may not be blank : ";
            }
            // if the first name is greater then 50
            if (PhoneNo.Length > 50)
            {
                //record error
                Error = Error + "The PhoneNo must not be more then 50 characters : ";
            }
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy the joinedDate value to the DateTemp Variable
                DateTemp = Convert.ToDateTime(joinedDate);
                //check to see if the date is less than tdays date
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateComp)
                {
                    //record error
                    Error = Error + "The data cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was no vaild date : ";
            }
                //return any error messages
                return Error;
            }
        }
    }

    
