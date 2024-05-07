using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstAttributeOrderProcessing
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //test to see that it exists
            Assert.IsNotNull(AnOrderProcessing);
        }
        [TestMethod]
        public void ShippingStatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrderProcessing.ShippingStatus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderProcessing.ShippingStatus, TestData);
        }
        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrderProcessing.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderProcessing.OrderDate, TestData);
        }
        [TestMethod]
        public void TotalAmountPropertyOK()
        {
            // Create an instance of the class we want to test
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            // Create some test data to assign to the property
            decimal TestData = 10.5m; // Example test value
            // Assign the data to the property
            AnOrderProcessing.TotalAmount = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrderProcessing.TotalAmount, TestData);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderProcessing.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderProcessing.OrderID, TestData);
        }
        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderProcessing.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderProcessing.CustomerID, TestData);
        }
        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderProcessing.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderProcessing.StaffID, TestData);
        }

         
    }
}
