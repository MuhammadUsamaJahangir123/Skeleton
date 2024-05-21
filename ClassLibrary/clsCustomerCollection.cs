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

        /*** public clsCustomerCollection()
         {   //create items of test data
             clsCustomer TestItem = new clsCustomer();
             //set its properties
             TestItem.subscribe = true;
             TestItem.email = "JonnyLenon@gmail.com";
             TestItem.customerID = 1;
             TestItem.firstName = "Jonny";
             TestItem.lastName = "Lenon";
             TestItem.joinedDate = DateTime.Now;
             TestItem.PhoneNo = "07404535912";
             //add the test item to the test list
             mCustomerList.Add(TestItem);
             //re initialise the object for some new data
             TestItem = new clsCustomer();
             //set its properties 
             TestItem.subscribe = true;
             TestItem.email = "JakeFade@gmail.com";
             TestItem.customerID = 2;
             TestItem.firstName = "Jake";
             TestItem.lastName = "Fade";
             TestItem.joinedDate = DateTime.Now;
             TestItem.PhoneNo = "07303535912";
             //add the item to the test list
             mCustomerList.Add(TestItem);
         }***/
        public clsCustomerCollection()
        {   //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tbCustomer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
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
    }
    }