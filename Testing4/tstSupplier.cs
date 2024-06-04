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
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //test to see that it exists 
            Assert.IsNotNull(ASupplier);
        }

        [TestMethod]
        public void SupplierActivityOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ASupplier.SupplierActivity = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ASupplier.SupplierActivity, TestData);
        }
        [TestMethod]
        public void SupplierDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ASupplier.SupplierDate = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ASupplier.SupplierDate, TestData);
        }
        [TestMethod]
        public void SupplierIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            Int32 TestData = 5;
            //assign the data to the property
            ASupplier.SupplierId = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ASupplier.SupplierId, TestData);
        }
        [TestMethod]
        public void SupplierContactPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            String TestData = "gurjot@gmail.com";
            //assign the data to the property
            ASupplier.SupplierContact = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ASupplier.SupplierContact, TestData);
        }

        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            String TestData = "Gurj";
            //assign the data to the property
            ASupplier.SupplierName = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ASupplier.SupplierName, TestData);
        }

        [TestMethod]
        public void SupplierShippingTimeOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            Int32 TestData = 5;
            //assign the data to the property
            ASupplier.SupplierShippingTime = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ASupplier.SupplierShippingTime, TestData);
        }
        [TestMethod]
        public void SupplierPostCodeOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            String TestData = "LE5 5EL";
            //assign the data to the property
            ASupplier.SupplierPostCode = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ASupplier.SupplierPostCode, TestData);
        }


        [TestMethod]
        public void FindMethod()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create boolean variable to store results of validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 SupplierId = 5;
            //invoke the method
            Found = ASupplier.Find(SupplierId);
            //test to see if the record is found
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
            //check the SupplierId
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
            //check the SupplierDate
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
            //check the supplier Shipping Time
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
            //check the supplier activity
            if (ASupplier.SupplierActivity != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestContactInfo()
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
            //check the supplier contact
            if (ASupplier.SupplierContact != "Gurjot@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierName()
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
            //check the supplier name
            if (ASupplier.SupplierName != "Gurj")
            {
                OK = false;
            }
            //test to see that the result is correct
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
            //test to see that the result is correct
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


       
    


