using System;

namespace ClassLibrary
{
    public class clsOrderProcessing
    {
        public bool ShippingStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int StaffID { get; set; }
    }
}