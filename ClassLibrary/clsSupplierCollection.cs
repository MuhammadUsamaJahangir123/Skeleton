using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        List<clsSupplier>mSupplierList = new List<clsSupplier>();
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
        public clsSupplier ThisSupplier { get; set; }
    }
}