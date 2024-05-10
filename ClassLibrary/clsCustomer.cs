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
    }
}
    
