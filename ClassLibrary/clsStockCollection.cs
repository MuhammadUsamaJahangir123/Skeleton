using System.Collections.Generic;
using System.Runtime.Remoting.Channels;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();

        //public property for the STock List
        public List<clsStock> StockList
        {
            get
            {
                //set the private data
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return StockList.Count;
            }
            set
            {
                //worry abt l8r
            }
        }
        public clsStock ThisStock { get; set; }
        
    }
}