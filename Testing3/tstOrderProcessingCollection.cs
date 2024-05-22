using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstOrderProcessingCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessingCollection AllOrderProcessings = new clsOrderProcessingCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrderProcessings);
        }

        [TestMethod]
        public void OrderProcessingListOK()
        {
            //create am instance of the class we want to create
            clsOrderProcessingCollection AllOrderProcessings = new clsOrderProcessingCollection();
            //create some test data to assign to property
            //in this case test the data meeds to be a list of objects
            List<clsOrderProcessing> TestList = new List<clsOrderProcessing>();
            //add an Item to the lsit of test data
            clsOrderProcessing TestItem = new clsOrderProcessing();
            //set its properties
            TestItem.OrderId = 1;
            TestItem.CustomerId = 2;
            TestItem.StaffId = 3;
            TestItem.TotalAmount = 25m;
            TestItem.ShippingStatus = true;
            TestItem.OrderDate = DateTime.Now;
            TestItem.ShippingAddress = "beststreet";
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllOrderProcessings.OrderProcessingList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllOrderProcessings.OrderProcessingList, TestList);
        }

        [TestMethod]
        public void ThisOrderProcessingPropertyOK()
        {
            //create am instance of the class we want to create
            clsOrderProcessingCollection AllOrderProcessings = new clsOrderProcessingCollection();
            //create some test data to assign to property
            clsOrderProcessing TestOrderProcessing = new clsOrderProcessing();
            //set the properties of the test object
            TestOrderProcessing.OrderId = 1;
            TestOrderProcessing.CustomerId = 2;
            TestOrderProcessing.StaffId = 3;
            TestOrderProcessing.TotalAmount = 25m;
            TestOrderProcessing.ShippingStatus = true;
            TestOrderProcessing.OrderDate = DateTime.Now;
            TestOrderProcessing.ShippingAddress = "beststreet";
            //Assign the data to the property
            AllOrderProcessings.ThisOrderProcessing = TestOrderProcessing;
            //Test to see that the two values are the same
            Assert.AreEqual(AllOrderProcessings.ThisOrderProcessing, TestOrderProcessing);
        }
        
        [TestMethod]
        public void ListAndCountOK()
        {
            //create am instance of the class we want to create
            clsOrderProcessingCollection AllOrderProcessings = new clsOrderProcessingCollection();
            //create some test data to assign to property
            //in this case test the data meeds to be a list of objects
            List<clsOrderProcessing> TestList = new List<clsOrderProcessing>();
            //add an Item to the list
            //Create the item of test data
            clsOrderProcessing TestItem = new clsOrderProcessing();
            //set its properties
            TestItem.OrderId = 1;
            TestItem.CustomerId = 2;
            TestItem.StaffId = 3;
            TestItem.TotalAmount = 25m;
            TestItem.ShippingStatus = true;
            TestItem.OrderDate = DateTime.Now;
            TestItem.ShippingAddress = "beststreet";
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllOrderProcessings.OrderProcessingList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllOrderProcessings.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //Create an instance of the class we want to create
            clsOrderProcessingCollection AllOrderProcessings = new clsOrderProcessingCollection();
            //create the item of test data
            clsOrderProcessing TestItem = new clsOrderProcessing();
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderId = 1;
            TestItem.CustomerId = 4;
            TestItem.StaffId = 3;
            TestItem.TotalAmount = 25m;
            TestItem.ShippingStatus = true;
            TestItem.OrderDate = DateTime.Now;
            TestItem.ShippingAddress = "beststreet";
            //set thisOrderProcessing to the test data
            AllOrderProcessings.ThisOrderProcessing = TestItem;
            //add the record
            PrimaryKey = AllOrderProcessings.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrderProcessings.ThisOrderProcessing.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderProcessings.ThisOrderProcessing, TestItem);


        }
    }
}
