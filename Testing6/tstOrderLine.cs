using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we wat to create
            clsOrderLine AnOrderLine = new clsOrderLine();

            //test to see that it exists
            Assert.IsNotNull(AnOrderLine);
        }
    }
}
