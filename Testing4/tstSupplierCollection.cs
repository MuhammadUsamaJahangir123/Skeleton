using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of the class we want to create
            clsSupplierCollection ALLSupplier = new clsSupplierCollection();
            //test to see that it exists
            Assert.IsNotNull(ALLSupplier);
        }
        [TestMethod]
        public void SupplierListOK()
        {
            //create instance of the class we want to create
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //create a list
            List<clsSupplier> TestList = new List<clsSupplier>();
            //create the item of the test data
            clsSupplier TestItem = new clsSupplier();
            //set its properties
            TestItem.SupplierActivity = true;
            TestItem.SupplierId = 1;
            TestItem.SupplierName = "Gurj";
            TestItem.SupplierContact = "Gurjot@gmail.com";
            TestItem.SupplierDate = DateTime.Now;
            TestItem.SupplierShippingTime = 1;
            TestItem.SupplierPostCode = "LE5 4EX";
            //add item to test list
            TestList.Add(TestItem);
            //assign data to property
            AllSupplier.SupplierList = TestList;
            //test to see if the two values are the same
            Assert.AreEqual(AllSupplier.SupplierList, TestList);


        }


        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            //create instance of the class we want to create
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //create some test data
            clsSupplier TestSupplier = new clsSupplier();
            //set properties of test object
            TestSupplier.SupplierActivity = true;
            TestSupplier.SupplierId = 1;
            TestSupplier.SupplierShippingTime = 1;
            TestSupplier.SupplierContact = "Gurj@Gmail.com";
            TestSupplier.SupplierDate = DateTime.Now;
            TestSupplier.SupplierName = "Gurj";
            TestSupplier.SupplierPostCode = "LE54EX";
            //assign data to property
            AllSupplier.ThisSupplier = TestSupplier;
            //test to see if the two values are the same
            Assert.AreEqual(AllSupplier.ThisSupplier, TestSupplier);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create instance of the class we want to create
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //create list
            List<clsSupplier> TestList = new List<clsSupplier>();
            //add an item to the list
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //set properties of test data
            TestItem.SupplierName = "Gurj";
            TestItem.SupplierContact = "Gurj@gmail.com";
            TestItem.SupplierDate = DateTime.Now;
            TestItem.SupplierPostCode = "LE5 4EX";
            TestItem.SupplierId = 1;
            TestItem.SupplierActivity = true;
            TestItem.SupplierShippingTime = 1;
            //assign item to the test list
            TestList.Add(TestItem);
            //assign data to property
            AllSupplier.SupplierList = TestList;
            //test to see if the two values are the same
            Assert.AreEqual(AllSupplier.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create instance of the class we want to create
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //create the item of the test data
            clsSupplier TestItem = new clsSupplier();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.SupplierName = "Gurj";
            TestItem.SupplierContact = "Gurj@gmail.com";
            TestItem.SupplierDate = DateTime.Now;
            TestItem.SupplierPostCode = "LE5 4EX";
            TestItem.SupplierId = 1;
            TestItem.SupplierActivity = true;
            TestItem.SupplierShippingTime = 1;
            //assign data to property
            AllSupplier.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = AllSupplier.Add();
            //find the record
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            //test to see if the two values are the same
            Assert.AreEqual(AllSupplier.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create instance of the class we want to create
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.SupplierName = "Gurj";
            TestItem.SupplierContact = "Gurj@gmail.com";
            TestItem.SupplierDate = DateTime.Now;
            TestItem.SupplierPostCode = "LE5 4EX";
            TestItem.SupplierActivity = true;
            TestItem.SupplierShippingTime = 1;
            //set ThisSupplier to the test data
            AllSupplier.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = AllSupplier.Add();
            //modify the record
            TestItem.SupplierId = PrimaryKey;
            TestItem.SupplierActivity = false;
            TestItem.SupplierShippingTime = 5;
            TestItem.SupplierContact = "Alexsx@gmail.com";
            TestItem.SupplierDate = DateTime.Now;
            TestItem.SupplierPostCode = "LE7 3EX";
            TestItem.SupplierName = "Alex";
            //set the record based on the new test data
            AllSupplier.ThisSupplier = TestItem;
            //update the record
            AllSupplier.Update();
            //find the record
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            //test to see if ThisSupplier matches the test data
            Assert.AreEqual(AllSupplier.ThisSupplier, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            //create instance of the class we want to create
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //variable to store primaary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.SupplierName = "Gurj";
            TestItem.SupplierContact = "Gurj@gmail.com";
            TestItem.SupplierDate = DateTime.Now;
            TestItem.SupplierPostCode = "LE5 4EX";
            TestItem.SupplierActivity = true;
            TestItem.SupplierShippingTime = 1;
            //set ThisSupplier to the test data
            AllSupplier.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = AllSupplier.Add();
            //set the primary key of the test data
            TestItem.SupplierId = PrimaryKey;
            //find the record
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            //delete the record
            AllSupplier.Delete();
            //now find the record
            Boolean Found = AllSupplier.ThisSupplier.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByPostCodeMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //create an instance of the filtered data
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            //apply a blank string (should return all record)
            FilteredSuppliers.ReportByPostCode("");
            //test to see that the two values are the same
            Assert.AreEqual(AllSupplier.Count, FilteredSuppliers.Count);
        }


        [TestMethod]
        public void ReportByPostCodeNoneFound()
        {
            //create an instance of the class we want to create
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            //apply a postcode that doesn't exist
            FilteredSuppliers.ReportByPostCode("LE99AA");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredSuppliers.Count);
        }



        [TestMethod]
        public void ReportByPostCodeTestDataFound()
        {
            //create an instance of the filtered data
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a PostCode
            FilteredSuppliers.ReportByPostCode("LE5 5ED");
            //check that the correct number of records are found
            if (FilteredSuppliers.Count == 2)
            {
                //check to see that the first record is 1
                if (FilteredSuppliers.SupplierList[0].SupplierId != 1)
                {
                    OK = false;
                }
                //check to see that the second record is 12
                if (FilteredSuppliers.SupplierList[1].SupplierId != 12)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }




    }




}

