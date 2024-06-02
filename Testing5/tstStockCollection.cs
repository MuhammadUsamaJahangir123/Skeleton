using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace Testing5
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want ton create
            clsStockCollection AllStocks = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStocks);
        }
        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its proprties of the test object
            TestItem.ProductId = 1;
            TestItem.ProductName = "BlueCap";
            TestItem.ProductPrice = Convert.ToDecimal("26.00");
            TestItem.StockQuantity = 7;
            TestItem.DateAdded = DateTime.Now;
            TestItem.IsAvailable = true;
            TestItem.Restock = true;
            //add all the items to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStocks.StockList = TestList;
            //test to see that the 2 values r te same
            Assert.AreEqual(AllStocks.StockList, TestList);    
        }
        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the classs we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.ProductId = 1;
            TestStock.ProductName = "BlueCap";
            TestStock.ProductPrice = Convert.ToDecimal("26.00");
            TestStock.StockQuantity = 7;
            TestStock.DateAdded = DateTime.Now;
            TestStock.IsAvailable = true;
            TestStock.Restock = true;
            //assign the data to the property
            AllStocks.ThisStock = TestStock;
            //test to see that the two values r the same
            Assert.AreEqual(AllStocks.ThisStock, TestStock);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //Create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.ProductId = 1;
            TestItem.ProductName = "BlueCap";
            TestItem.ProductPrice = Convert.ToDecimal("26.00");
            TestItem.StockQuantity = 7;
            TestItem.DateAdded = DateTime.Now;
            TestItem.IsAvailable = true;
            TestItem.Restock = true;
            //add the items to the test list
            TestList.Add(TestItem);
            //assig the data to the proeprty
            AllStocks.StockList = TestList;
            //test to c that the values r the same
            Assert.AreEqual(AllStocks.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductId = 1;
            TestItem.ProductName = "BlueCap";
            TestItem.ProductPrice = Convert.ToDecimal("26.00");
            TestItem.StockQuantity = 7;
            TestItem.DateAdded = DateTime.Now;
            TestItem.IsAvailable = true;
            TestItem.Restock = true;
            //set this stokc to the test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the pk of the test data
            TestItem.ProductId = PrimaryKey;
            //fid the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //new item of test data
            clsStock TestItem = new clsStock();
            //variable to store the pk
            Int32 PrimaryKey = 0;
            //set its properrties
            TestItem.ProductName = "BlueCap";
            TestItem.ProductPrice = Convert.ToDecimal("26.00");
            TestItem.StockQuantity = 7;
            TestItem.DateAdded = DateTime.Now;
            TestItem.IsAvailable = true;
            TestItem.Restock = true;
            //set this stock to test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the pk of the test data
            TestItem.ProductId = PrimaryKey;
            //modify the test record
            TestItem.ProductName = "OrangeCap";
            TestItem.ProductPrice = Convert.ToDecimal("37.00");
            TestItem.StockQuantity = 7;
            TestItem.DateAdded = DateTime.Now;
            TestItem.IsAvailable = true;
            TestItem.Restock = true;
            //set the record based on new tes data
            AllStocks.ThisStock = TestItem;
            AllStocks.Update();
            //fimd the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //test to see if ThisStock matches the test data
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductName = "BlueCap";
            TestItem.ProductPrice = Convert.ToDecimal("26.00");
            TestItem.StockQuantity = 7;
            TestItem.DateAdded = DateTime.Now;
            TestItem.IsAvailable = true;
            TestItem.Restock = true;
            //set thisstock to the test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data
            TestItem.ProductId = PrimaryKey;
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //delete the record
            AllStocks.Delete();
            //now find the record
            Boolean Found = AllStocks.ThisStock.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }


    }
}
