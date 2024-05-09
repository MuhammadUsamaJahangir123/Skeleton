using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
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
            AnStaff.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.DateAdded, TestData);
        }

        [TestMethod]
        public void StaffIdPropertyOK()
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
        ////////////////////////////////PRACTICAL 9///////////////////////
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffID = 2;
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
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 2;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the Staff ID
            if (AnStaff.StaffID != 2)
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
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 2;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the dateAdded property
            if (AnStaff.DateAdded != Convert.ToDateTime("23/06/2023"))
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
            Int32 StaffID = 2;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the FirstName property
            if (AnStaff.FirstName != "Max")
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
            Int32 StaffID = 2;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the LastName property
            if (AnStaff.LastName != "Verstappen")
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
            Int32 StaffID = 2;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the LastName property
            if (AnStaff.Availability != true)
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
            Int32 StaffID = 2;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the LastName property
            if (AnStaff.Email != "max_verst18@yahoo.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}
