using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstStock
    {


        //good test data
        //create some test data to pass the method
        string ProductName = "Ashcap";
        string DateAdded = DateTime.Now.ToShortDateString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AnStock);
        }
        [TestMethod]
        public void RestockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStock.Restock = TestData;
            //test to see the values are the same
            Assert.AreEqual(AnStock.Restock, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStock.DateAdded = TestData;
            //test to see if the two values r the same
            Assert.AreEqual(AnStock.DateAdded, TestData);
        }
        [TestMethod]
        public void ProductIdPropertyOK()
        {
            //create a new instnce of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the rpoperty
            Int32 TestData = 1;
            //assign data to the property
            AnStock.ProductId = TestData;
            //test to see that the values r the same
            Assert.AreEqual(AnStock.ProductId, TestData);
        }
        [TestMethod]
        public void IsAvailablePropertyOK()
        {
            //create an instance of the clas wwe want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign data to the property
            AnStock.IsAvailable = TestData;
            //test to see that the two values r the same
            Assert.AreEqual(AnStock.IsAvailable, TestData);
        }
        [TestMethod]
        public void ProductNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "BlueCap";
            //assign the data to the property
            AnStock.ProductName = TestData;
            //tst to see that the two values r the same
            Assert.AreEqual(AnStock.ProductName, TestData);
        }
        [TestMethod]
        public void ProductPricePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            decimal TestData = 25.70M;
            //assign the data to the property
            AnStock.ProductPrice = TestData;
            //test to see that the two values r the same
            Assert.AreEqual(AnStock.ProductPrice, TestData);
        }
        [TestMethod]
        public void StockQuantityPropertyOK()
        {
            //create an instance of the class we wabt to crete
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            int TestData = 7;
            //asign the data to the property
            AnStock.StockQuantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.StockQuantity, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create a Boolean variable to store the resukts of the vLIDATIIN
            Boolean Found = false;
            //create some test data tp use with the method
            Int32 ProductId = 7;
            //invoke the method
            Found = AnStock.Find(ProductId);
            //test to see if the result is true
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestProductIdFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is oK - assume it is
            Boolean OK = true;
            //create som test data to use with the method
            Int32 ProductId = 7;
            //invoke the ethod
            Found = AnStock.Find(ProductId);
            //check the address id
            if (AnStock.ProductId != 7)
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
            clsStock AnStock = new clsStock();
            //create a boolean variable to store the reult of the search
            Boolean Found = false;
            //create a boolean variable to reciord if the dat is ok - assume it is
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 7;
            //invoke the method
            Found = AnStock.Find(ProductId);
            //check the dateadded property
            if (AnStock.DateAdded != Convert.ToDateTime("22/05/2024"))
            {
                OK = false;
            }
            //test to see uf the reult is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestRestockFound()
        {
            //create an instance of teh class we want to create
            clsStock AnStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 7;
            //invoke the method
            Found = AnStock.Find(ProductId);
            //check the restock property
            if (AnStock.Restock != true)
            {
                OK = false;
            }
            //test to see if the reult is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestIsAvailableFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test dta to use with the method
            Int32 ProductId = 7;
            //invoke the mthod
            Found = AnStock.Find(ProductId);
            //check the active property
            if (AnStock.IsAvailable != true)
            {
                OK = false;
            }
            //tes to see if the resut is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductNameFound()
        {
            //create an instance of teh class we wnat to create
            clsStock AnStock = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create boolean variable to record if data is ok
            Boolean OK = true;
            //create some test datat to use within the method 
            Int32 ProductId = 7;
            //invoke the method
            Found = AnStock.Find(ProductId);
            //check the productname property
            if (AnStock.ProductName != "YellowCap")
            {
                OK = false;
            }
            //test to see if that result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductPriceFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create a boolean variable to store the results of the search
            Boolean Found = false;
            //create boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use within the method
            Int32 ProductId = 7;
            Found = AnStock.Find(ProductId);
            //check the product price property
            if (AnStock.ProductPrice != Convert.ToDecimal("57"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStockQuantityFound()
        {
            //create an instance of the class we want to creatre
            clsStock AnStock = new clsStock();
            //create a boolean variable to store the results of the research
            Boolean Found = false;
            //create boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use within the method
            Int32 ProductId = 7;
            Found = AnStock.Find(ProductId);
            //check the stock quantity property
            if (AnStock.StockQuantity != 17)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error msg
            string Error = "";
            //invoke the method 
            Error = AnStock.Valid(ProductName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMinLessOne()
        {
            //create an instance of the class we wnt to create
            clsStock AnStock = new clsStock();
            //string c = variable to store any errror msg
            String Error = "";
            //create some test dtata to pass the method
            string ProductName = ""; // this shld trigger an error
            //invoke the method
            Error = AnStock.Valid(ProductName, DateAdded);
            //test to see that the result i scorrect
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMin()
        {
            clsStock AnStock = new clsStock();
            //string variable to store any error msg
            String Error = "";
            //create some test data to pass the method
            string ProductName = "a"; //thi shld b 
            //invoke yhe method
            Error = AnStock.Valid(ProductName, DateAdded);
            //test to see that res is coorrect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            //create an instance pf the class we want to create
            clsStock AnStock = new clsStock();
            //string vRIABLE TO STORE ANY ERROR MSG
            String Error = "";
            //creTE SOME TEST DATAT TO PASS TO THE METHOD
            string ProductName = "aa"; //shld b ok
            //invoke the method
            Error = AnStock.Valid(ProductName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error msg
            String Error = "";
            //create sm test data to pass the method
            string ProductName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(ProductName, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error msg
            String Error = "";
            //create sm test data to pass the method
            string ProductName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(ProductName,  DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMid()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error msg
            String Error = "";
            //create sm test data to pass the method
            string ProductName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(ProductName,  DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMacPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error msg
            String Error = "";
            //create some test datat to pass the method
            string ProductName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //shld fail
            //invoke the mthod
            Error = AnStock.Valid(ProductName,  DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameExtremeMax()
        {
            //create an instnce of the class we want to create
            clsStock AnStock = new clsStock();
            //string variab;le to store any error msg
            String Error = "";
            //create some test data to pass the method
            string ProductName = "";
            ProductName = ProductName.PadRight(500, 'a'); // this shld fail
            //invoke the method
            Error = AnStock.Valid(ProductName, DateAdded);
            //test shld see if result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error msg
            String Error = "";
            //create a vriable to store the dest date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ProductName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ProductName, DateAdded);
            //test to c that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store error msg
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ProductName, DateAdded);
            //test to c that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ProductName, DateAdded);
            //test to c that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ProductName, DateAdded);
            //test to c that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error msg
            String Error = "";
            //set the ate added to a non data value
            string DateAdded = "this is not a date!";
            //invoke the method
            Error = AnStock.Valid(ProductName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
    }
} 

