using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
    }
}
