using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{ 
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {  //create an instance of a class we want to create
            clsStock AnStock = new clsStock();
            //test to see eif it exists
            Assert.IsNotNull(AnStock);
        }
           
       
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property 
            AnStock.Active = TestData;
            //testing to see if the two values are a match
            Assert.AreEqual(AnStock.Active, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class i want to create
            clsStock AnStock = new clsStock();
            //create test data 2 assign 2 property
            DatTime TestData = DateTime.Now.Date;
            //assign data 2 property
            AnStock.DateAdded = TestData;
            //test 2 see if 2 values r the same
            Assert.AreEqual(AnStock.DateAdded, TestData);
        }
        [TestMethod]
    }

}



    