using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //Test to see that it exists
            Assert.IsNotNull(AllCustomer);
        }
        [TestMethod]
        public void CustomerListOK()
        {
            //create am instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to property
            //in this case test the data meeds to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //ass an Item to the of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.subscribe = true;
            TestItem.customerID = 1;
            TestItem.firstName = "Jonny";
            TestItem.lastName = "Lenon";
            TestItem.PhoneNo = "07404535912";
            TestItem.email = "JonnyLenon@gmail.com";
            TestItem.joinedDate = DateTime.Now;
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllCustomers.CustomerList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }
       /** [TestMethod]
        public void CountPropertyOK()
        {
            //create am instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllCustomers.Count = SomeCount;
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        } **/
        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create am instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.email = "JonnyLenon@gmail.com";
            TestCustomer.customerID = 1;
            TestCustomer.subscribe = true;
            TestCustomer.firstName = "Jonny";
            TestCustomer.lastName = "Lenon";
            TestCustomer.PhoneNo = "07404535912";
            TestCustomer.joinedDate = DateTime.Now;
            //Assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //Test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create am instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to property
          
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //Create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its proeprties
            TestItem.subscribe = true;
            TestItem.email = "JonnyLenon@gmail.com";
            TestItem.customerID = 1;
            TestItem.firstName = "Jonny";
            TestItem.lastName = "Lenon";
            TestItem.joinedDate = DateTime.Now;
            TestItem.PhoneNo = "07404535912";
            //add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the proprty
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);

        }
        /**  [TestMethod]
          public void TwoRecordPresent()
          {
              //create an instance of the class we want to create
              clsCustomerCollection AllCustomer = new clsCustomerCollection();
              //test to see that the two values are the same
              Assert.AreEqual(AllCustomer.Count, 2);
          } **/
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 1;
            //set its properties
            TestItem.subscribe = true;
            TestItem.firstName = "Dia";
            TestItem.lastName = "Pia";
            TestItem.PhoneNo = "07909535912";
            TestItem.joinedDate = DateTime.Now;
            TestItem.email = "DiaPia@gmail.com";
            //set the customer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary let of the test data 
            TestItem.customerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }
        [TestMethod]
        public void UpdateMethodOK() 
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //varaible to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.subscribe = true;
            TestItem.firstName = "Dia";
            TestItem.lastName = "Pia";
            TestItem.PhoneNo = "07909535912";
            TestItem.joinedDate = DateTime.Now;
            TestItem.email = "DiaPia@gmail.com";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record 
            PrimaryKey = AllCustomers.Add();
            //set the primary of the test data
            TestItem.customerID = PrimaryKey;
            //Modify the test record 
            TestItem.subscribe = false;
            TestItem.firstName = "Karen";
            TestItem.lastName = "Leo";
            TestItem.PhoneNo = "07808535912";
            TestItem.joinedDate = DateTime.Now;
            TestItem.email = "KarenLeo@gmail.com";
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //Update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see of thiscustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }
    } 
}

