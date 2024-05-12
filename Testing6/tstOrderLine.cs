using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we wat to create
            clsOrderLine AnOrderLine = new clsOrderLine();

            //test to see that it exists
            Assert.IsNotNull(AnOrderLine);
        }

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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderLineID = 2;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineID);
            //test to see if the result is true
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestOrderLineIdFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderLineId = 2;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineId);
            //check the address id property
            if (AnOrderLine.OrderLineID != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderLineId = 2;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineId);
            //check the address id property
            if (AnOrderLine.OrderID != 11)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductIdFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderLineId = 2;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineId);
            //check the address id property
            if (AnOrderLine.ProductID != 13)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderLineId = 2;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineId);
            //check the address id property
            if (AnOrderLine.Quantity != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
