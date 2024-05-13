using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        string PhoneNo = "07404535912";
        string email = "JonnyLenon@gmail.com";
        string firstName = "Jonny";
        string lastName = "Lenon";
        string joinedDate = DateTime.Now.ToShortDateString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists 
            Assert.IsNotNull(AnCustomer);
        }
        /***************Property OK Tests ****************/
        [TestMethod]
        public void subscribePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnCustomer.subscribe = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.subscribe, TestData);
        }
        [TestMethod]
        public void DatejoinedPropertyOK()
        {

            clsCustomer AnCustomer = new clsCustomer();

            DateTime TestData = DateTime.Now.Date;

            AnCustomer.joinedDate = TestData;

            Assert.AreEqual(AnCustomer.joinedDate, TestData);
        }
        [TestMethod]
        public void firstNamePropertyOK()
        {

            clsCustomer AnCustomer = new clsCustomer();

            string TestData = "Jonny";

            AnCustomer.firstName = TestData;

            Assert.AreEqual(AnCustomer.firstName, TestData);
        }
        [TestMethod]
        public void lastNamePropertyOK()
        {

            clsCustomer AnCustomer = new clsCustomer();

            string TestData = "Lenon";

            AnCustomer.lastName = TestData;

            Assert.AreEqual(AnCustomer.lastName, TestData);
        }

        [TestMethod]
        public void emailPropertyOK()
        {

            clsCustomer AnCustomer = new clsCustomer();

            string TestData = "JonnyLenon@gmail.com";

            AnCustomer.email = TestData;

            Assert.AreEqual(AnCustomer.email, TestData);
        }
        [TestMethod]
        public void customerIDPropertyOK()
        {

            clsCustomer AnCustomer = new clsCustomer();

            Int32 TestData = 21;

            AnCustomer.customerID = TestData;

            Assert.AreEqual(AnCustomer.customerID, TestData);
        }

        [TestMethod]
        public void PhoneNoPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();

            string TestData = "07404535912";

            AnCustomer.PhoneNo = TestData;

            Assert.AreEqual(AnCustomer.PhoneNo, TestData);

        }
        //Practical 9 Find and Valid Methods
        /***************Find Method Test ****************/

        [TestMethod]
        public void FindMethodOK()
        {
            //create instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean varaible to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 customerID = 1;
            //invoke the method
            Found = AnCustomer.Find(customerID);
            //Test to see if the results is ture
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestcustomerIDFound()
        {
            //Create instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Create a boolean variable to store the results of the search
            Boolean Found = false;
            //Create a boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 customerID = 1;
            //Invoke the method
            Found = AnCustomer.Find(customerID);
            //Check the CustomerID
            if (AnCustomer.customerID != 1)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestjoinedDateFound()
        {
            //Create instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Create a boolean variable to store the results of the search
            Boolean Found = false;
            //Create a boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 customerID = 1;
            Found = AnCustomer.Find(customerID);
            //check the JoinedDate property
            if (AnCustomer.joinedDate != Convert.ToDateTime("18/01/2023"))
            {
                OK = false;
            }
            //Test to see that the results is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestfirstNameFound()
        {
            //Create instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Create a boolean variable to store the results of the search
            Boolean Found = false;
            //Create a boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 customerID = 1;
            Found = AnCustomer.Find(customerID);
            //Check the FirstName property
            if (AnCustomer.firstName != "Jonny")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestlastNameFound()
        {
            //Create instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Create a boolean variable to store the results of the search
            Boolean Found = false;
            //Create a boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 customerID = 1;
            Found = AnCustomer.Find(customerID);
            //Check this LastName property
            if (AnCustomer.lastName != "Lenon")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestemailFound()
        {
            //Create instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Create a boolean variable to store the results of the search
            Boolean Found = false;
            //Create a boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 customerID = 1;
            Found = AnCustomer.Find(customerID);
            //Checks the email
            if (AnCustomer.email != "JonnyLenon@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestsubscribeFound()
        {
            //Create instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Create a boolean variable to store the results of the search
            Boolean Found = false;
            //Create a boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 customerID = 1;
            Found = AnCustomer.Find(customerID);
            //Checks the if boolean subscribe
            if (AnCustomer.subscribe != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestPhoneNoFound()
        {
            //Create instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Create a boolean variable to store the results of the search
            Boolean Found = false;
            //Create a boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 customerID = 1;
            Found = AnCustomer.Find(customerID);
            //Checks if the phone no is correct 1
            if (AnCustomer.PhoneNo != "07404535912")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        //Valid test method 
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an insatnce of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //String variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnCustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        ///*******First Name Vaild methods ****/
        [TestMethod]
        public void firstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string firstName = "";
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void firstNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string firstName = "a";
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void firstNameNoMin()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string firstName = "a";
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void firstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string firstName = "aa";
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void firstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string firstName = "";
            firstName = firstName.PadRight(49, 'a');
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void firstNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string firstName = "";
            firstName = firstName.PadRight(50, 'a');
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void firstNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string firstName = "";
            firstName = firstName.PadRight(25, 'a');
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void firstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string firstName = "";
            firstName = firstName.PadRight(500, 'a');
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }
        //*****Last Name Valid Test Method****////

        [TestMethod]
        public void lastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string lastName = "";
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void lastNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string lastName = "a";
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void lastNameNoMin()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string lastName = "a";
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void lastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string lastName = "aa";
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void lastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string lastName = "";
            lastName = lastName.PadRight(49, 'a');
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void lastNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string lastName = "";
            lastName = lastName.PadRight(50, 'a');
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void lastNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string lastName = "";
            lastName = lastName.PadRight(25, 'a');
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        public void lastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string lastName = "";
            lastName = lastName.PadRight(500, 'a');
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }
        /****** Email Vaild TestMethods****///
        [TestMethod]
        public void emailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string email = "";
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void emailMin()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string email = "a";
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void emailNoMin()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string email = "a";
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void emailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string email = "aa";
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void emailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string email = "";
            email = email.PadRight(49, 'a');
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void emailMax()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string email = "";
            email = email.PadRight(50, 'a');
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void emailMid()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string email = "";
            email = email.PadRight(25, 'a');
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void emailExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string email = "";
            email = email.PadRight(500, 'a');
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }

        //*********PhoneNo Valid Test Method****///

        [TestMethod]
        public void PhoneNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string PhoneNo = "";
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNoMin()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string PhoneNo = "a";
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNoNoMin()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string PhoneNo = "a";
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string PhoneNo = "aa";
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string PhoneNo = "";
            PhoneNo = PhoneNo.PadRight(49, 'a');
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNoMax()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string PhoneNo = "";
            PhoneNo = PhoneNo.PadRight(50, 'a');
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNoMid()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string PhoneNo = "";
            PhoneNo = PhoneNo.PadRight(25, 'a');
            //invoke the method
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create some test data to pass to method 
            string PhoneNo = "";
            PhoneNo = PhoneNo.PadRight(500, 'a');
            Error = Ancustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }
        //*********joinedDate valid test methods

        [TestMethod]
        public void joinedDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            // String variable to store an error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            // convert the date varaible to a string variable
            string joinedDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void joinedDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string joinedDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void joinedDateMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string joinedDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void joinedDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string joinedDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void joinedDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string joinedDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void joinedDateInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set joined data a non date value
            string joinedDate = "This is not a date! ";
            //invoke the method
            Error = AnCustomer.Valid(email, firstName, lastName, PhoneNo, joinedDate);
            //Test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }
    }
    }

    
    

