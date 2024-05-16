using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstEmsRegister
    {
        [TestMethod]
        public void InstanceOK()
        {
            //New instance of Register
            clsRegister clsNewRegister = new clsRegister();

            //test to see that it exists
            Assert.IsNotNull(clsNewRegister);
        }
    }
}
