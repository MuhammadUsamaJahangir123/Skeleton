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
            Assert.AreEqual (AllSupplier.ThisSupplier, TestItem);
        }
      
        
    }
}
