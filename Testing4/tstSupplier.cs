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
            String TestData = "gurjot@gmail.com";
            ASupplier.ContactInfo = TestData;
            Assert.AreEqual(ASupplier.ContactInfo, TestData);
        }

        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            String TestData = "Gurj";
            ASupplier.SupplierName = TestData;
            Assert.AreEqual(ASupplier.SupplierName, TestData);
        }

        [TestMethod]
        public void FindMethod()
        {
            //create new instance
            clsSupplier ASupplier = new clsSupplier();
            //create boolean variable to store results of validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = ASupplier.Find(SupplierId);
            //test to see if the results is true
            Assert.IsTrue(Found);
                    
        }
        [TestMethod]
        public void TestSupplierIdFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create a Boolean variable to store the result of the search
            Boolean Found = true;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = ASupplier.Find(SupplierId);
            //check the Staff ID
            if (ASupplier.SupplierId != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        { clsSupplier ASupplier = new clsSupplier();
            Boolean Found = true;
            Boolean OK = true;
            Int32 SupplierId = 21;
            Found= ASupplier.Find(SupplierId);
            if (ASupplier.DateAdded != Convert.ToDateTime("02/03/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestActive()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = true;
            Boolean OK = true;
            Int32 SupplierId = 21;
            Found = ASupplier.Find(SupplierId);
            if (ASupplier.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestContactInfo()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = true;
            Boolean OK = true;
            Int32 SupplierId = 21;
            Found = ASupplier.Find(SupplierId);
            if (ASupplier.ContactInfo != "Gurjot@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierName() 
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = true;
            Boolean OK = true;
            Int32 SupplierId = 21;
            Found = ASupplier.Find(SupplierId);
            if (ASupplier.SupplierName != "Gurj")
            {  
                OK = false; 
            }
            Assert.IsTrue(OK);
        }

        
        

    }
}

