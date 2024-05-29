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
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.SupplierActivity = true;
            TestItem.SupplierId = 1;
            TestItem.SupplierName = "Gurj";
            TestItem.SupplierContact = "Gurjot@gmail.com";
            TestItem.SupplierDate = DateTime.Now;
            TestItem.SupplierShippingTime = 1;
            TestItem.SupplierPostCode = "LE5 4EX";
            TestList.Add(TestItem);
            AllSupplier.SupplierList = TestList;
            Assert.AreEqual(AllSupplier.SupplierList, TestList);


        }


        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();
            TestSupplier.SupplierActivity = true;
            TestSupplier.SupplierId = 1;
            TestSupplier.SupplierShippingTime = 1;
            TestSupplier.SupplierContact = "Gurj@Gmail.com";
            TestSupplier.SupplierDate = DateTime.Now;
            TestSupplier.SupplierName = "Gurj";
            TestSupplier.SupplierPostCode = "LE54EX";
            AllSupplier.ThisSupplier = TestSupplier;
            Assert.AreEqual(AllSupplier.ThisSupplier, TestSupplier);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.SupplierName = "Gurj";
            TestItem.SupplierContact = "Gurj@gmail.com";
            TestItem.SupplierDate = DateTime.Now;
            TestItem.SupplierPostCode = "LE5 4EX";
            TestItem.SupplierId = 1;
            TestItem.SupplierActivity = true;
            TestItem.SupplierShippingTime = 1;
            TestList.Add(TestItem);
            AllSupplier.SupplierList = TestList;
            Assert.AreEqual(AllSupplier.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.SupplierName = "Gurj";
            TestItem.SupplierContact = "Gurj@gmail.com";
            TestItem.SupplierDate = DateTime.Now;
            TestItem.SupplierPostCode = "LE5 4EX";
            TestItem.SupplierId = 1;
            TestItem.SupplierActivity = true;
            TestItem.SupplierShippingTime = 1;
            AllSupplier.ThisSupplier = TestItem;
            PrimaryKey = AllSupplier.Add();
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSupplier.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.SupplierName = "Gurj";
            TestItem.SupplierContact = "Gurj@gmail.com";
            TestItem.SupplierDate = DateTime.Now;
            TestItem.SupplierPostCode = "LE5 4EX";
            TestItem.SupplierActivity = true;
            TestItem.SupplierShippingTime = 1;
            AllSupplier.ThisSupplier = TestItem;
            PrimaryKey = AllSupplier.Add();
            TestItem.SupplierId = PrimaryKey;
            TestItem.SupplierActivity = false;
            TestItem.SupplierShippingTime = 5;
            TestItem.SupplierContact = "Alexsx@gmail.com";
            TestItem.SupplierDate = DateTime.Now;
            TestItem.SupplierPostCode = "LE7 3EX";
            TestItem.SupplierName = "Alex";
            AllSupplier.ThisSupplier = TestItem;
            AllSupplier.Update();
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSupplier.ThisSupplier, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.SupplierName = "Gurj";
            TestItem.SupplierContact = "Gurj@gmail.com";
            TestItem.SupplierDate = DateTime.Now;
            TestItem.SupplierPostCode = "LE5 4EX";
            TestItem.SupplierActivity = true;
            TestItem.SupplierShippingTime = 1;
            AllSupplier.ThisSupplier = TestItem;
            PrimaryKey = AllSupplier.Add();
            TestItem.SupplierId = PrimaryKey;
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            AllSupplier.Delete();
            Boolean Found = AllSupplier.ThisSupplier.Find(PrimaryKey);
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
            //apply an Email that doesn't exist
            FilteredSuppliers.ReportByPostCode("LE55AA");
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
            //apply an Email 
            FilteredSuppliers.ReportByPostCode("LE5 5ED");
            //check that the correct number of records are found
            if (FilteredSuppliers.Count == 2)
            {
                //check to see that the first record is 1
                if (FilteredSuppliers.SupplierList[0].SupplierId != 1)
                {
                    OK = false;
                }
                //check to see that the first record is 27
                if (FilteredSuppliers.SupplierList[1].SupplierId != 27)
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

