using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AnStock);  
        }
        [TestMethod]
        public void RestockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStock.Restock = TestData;
            //test to see the values are the same
            Assert.AreEqual(AnStock.Restock, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStock.DateAdded = TestData;
            //test to see if the two values r the same
            Assert.AreEqual(AnStock.DateAdded, TestData);
        }
        [TestMethod]
        public void ProductIdPropertyOK()
        {
            //create a new instnce of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the rpoperty
            Int32 TestData = 1;
            //assign data to the property
            AnStock.ProductId = TestData;
            //test to see that the values r the same
            Assert.AreEqual(AnStock.ProductId, TestData);   
        }
        [TestMethod]
        public void IsAvailablePropertyOK()
        {
            //create an instance of the clas wwe want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign data to the property
            AnStock.IsAvailable = TestData;
            //test to see that the two values r the same
            Assert.AreEqual(AnStock.IsAvailable, TestData); 
        }
        [TestMethod]
        public void ProductNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "BlueCap";
            //assign the data to the property
            AnStock.ProductName = TestData;
            //tst to see that the two values r the same
            Assert.AreEqual(AnStock.ProductName, TestData);
        }
        [TestMethod]
        public void ProductPricePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            decimal TestData = 25.70M;
            //assign the data to the property
            AnStock.ProductPrice = TestData;
            //test to see that the two values r the same
            Assert.AreEqual(AnStock.ProductPrice, TestData);
        }
        [TestMethod]
        public void StockQuantityPropertyOK()
        {
            //create an instance of the class we wabt to crete
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            int TestData = 7;
            //asign the data to the property
            AnStock.StockQuantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.StockQuantity, TestData);
        }
    }
}
