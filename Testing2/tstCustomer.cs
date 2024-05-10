using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
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
    }
}
    
    

