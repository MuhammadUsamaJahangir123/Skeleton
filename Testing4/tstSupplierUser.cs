using ClassLibrary;
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
            //create an instance of the class we want to create
            clsSupplierUser AnUser = new clsSupplierUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);   
        }
        [TestMethod]
        public void UserIdPropertyOK() 
        {
            //create an instance of the class we want to create
            clsSupplierUser AnUser = new clsSupplierUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnUser.UserID=(TestData);
            //Test to see that the two values are the same
            Assert.AreEqual(AnUser.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplierUser AnUser = new clsSupplierUser();
            //create some test data to assign to the property
            string TestData = "Gurj";
            //assign the data to the property
            AnUser.UserName = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplierUser AnUser = new clsSupplierUser();
            //create some test data to assign to the property
            string TestData = "WelcomeWorld";
            //assign the data to the property
            AnUser.Password = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);  
        }
        [TestMethod]                                                                                                                                                                                                
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplierUser AnUser = new clsSupplierUser();
            //create some test data to assign to the property
            string TestData = "Supplier";
            //assign the data to the property
            AnUser.Department = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);


        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplierUser AnUser = new clsSupplierUser();
            //create a boolean variable to store the results
            Boolean Found = false;
            //create some test data to use with the method
            string UserName = "Gurj";
            string Password = "WelcomeWorld";
            //invoke the method 
            Found = AnUser.FindUser(UserName, Password);
            //test to see if its found
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
