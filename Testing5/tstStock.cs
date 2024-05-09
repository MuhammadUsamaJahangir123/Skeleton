using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5

     [TestClass]
public class tstStock
{
    [TestMethod]
    public void InstanceOK()
    {

        //create an instance of a class we want to create
        clsStock AnStock = new clsStock();
        //test to see eif it exists
        Assert.IsNotNull(AnStock);
    }