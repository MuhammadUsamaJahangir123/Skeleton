using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomerUser
    {
        [TestMethod]
        public void InstancOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }
        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
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
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign to the property
            string TestData = "Usama";
            //assgin the data to the property
            AnUser.UserName = TestData;
            //test to see that the twp values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign to the property
            string TestData = "Password123";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign to the property
            string TestData = "Customers";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //create a boolean varaible to store the reuslts of the validation
            Boolean Found = false;
            //create some test data to use with the method
            string UserName = "Usama";
            string Password = "Password123";
            //invoke the method 
            Found = AnUser.FindUser(UserName, Password);
            //test to see if the results is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUserNamePWFound()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //create a boolean varaible to store the reuslts of the validation
            Boolean Found = false;
            //create a boolean varaible to reord if the data is OK(Asssume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string UserName = "Usama";
            string Password = "Password123";
            //invoke the method 
            Found = AnUser.FindUser(UserName, Password);
            //check the user id proeprty
            if(AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}

