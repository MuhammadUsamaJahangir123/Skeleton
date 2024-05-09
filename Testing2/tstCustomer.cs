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
        public void SubscribePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnCustomer.Subscribe = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Subscribe, TestData);
        }
        [TestMethod]
        public void DateJoinedPropertyOK()
        {

            clsCustomer AnCustomer = new clsCustomer();

            DateTime TestData = DateTime.Now.Date;

            AnCustomer.DateJoined = TestData;

            Assert.AreEqual(AnCustomer.DateJoined, TestData);
        }
        [TestMethod]
        public void FirstNamePropertyOK()
        {

            clsCustomer AnCustomer = new clsCustomer();

            string TestData = "Jonny";

            AnCustomer.FirstName = TestData;

            Assert.AreEqual(AnCustomer.FirstName, TestData);
        }
        [TestMethod]
        public void LastNamePropertyOK()
        {

            clsCustomer AnCustomer = new clsCustomer();

            string TestData = "Lenon";

            AnCustomer.LastName = TestData;

            Assert.AreEqual(AnCustomer.LastName, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {

            clsCustomer AnCustomer = new clsCustomer();

            string TestData = "JonnyLenon@gmail.com";

            AnCustomer.Email = TestData;

            Assert.AreEqual(AnCustomer.Email, TestData);
        }
        [TestMethod]
        public void CustomerIDPropertyOK()
        {

            clsCustomer AnCustomer = new clsCustomer();

            Int32 TestData = 1;

            AnCustomer.CustomerID = TestData;

            Assert.AreEqual(AnCustomer.CustomerID, TestData);
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
            Int32 CustomerID = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //Test to see if the results is ture
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCustomerIDFound()
        {
            //Create instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Create a boolean variable to store the results of the search
            Boolean Found = false;
            //Create a boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 CustomerID = 21;
            //Invoke the method
            Found = AnCustomer.Find(CustomerID);
            //Check the CustomerID
            if (AnCustomer.CustomerID != 21)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestJoinedDateFound()
        {
            //Create instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Create a boolean variable to store the results of the search
            Boolean Found = false;
            //Create a boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            //check the JoinedDate property
            if (AnCustomer.DateJoined != Convert.ToDateTime("23/12/2022"))
            {
                OK = false;
            }
            //Test to see that the results is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFirstNameFound()
        {
            //Create instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Create a boolean variable to store the results of the search
            Boolean Found = false;
            //Create a boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            //Check the FirstName property
            if (AnCustomer.FirstName != "Jonny")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestLastNameFound()
        {
            //Create instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Create a boolean variable to store the results of the search
            Boolean Found = false;
            //Create a boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            //Check this LastName property
            if (AnCustomer.LastName != "Lenon")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestEmail()
        {
            //Create instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Create a boolean variable to store the results of the search
            Boolean Found = false;
            //Create a boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            //Checks the email
            if (AnCustomer.Email != "JonnyLenon@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSubscribe()
        {
            //Create instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Create a boolean variable to store the results of the search
            Boolean Found = false;
            //Create a boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            //Checks the if boolean subscribe
            if (AnCustomer.Subscribe != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
    }
}
    
    

