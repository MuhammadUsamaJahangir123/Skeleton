﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstSupplierUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            Assert.IsNotNull(AnUser);   
        }
        [TestMethod]
        public void UserIdPropertyOK() 
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            Int32 TestData = 1;
            AnUser.UserID=(TestData);
            Assert.AreEqual(AnUser.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            string TestData = "Gurj";
            AnUser.UserName = TestData;
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            string TestData = "WelcomeWorld";
            AnUser.Password = TestData;
            Assert.AreEqual(AnUser.Password, TestData);  
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            string TestData = "Supplier";
            AnUser.Department = TestData;
            Assert.AreEqual(AnUser.Department, TestData);


        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            Boolean Found = false;
            string UserName = "Gurj";
            string Password = "WelcomeWorld";
            Found = AnUser.FindUser(UserName, Password);   
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUserNamePWFound()
        {
            //create an instance of the class we want to create
            clsSupplierUser AnUser = new clsSupplierUser();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            string UserName = "Gurj";
            string Password = "WelcomeWorld";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //check the user id property
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
    }
}