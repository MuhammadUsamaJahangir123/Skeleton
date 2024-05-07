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
        public void DateJoinedPropertyOK() {

            clsCustomer AnCustomer = new clsCustomer();

            DateTime TestData = DateTime.Now.Date;

            AnCustomer.DateJoined = TestData;

            Assert.AreEqual(AnCustomer.DateJoined, TestData);
        }
        [TestMethod]
        public void FirstNamePropertyOK() {
        
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
        public void CustomerIDPropertyOK() { 
        
        clsCustomer AnCustomer = new clsCustomer();

        Int32 TestData = 1;

        AnCustomer.CustomerID = TestData;

            Assert.AreEqual(AnCustomer.CustomerID, TestData);
        }
    }
}
    
    

