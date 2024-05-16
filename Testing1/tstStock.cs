using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()

        {
            //create an intsance of the class we want to create
            clsStock AnStock = new clsStock();
                // test to see that it exists
            Assert.IsNotNull(AnStock);
        }
    }
}
