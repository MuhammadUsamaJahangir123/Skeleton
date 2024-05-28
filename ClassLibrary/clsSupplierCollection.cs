using System;
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

            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tbSupplier_SelectAll");
            RecordCount = DB.Count;
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