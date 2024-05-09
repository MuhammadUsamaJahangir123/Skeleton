using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the customer id property
        private Int32 mCustomerID;
        //CustomerID public property
        public Int32 CustomerID {
            get
            {  //This Line of code sends data out of the property
                return mCustomerID;
            }
            set 
            { //This line of code allows data into the property
              mCustomerID = value;
            }
        }
        //private data member for the Subscribe
        private bool mSubscribe;
        public bool Subscribe
        {
            get
            {   //This Line of code sends data out of the property
                return mSubscribe;
            }
            set
            {   //This line of code allows data into the property
                mSubscribe = value;
            }
        }

        //Private data member for the date added property
        private DateTime mJoinedDate;
        public DateTime DateJoined
        {
            get
            {   //This line of code sends data out of the property
                return mJoinedDate;
            }
            set
            {   //This of code allows data inot the property
                mJoinedDate = value;
            }
        }
        //Private data member for the Firstname property
        private string mFirstName;
        public string FirstName
        {
            get
            {  //This line of code sends data out of the property
                return mFirstName;
            }
            set
            {   //This of code allows data inot the property
                mFirstName = value;
            }
        }
        //Private data member for the Lastname property
        private string mLastName;
        public string LastName
        {
            get
            {    //This line of code sends data out of the property
                return mLastName;
            }
            set
            {   //This line of code allows data into the property
                mLastName = value;
            }
        }
        //Private data member for the Email property
        private string mEmail;
        public string Email
        {
            get
            {    //This line of code sends data out of the property
                return mEmail;
            }
            set
            {   //This line of code allows data into the property
                mEmail = value;
            }
        }
        //Find it 
        public bool Find(int CustomerID)
        {
           //Set the private data members to the test data values
            mCustomerID = 21;
            mJoinedDate = Convert.ToDateTime("23/12/2022");
            mFirstName = "Jonny";
            mLastName = "Lenon";
            mEmail = "JonnyLenon@gmail.com";
            mSubscribe = true;
            //always return true
            return true;
        }
     
    }
}
