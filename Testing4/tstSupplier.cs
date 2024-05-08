using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Assert.IsNotNull(ASupplier);
        }
        
        [TestMethod]
        public void ActivePropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean TestData = true;
            ASupplier.Active = TestData;
            Assert.AreEqual(ASupplier.Active, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            ASupplier.DateAdded = TestData;
            Assert.AreEqual(ASupplier.DateAdded, TestData);
        }
        [TestMethod]
        public void SupplierIdPropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Int32 TestData = 1;
            ASupplier.SupplierId = TestData;
            Assert.AreEqual(ASupplier.SupplierId,TestData);
        }
        [TestMethod]
        public void ContactInfoPropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            String TestData = "GURJ@GMAIL.COM";
            ASupplier.ContactInfo = TestData;
            Assert.AreEqual(ASupplier.ContactInfo, TestData);
        }

        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            String TestData = "GURJOT";
            ASupplier.SupplierName = TestData;
            Assert.AreEqual(ASupplier.SupplierName, TestData);
        }


    }
}

