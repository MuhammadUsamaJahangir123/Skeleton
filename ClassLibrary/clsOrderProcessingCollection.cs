using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsOrderProcessingCollection
    {
        //private data member for the list
        List<clsOrderProcessing> mOrderProcessingList = new List<clsOrderProcessing>();
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
        public clsOrderProcessing ThisOrderProcessing { get; set; }

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
                AnOrderProcessing.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrderProcessing.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrderProcessing.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnOrderProcessing.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrderProcessing.ShippingStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["ShippingStatus"]);
                AnOrderProcessing.TotalAmount = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalAmount"]);
                //add the record to the private data member
                mOrderProcessingList.Add(AnOrderProcessing);
                //point at the next record
                Index++;
            }
        }


    }
}