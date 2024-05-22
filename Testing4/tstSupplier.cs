using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing4
{
    [TestClass]
    public class tstSupplier
    {
        //good test data
        string supplierId = "12b";
        string supplierName = "Gurj";
        string supplierContact = "something";
        string supplierActivity = "yes";
        string supplierDate = DateTime.Now.ToShortDateString();
        string supplierShippingTime = "5";
        string supplierPostCode = "LE5 2ER";



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
        public void TestSupplierShippingTimeFound()
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
            //check the supplier Id
            if (ASupplier.SupplierShippingTime != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierPostCodeFound()
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
            //check the supplier post code
            if (ASupplier.SupplierPostCode != "LE5 2ER")
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
            String Error = "";
            //invoke the method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact,  supplierPostCode);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void SupplierPostCodeMinLessOne()
        {
            // create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string supplierPostCode = "";

            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact,  supplierPostCode);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierPostCodeMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string supplierPostCode = "a"; //this should be ok
            //invoke the method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierPostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string supplierPostCode = "aa"; //this should be ok
                                            //invoke the method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierPostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string supplierPostCode = "aaaaaaaa"; //this should be ok
                                                  //invoke the method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierPostCodeMax()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string supplierPostCode = "aaaaaaaaa"; //this should be ok
                                                   //invoke the method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierPostCodeMid()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string supplierPostCode = "aaa"; //this should be ok
            //invoke the method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierPostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string supplierPostCode = "aaaaaaaaaa"; //this should fail
            //invoke the method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void SupplierPostCodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string supplierPostCode = "";
            supplierPostCode = supplierPostCode.PadRight(500, 'a');//should fail
            //invoke the method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void SupplierDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store data 
            DateTime TestDate;
            //set date to today
            TestDate = DateTime.Now.Date;
            //Change the date to 100 years ago
            TestDate = TestDate.AddYears(-100);
            //convert date variable to string variable
            string supplierDate = TestDate.ToString();
            //invoke method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void SupplierDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store data 
            DateTime TestDate;
            //set date to today
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string supplierDate = TestDate.ToString();
            //invoke the method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierDateMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store data 
            DateTime TestDate;
            //set date to today
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string supplierDate = TestDate.ToString();
            //invoke method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store data 
            DateTime TestDate;
            //set date to today
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string supplierDate = TestDate.ToString();
            //invoke method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store data 
            DateTime TestDate;
            //set date to today
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string supplierDate = TestDate.ToString();
            //invoke method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void SupplierDateInvalidData()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string supplierDate = "this is not a date!";
            //invoke the method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //
        //
        //
        //
        //
        //
        //
        
        [TestMethod]
        public void SupplierNameMinLessOne()
        {
            // create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string supplierName = "";

            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string supplierName = "a"; //this should be ok
            //invoke the method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string supplierName = "aa"; //this should be ok
                                            //invoke the method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string supplierName = "";
            supplierName = supplierName.PadRight(49, 'a');//should pass
                                                           //invoke the method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMax()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string supplierName = "";
            supplierName = supplierName.PadRight(50, 'a');//should pass
                                                           //invoke the method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMid()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string supplierName = "";
            supplierName = supplierName.PadRight(25, 'a');//should pass     
            //invoke the method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string supplierName = "";
            supplierName = supplierName.PadRight(51, 'a');//should fail
            //invoke the method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void SupplierNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string supplierName = "";
            supplierName = supplierName.PadRight(500, 'a');//should fail
            //invoke the method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        //
        //  SupplierContact
        //  supplierContact
        //
        //
        //
        //
        //
        [TestMethod]
        public void SupplierContactMinLessOne()
        {
            // create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string supplierContact = "";

            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierContactMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string supplierContact = "a"; //this should be ok
            //invoke the method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierContactMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string supplierContact = "aa"; //this should be ok
                                        //invoke the method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierContactMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string supplierContact = "";
            supplierContact = supplierContact.PadRight(49, 'a');//should pass
                                                          //invoke the method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierContactMax()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string supplierContact = "";
            supplierContact = supplierContact.PadRight(50, 'a');//should pass
                                                          //invoke the method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierContactMid()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string supplierContact = "";
            supplierContact = supplierContact.PadRight(25, 'a');//should pass     
            //invoke the method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact , supplierPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierContactMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string supplierContact = "";
            supplierContact = supplierContact.PadRight(51, 'a');//should fail
            //invoke the method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void SupplierContactExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string supplierContact = "";
            supplierContact = supplierContact.PadRight(500, 'a');//should fail
            //invoke the method
            Error = ASupplier.Valid(supplierName, supplierDate, supplierContact, supplierPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

    }
}


       
    


