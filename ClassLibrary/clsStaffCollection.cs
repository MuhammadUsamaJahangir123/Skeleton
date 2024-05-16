using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the following property
        List<clsStaff> mStaffList = new List<clsStaff>();




        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return StaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsStaff ThisStaff { get; set; }


        //constructor for the class
        public clsStaffCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tbStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Staff
                clsStaff AnStaff = new clsStaff();
                //read in the fields for the current record
                AnStaff.Availability = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);
                AnStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AnStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnStaff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnStaff.JoinedDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["JoinedDate"]);
                AnStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnStaff.PhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNo"]);

                //add the record to the private data member
                mStaffList.Add(AnStaff);
                //point at the next record
                Index++;


            }
            
            
            
            
            
            
            
            
        }
    }
}