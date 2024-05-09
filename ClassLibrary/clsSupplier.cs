using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int SupplierId { get; set; }
        public string ContactInfo { get; set; }
        public string SupplierName { get; set; }

        public bool Find(int supplierId)
        {
            return true;
        }
    }
}