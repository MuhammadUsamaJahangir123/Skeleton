﻿using System;
using System.Collections.Generic;


namespace ClassLibrary
{

    public class clsSupplierCollection
    {

        List<clsSupplier>mSupplierList = new List<clsSupplier>();
        clsSupplier mThisSupplier = new clsSupplier();  
        public List<clsSupplier> SupplierList
        {
            get
            {
                return mSupplierList;
            }
            set
            {
                mSupplierList = value;
            }
        }
        public int Count 
        {
            get
            {
                return mSupplierList.Count;
            }
            set
            {
                //future me problem
            }
        }
        public clsSupplier ThisSupplier
        {
            get
            {
                //return the private data
                return mThisSupplier;
            }
            set
            {
                //set the private data
                mThisSupplier = value;
            }
        }
        public clsSupplierCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tbSupplier_SelectAll");
            PopulateArray(DB);

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierActivity", mThisSupplier.SupplierActivity);
            DB.AddParameter("@SupplierPostCode", mThisSupplier.SupplierPostCode);
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@SupplierShippingTime", mThisSupplier.SupplierShippingTime);
            DB.AddParameter("@SupplierContact", mThisSupplier.SupplierContact);
            DB.AddParameter("@SupplierDate", mThisSupplier.SupplierDate);


            return DB.Execute("sproc_tbSupplier_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("SupplierId", mThisSupplier.SupplierId);
            DB.AddParameter("@SupplierActivity", mThisSupplier.SupplierActivity);
            DB.AddParameter("@SupplierPostCode", mThisSupplier.SupplierPostCode);
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@SupplierShippingTime", mThisSupplier.SupplierShippingTime);
            DB.AddParameter("@SupplierContact", mThisSupplier.SupplierContact);
            DB.AddParameter("@SupplierDate", mThisSupplier.SupplierDate);


             DB.Execute("sproc_tbSupplier_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierId", mThisSupplier.SupplierId);
            DB.Execute("sproc_tbSupplier_Delete");
        }

        public void ReportByPostCode(string PostCode)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierPostCode", PostCode);
            DB.Execute("sproc_tbSupplier_FilterByPostCode");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mSupplierList = new List<clsSupplier>();
            while (Index < RecordCount)
            {
                clsSupplier ASupplier = new clsSupplier();
                ASupplier.SupplierActivity = Convert.ToBoolean(DB.DataTable.Rows[Index]["SupplierActivity"]);
                ASupplier.SupplierContact = Convert.ToString(DB.DataTable.Rows[Index]["SupplierContact"]);
                ASupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                ASupplier.SupplierPostCode = Convert.ToString(DB.DataTable.Rows[Index]["SupplierPostCode"]);
                ASupplier.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                ASupplier.SupplierShippingTime = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierShippingTIme"]);
                ASupplier.SupplierDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["SupplierDate"]);
                mSupplierList.Add(ASupplier);
                Index++;


            }

        }
    }


}