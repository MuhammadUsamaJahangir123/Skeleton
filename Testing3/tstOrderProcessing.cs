﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstOrderProcessing
    {

        
            //create test data to pass method
            string OrderDate = DateTime.Now.ToShortDateString();

        


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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderId = 4;
            //invoke the method
            Found = AnOrderProcessing.Find(OrderId);
            //test to see if the result is true
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 4;
            //invoke the method
            Found = AnOrderProcessing.Find(OrderId);
            //check the address id property
            if (AnOrderProcessing.OrderID != 4)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 4;
            //invoke the method
            Found = AnOrderProcessing.Find(OrderId);
            //check the address id property
            if (AnOrderProcessing.CustomerID != 11)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 4;
            //invoke the method
            Found = AnOrderProcessing.Find(OrderId);
            //check the address id property
            if (AnOrderProcessing.StaffID != 15)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 4;
            //invoke the method
            Found = AnOrderProcessing.Find(OrderId);
            //check the date added property
            if (AnOrderProcessing.OrderDate != Convert.ToDateTime("23/12/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShippingStatusFound()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 4;
            //invoke the method
            Found = AnOrderProcessing.Find(OrderId);
            //check the active property
            if (AnOrderProcessing.ShippingStatus != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalAmountFound()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 4;
            //invoke the method
            Found = AnOrderProcessing.Find(OrderId);
            //check the active property
            if (AnOrderProcessing.TotalAmount != Convert.ToDecimal("25"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //string variable to store any error message
            string Error = "";
            //invoke the method
            Error = AnOrderProcessing.Valid(OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



    }
}
