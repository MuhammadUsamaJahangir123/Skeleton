using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstOrderProcessingUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessingUser AnUser = new clsOrderProcessingUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }
        
        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessingUser AnUser = new clsOrderProcessingUser();
            Int32 TestData = 1;
            //assign the data to the property
            AnUser.UserID = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnUser.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessingUser AnUser = new clsOrderProcessingUser();
            //create some test data to assign to the property
            string TestData = "Alawi";
            //assgin the data to the property
            AnUser.UserName = TestData;
            //test to see that the twp values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessingUser AnUser = new clsOrderProcessingUser();
            //create some test data to assign to the property
            string TestData = "HelloWorld";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessingUser AnUser = new clsOrderProcessingUser();
            //create some test data to assign to the property
            string TestData = "OrderProcessing";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessingUser AnUser = new clsOrderProcessingUser();
            //create a boolean varaible to store the reuslts of the validation
            Boolean Found = false;
            //create some test data to use with the method
            string UserName = "Alawi";
            string Password = "HelloWorld";
            //invoke the method 
            Found = AnUser.FindUser(UserName, Password);
            //test to see if the results is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUserNamePWFound()
        {
            //create an instance of the class we want to create
            clsOrderProcessingUser AnUser = new clsOrderProcessingUser();
            //create a boolean varaible to store the reuslts of the validation
            Boolean Found = false;
            //create a boolean varaible to reord if the data is OK(Asssume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string UserName = "Alawi";
            string Password = "HelloWorld";
            //invoke the method 
            Found = AnUser.FindUser(UserName, Password);
            //check the user id proeprty
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
