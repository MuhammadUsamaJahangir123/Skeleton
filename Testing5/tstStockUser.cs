using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Dynamic;
using System.Security.Cryptography;

namespace Testing5
{
    [TestClass]
    public class tstStockUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //test 2c that it exists
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnUser.UserID = TestData;
            //test to c that the two values r the sae
            Assert.AreEqual(AnUser.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //crete some test data to assign 2 the property
            string TestData = "Tobi";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that th two values r the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //create some test dtat to assig to the property
            string TestData = "Tobi123";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values r the same
            Assert.AreEqual(AnUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //reatec an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //rete csome tst data to assign 2 the property
            string TestData = "Stock";
            //ssign the dats to the propertt
            AnUser.Department = TestData;
            //test to see if two values r the same
            Assert.AreEqual(AnUser.Department, TestData);

        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //creates some test data to use with the method
            string UserName = "Tobi";
            string Password = "Tobi123";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUsserNamePWFound()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //cre8 a boolen variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to rexord if the data is ok
            Boolean OK = true;
            //create some tes data to use with the methof
            string UserName = "Tobi";
            string Password = "Tobi123";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //check the user if property
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK= false;
            }
            //testt to see tht it is correct
            Assert.IsTrue(OK);
        
        }
       

       
        

    }
}
