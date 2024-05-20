using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstSupplier
    {
        //good test data
        string SupplierId = "12b";
        string SupplierName = "Gurj";
        string SupplierContact = "something";
        string SupplierActivity = "yes";
        string SupplierDate = DateTime.Now.ToShortDateString();
        


        [TestMethod]
        public void InstanceOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Assert.IsNotNull(ASupplier);
        }

        [TestMethod]
        public void SupplierActivityOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean TestData = true;
            ASupplier.SupplierActivity = TestData;
            Assert.AreEqual(ASupplier.SupplierActivity, TestData);
        }
        [TestMethod]
        public void SupplierDatePropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            ASupplier.SupplierDate = TestData;
            Assert.AreEqual(ASupplier.SupplierDate, TestData);
        }
        [TestMethod]
        public void SupplierIdPropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Int32 TestData = 5;
            ASupplier.SupplierId = TestData;
            Assert.AreEqual(ASupplier.SupplierId, TestData);
        }
        [TestMethod]
        public void SupplierContactPropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            String TestData = "gurjot@gmail.com";
            ASupplier.SupplierContact = TestData;
            Assert.AreEqual(ASupplier.SupplierContact, TestData);
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
        public void SupplierShippingTimeOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Int32 TestData = 5;
            ASupplier.SupplierShippingTime = TestData;
            Assert.AreEqual(ASupplier.SupplierShippingTime, TestData);
        }
        [TestMethod]
        public void SupplierPostCodeOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            String TestData = "LE5 5EL";
            ASupplier.SupplierPostCode = TestData;
            Assert.AreEqual(ASupplier.SupplierPostCode, TestData);
        }


        [TestMethod]
        public void FindMethod()
        {
            //create new instance
            clsSupplier ASupplier = new clsSupplier();
            //create boolean variable to store results of validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 SupplierId = 5;
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
            Int32 SupplierId = 5;
            //invoke the method
            Found = ASupplier.Find(SupplierId);
            //check the Staff ID
            if (ASupplier.SupplierId != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = true;
            Boolean OK = true;
            Int32 SupplierId = 5;
            Found = ASupplier.Find(SupplierId);
            if (ASupplier.SupplierDate != Convert.ToDateTime("02/03/2024"))
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
            Int32 SupplierId = 5;
            Found = ASupplier.Find(SupplierId);
            if (ASupplier.SupplierActivity != true)
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
            Int32 SupplierId = 5;
            Found = ASupplier.Find(SupplierId);
            if (ASupplier.SupplierContact != "Gurjot@gmail.com")
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
            Int32 SupplierId = 5;
            Found = ASupplier.Find(SupplierId);
            if (ASupplier.SupplierName != "Gurj")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()     
        {
            //create an instance of Supplier class
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store error message
            String Error =  "";
            //invoke the method
            Error = ASupplier.Valid(SupplierId, SupplierName, SupplierDate, SupplierActivity, SupplierContact);
            Assert.AreEqual(Error, "");

        }
    }

}


       
    


