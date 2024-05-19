using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Restock { get; set; }
        public DateTime DateAdded { get; set; }
        public int ProductId { get; set; }
        public bool IsAvailable { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int StockQuantity { get; set; }
    }
}