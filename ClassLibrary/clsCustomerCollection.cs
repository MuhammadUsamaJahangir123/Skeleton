using System;
using System.Collections.Generic;

namespace ClassLibrary

{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //Private data for ThisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        public clsCustomer ThisCustomer

        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }
        public int Count
        {
            get
            {   //return the count of the list
                return mCustomerList.Count;
            }
            set
            {

            }
        }
        public clsCustomerCollection()
        {  
            //object for the data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tbCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
            
        }
        public int Add()
        {
            //adds a record to the database based on the values of mThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@firstName", mThisCustomer.firstName);
            DB.AddParameter("@lastName", mThisCustomer.lastName);
            DB.AddParameter("@joinedDate", mThisCustomer.joinedDate);
            DB.AddParameter("@subscribe", mThisCustomer.subscribe);
            DB.AddParameter("@email", mThisCustomer.email);
            DB.AddParameter("@PhoneNo", mThisCustomer.PhoneNo);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");

        }
        //update method
        public void Update()
        {

            //adds a record to the database based on the values of mThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("customerID", mThisCustomer.customerID);
            DB.AddParameter("@firstName", mThisCustomer.firstName);
            DB.AddParameter("@lastName", mThisCustomer.lastName);
            DB.AddParameter("@joinedDate", mThisCustomer.joinedDate);
            DB.AddParameter("@subscribe", mThisCustomer.subscribe);
            DB.AddParameter("@email", mThisCustomer.email);
            DB.AddParameter("@PhoneNo", mThisCustomer.PhoneNo);

            //execute the query returning the primary key value
            DB.Execute("sproc_tbCustomer_Update");

        }
        //delete method
        public void Delete()
        {
            //deletes the record pointed to by ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the stored procedure 
            DB.AddParameter("@customerID", mThisCustomer.customerID);
            //execute the stored procedure
            DB.Execute("sproc_tbCustomer_Delete");
        }
        //populate method
        public void ReportByfirstName(string firstName)
        {
            //filters the records based on full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the firstName parameter to the database
            DB.AddParameter("@firstName", firstName);
            //execute the stored procedure
            DB.Execute("sporc_tbCustomer_FilterByfirstName");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array lsit based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //varibale to store the record count
            Int32 RecordCount = 0;
            //get the count of records
            RecordCount = DB.Count;
            //CLEAR THE PRIVATE ARRAY LIST
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields for the current record 
                AnCustomer.subscribe = Convert.ToBoolean(DB.DataTable.Rows[Index]["subscribe"]);
                AnCustomer.customerID = Convert.ToInt32(DB.DataTable.Rows[Index]["customerID"]);
                AnCustomer.firstName = Convert.ToString(DB.DataTable.Rows[Index]["firstName"]);
                AnCustomer.lastName = Convert.ToString(DB.DataTable.Rows[Index]["lastName"]);
                AnCustomer.PhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNo"]);
                AnCustomer.joinedDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["joinedDate"]);
                //addd the record to the private data member
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;

            }
        }
    }
}