using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstAttributeOrderLine
    {
        [TestMethod]
        public void OrderLineIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderLine.OrderLineID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.OrderLineID, TestData);
        }
        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderLine.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.OrderID, TestData);
        }
        [TestMethod]
        public void ProductIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderLine.ProductID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.ProductID, TestData);
        }
        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderLine.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.Quantity, TestData);
        }
    }
    
}
