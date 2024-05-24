using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsOrderProcessingCollection
    {
        //private data member for the list
        List<clsOrderProcessing> mOrderProcessingList = new List<clsOrderProcessing>();
        //private member data for thisaddress
        clsOrderProcessing mThisOrderProcessing = new clsOrderProcessing();
        public List<clsOrderProcessing> OrderProcessingList {
            get
            { //return the private data
                return mOrderProcessingList;
            }
            set
            {
                // set the private data
                mOrderProcessingList = value;
            }
        }
        public int Count {
            get
            { //return the count of the list
                return mOrderProcessingList.Count;
            }
            set
            {
                // 

            }
        }
        public clsOrderProcessing ThisOrderProcessing {
            get
            { //return the private data
                return mThisOrderProcessing;
            }
            set
            {
                // set the private data
                mThisOrderProcessing = value;
            }
        }

        public clsOrderProcessingCollection() 
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //inject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tborders_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank orderprocessing
                clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
                //read in the fields for the current record
                AnOrderProcessing.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrderProcessing.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrderProcessing.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnOrderProcessing.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrderProcessing.ShippingStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["ShippingStatus"]);
                AnOrderProcessing.TotalAmount = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalAmount"]);
                AnOrderProcessing.ShippingAddress = Convert.ToString(DB.DataTable.Rows[Index]["ShippingAddress"]);
                //add the record to the private data member
                mOrderProcessingList.Add(AnOrderProcessing);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mthisOrderProcessing
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisOrderProcessing.CustomerId);
            DB.AddParameter("@StaffId", mThisOrderProcessing.StaffId);
            DB.AddParameter("@OrderDate", mThisOrderProcessing.OrderDate);
            DB.AddParameter("@ShippingStatus", mThisOrderProcessing.ShippingStatus);
            DB.AddParameter("@ShippingAddress", mThisOrderProcessing.ShippingAddress);
            DB.AddParameter("@TotalAmount", mThisOrderProcessing.TotalAmount);
            return DB.Execute("sproc_tborders_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisOrderProcessing
            //connect to the database
            clsDataConnection DB =new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@OrderId", mThisOrderProcessing.OrderId);
            DB.AddParameter("@CustomerId", mThisOrderProcessing.CustomerId);
            DB.AddParameter("@StaffId", mThisOrderProcessing.StaffId);
            DB.AddParameter("@OrderDate", mThisOrderProcessing.OrderDate);
            DB.AddParameter("@ShippingStatus", mThisOrderProcessing.ShippingStatus);
            DB.AddParameter("@ShippingAddress", mThisOrderProcessing.ShippingAddress);
            DB.AddParameter("@TotalAmount", mThisOrderProcessing.TotalAmount);
            //execute the stored procedure
            DB.Execute("sproc_tborders_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisorderprocessing
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Set the parameter for the stored procedure
            DB.AddParameter("OrderId", mThisOrderProcessing.OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tborders_Delete");
        }

        public void ReportByShippingAddress(string ShippingAddress)
        {
            //filters the records based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the ShippingAddress parameter to the database
            DB.AddParameter("@ShippingAddress", ShippingAddress);
            //execute the stored procedure
            DB.Execute("sproc_tborders_FilterByShippingAddress");
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
            mOrderProcessingList = new List<clsOrderProcessing>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Shipping Address object
                clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
                //read in the fields for the current record 
                AnOrderProcessing.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrderProcessing.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrderProcessing.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnOrderProcessing.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrderProcessing.ShippingStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["ShippingStatus"]);
                AnOrderProcessing.TotalAmount = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalAmount"]);
                AnOrderProcessing.ShippingAddress = Convert.ToString(DB.DataTable.Rows[Index]["ShippingAddress"]);

                //addd the record to the private data member
                mOrderProcessingList.Add(AnOrderProcessing);
                //point at the next record
                Index++;

            }
        }
    }
}