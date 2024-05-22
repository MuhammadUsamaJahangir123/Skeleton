using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the following property
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member for ThisStaff
        clsStaff mThisStaff = new clsStaff();




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
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }


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



        public int Add()
        {
            //adds a record to the database based on the values of mThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@JoinedDate", mThisStaff.JoinedDate);
            DB.AddParameter("@Availability", mThisStaff.Availability);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@PhoneNo", mThisStaff.PhoneNo);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tbStaff_Insert");

        }

        public void Update()
        {
            //update an existing record based on the values of ThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@JoinedDate", mThisStaff.JoinedDate);
            DB.AddParameter("@Availability", mThisStaff.Availability);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@PhoneNo", mThisStaff.PhoneNo);

            //execute the stored procedure
            DB.Execute("sproc_tbStaff_Update");
        }
    }
}