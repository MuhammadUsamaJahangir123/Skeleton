﻿using System;

namespace ClassLibrary
{
    public class clsOrderProcessing
    {
        //private data member for the address id property
        private Int32 mOrderId;
        //private data member for the Customer id property
        private Int32 mCustomerId;
        //private data member for staff id property
        private Int32 mStaffId;
        //private data member for OrderDate property
        private DateTime mOrderDate;
        //private data member for OrderDate property
        private Boolean mShippingStatus;
        //private data member for OrderDate property
        private Decimal mTotalAmount;
        //private data member for ShippingAddress property
        private string mShippingAddress;



        public bool ShippingStatus {
            get
            { //this line of code sends data out of the property
                return mShippingStatus;
            }
            set
            {
                // this line of code allows data into the property
                mShippingStatus = value;
            }
        }
        public DateTime OrderDate {
            get
            { //this line of code sends data out of the property
                return mOrderDate;
            }
            set
            {
                // this line of code allows data into the property
                mOrderDate = value;
            }
        }
        public decimal TotalAmount {
            get
            { //this line of code sends data out of the property
                return mTotalAmount;
            }
            set
            {
                // this line of code allows data into the property
                mTotalAmount = value;
            }
        }
        public Int32 OrderId {
            get
            { //this line of code sends data out of the property
                return mOrderId;
            }
            set
            {
                // this line of code allows data into the property
                mOrderId = value;
            }
        }
        public int CustomerId {
            get
            { //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            {
                // this line of code allows data into the property
                mCustomerId = value;
            }
        }
        public int StaffId {
            get
            { //this line of code sends data out of the property
                return mStaffId;
            }
            set
            {
                // this line of code allows data into the property
                mStaffId = value;
            }
        }

        public string ShippingAddress {
            get
            { //this line of code sends data out of the property
                return mShippingAddress;
            }
            set
            {
                // this line of code allows data into the property
                mShippingAddress = value;
            }
        }

        public bool Find(int orderId)
        {
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order id to search for
            DB.AddParameter("@OrderId", orderId);
            //execute the stored procedure
            DB.Execute("sproc_tblorders_FilterByOrderId");
            //if one record is found(there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members

                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mShippingStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["ShippingStatus"]);
                mTotalAmount = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalAmount"]);
                mShippingAddress = Convert.ToString(DB.DataTable.Rows[0]["ShippingAddress"]);

                // return that everything worked ok
                return true;
            }
            //if no record was found
            else 
            { 
                //return false indicating there is a problem
                return false;
            }
        }

        //function for the public validation method
        public string Valid(string OrderDate, string ShippingAddress, decimal TotalAmount)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the data values
            DateTime DateTemp;

            //if ShippingAddress is blank
            if (ShippingAddress.Length == 0)
            {
                Error = Error + "The Shipping Address may not be blank : ";

            }
            // if the Shipping Address is no greater then 50
            if (ShippingAddress.Length > 50)
            {
                //record error
                Error = Error + "The Shipping Address must not be more than 50 characters : ";
            }

            //if the totalamount is 

            if(TotalAmount < (decimal)0.00)
            {
                Error = Error + "The total price cannot be less than 0 :";
            }





            //create an instance of datetime to compare with datetemp
            //in the if statements
            DateTime DateComp = DateTime.Now.Date;
            try

            {
                //copy the OrderDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(OrderDate);
                //check to see if the date is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateComp)
                {
                    //record error
                    Error = Error + "The data cannot be in the future : ";
                }
            } catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            //return any error messages
            return Error;
        }

        
    }
}