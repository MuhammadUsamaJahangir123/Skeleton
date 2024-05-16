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
        {  //create an instance of a class we want to create
            clsStock AnStock = new clsStock();
            //test to see eif it exists
            Assert.IsNotNull(AnStock);
        }
        [TestMethod]
        public void ProductIdPropertyOK()
        {
            //create an instance of the classs we want to create 
            clsStock AnStock = new clsStock();
            //create test data to assign to the property
            int TestData = true;
            //assign the data to the property
            AnStock.ProductId = TestData;
            //test to see if two values match
            Assert.AreEqual(AnStock.ProductId, TestData);
        }   
        [TestMethod]
        public void IsAvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property 
            AnStock.IsAvailable = TestData;
            //testing to see if the two values are a match
            Assert.AreEqual(AnStock.IsAvailable, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class i want to create
            clsStock AnStock = new clsStock();
            //create test data 2 assign 2 property
            DateTime TestData = DateTime.Now.Date;
            //assign data 2 property
            AnStock.DateAdded = TestData;
            //test 2 see if 2 values r the same
            Assert.AreEqual(AnStock.DateAdded, TestData);
        }
        [TestMethod]
        public void ProductNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock;
            //create test data to assign to the property
            string TestData = "";
            //assign the data to the property
            AnStock.ProductName = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnStock.ProductName, TestData);
        }
        [TestMethod]
        public void StockQuantityPropertyOK()
        {
            //create an instance for the class we want to create 
            clsStock AnStock = new clsStock();
            //create test data 2 assign to the property
            int TestData = 1;
            //assign data to the property
            AnStock.StockQuantity = TestData
            //test to see that the two values r the same
            Assert.AreEqual(AnStock.StockQuantity, TestData);
        }
        [TestMethod]
        public void RestockPropertyOK()
        {
            //create an instance for the class we want to create
            clsStock AnStock = new clsStock();
            //create test data 2 assign to the property
            Boolean TestData = true;
            //assign data to the property
            AnStock.Restock = TestData;
            //test to see if the two values r the same
            Assert.AreEqual(AnStock.Restock, TestData);
        }
        [TestMethod]
        public void ProductPricePropertyOK()
        {
            //create an instance for the class we want to create
            clsStock AnStock = new clsStock();
            //create the test data to assign 2 the property
            decimal TestData = 1;
            //assign data to the property
            AnStock.ProductPrice = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnStock.ProductPrice, TestData;
        }
        [Test Method]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store results of the validation
            Boolean Found  = false;
            //create some test data with the method
            Boolean IsAvailable = false;
            //invoke the method
            Found = AnStock.Find(IsAvailable);
            //test to see if result is true
            Assert.IsTrue(Found);
        }

    }

    class clsStock
    {
        internal bool Find(bool isAvailable)
        {
            throw new NotImplementedException();
        }
    }
}



    