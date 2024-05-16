using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        //good test data
        //create some test data to pass the method
        string FirstName = "Charles";
        string LastName = "Leclerc";
        string Email = "charl.lec15@gmail.com";
        string PhoneNo = "06548376540";
        string JoinedDate = DateTime.Now.ToShortDateString();


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we wat to create
            clsStaff AnStaff = new clsStaff();

            //test to see that it exists
            Assert.IsNotNull(AnStaff);
        }

        [TestMethod]
        public void AvailabilityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStaff.Availability = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Availability, TestData);
        }

        [TestMethod]
        public void JoinedDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStaff.JoinedDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.JoinedDate, TestData);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStaff.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffID, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Michael";
            //assign the data to the property
            AnStaff.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Schumacher";
            //assign the data to the property
            AnStaff.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.LastName, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "micha_schu7@gmail.com";
            //assign the data to the property
            AnStaff.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Email, TestData);
        }

        [TestMethod]
        public void PhoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "07812648962";
            //assign the data to the property
            AnStaff.PhoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.PhoneNo, TestData);
        }


        [TestMethod]
        ////////////////////////////////PRACTICAL 9///////////////////////
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffID = 6;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestStaffIDFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = true;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 6;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the Staff ID
            if (AnStaff.StaffID != 6)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestJoinedDateFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 6;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the dateAdded property
            if (AnStaff.JoinedDate != Convert.ToDateTime("29/09/2018"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 6;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the FirstName property
            if (AnStaff.FirstName != "Kushal")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestLastNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 6;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the LastName property
            if (AnStaff.LastName != "Dilip")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestAvailabilityFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 6;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the LastName property
            if (AnStaff.Availability != false)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 6;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the LastName property
            if (AnStaff.Email != "kush.di16@yahoo.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 6;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the LastName property
            if (AnStaff.PhoneNo != "07812450357")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        ////////////////////////////////PRACTICAL 10///////////////////////
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }




        /// <summary>
        /// First Name
        /// </summary>
        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = ""; //this should trigger an error
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "a"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = ""; //this should be ok
            FirstName = FirstName.PadRight(15, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = ""; //this should be ok
            FirstName = FirstName.PadRight(16, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = ""; //this should be ok
            FirstName = FirstName.PadRight(17, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = ""; //this should be ok
            FirstName = FirstName.PadRight(7, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }




        /// <summary>
        /// Joined Date
        /// </summary>
        [TestMethod]
        public void JoinedDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the data is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string JoinedDate = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JoinedDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string JoinedDate = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JoinedDateMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string JoinedDate = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JoinedDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string JoinedDate = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JoinedDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the data is less 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string JoinedDate = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JoinedDateInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error messages
            String Error = "";
            //set the JoinedDate to a non date value
            string JoinedDate = "this is not a date";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        //////LastName
        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = ""; //this should trigger an error
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "a"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "aa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = ""; //this should be ok
            LastName = LastName.PadRight(15, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = ""; //this should be ok
            LastName = LastName.PadRight(16, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = ""; //this should be ok
            LastName = LastName.PadRight(17, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = ""; //this should be ok
            LastName = LastName.PadRight(7, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }





        //////Email
        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should trigger an error
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "a"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should be ok
            Email = Email.PadRight(24, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should be ok
            Email = Email.PadRight(25, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should be ok
            Email = Email.PadRight(26, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should be ok
            Email = Email.PadRight(12, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }





        //////Phone
        [TestMethod]
        public void PhoneNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNo = ""; //this should trigger an error
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNo = "a"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNo = "aa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNo = ""; //this should be ok
            PhoneNo = PhoneNo.PadRight(15, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNo = ""; //this should be ok
            PhoneNo = PhoneNo.PadRight(16, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNo = ""; //this should be ok
            PhoneNo = PhoneNo.PadRight(17, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNo = ""; //this should be ok
            PhoneNo = PhoneNo.PadRight(8, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }








    }
}
