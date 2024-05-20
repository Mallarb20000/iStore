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

        [TestMethod]
        public void FindMethodOK()
        {
            //New instance of Register
            clsRegister clsNewRegister = new clsRegister();
            //Creating bollian to store results of the validation
            Boolean Found = false;

            //create some test data to use this method
            Int32 E_Id = 1;

            //invoke the method
            Found = clsNewRegister.Find(E_Id);

            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestE_IdFound()
        {
            //create new instance of register
            clsRegister clsNewRegister = new clsRegister();
            //Creating bollian to store results of the validation
            Boolean Found = false;

            //create a boolean variable to recoerd if the data is OK

            Boolean OK = true;

            //create some test data to use this method
            Int32 E_Id = 1;

            //invoke the method
            Found = clsNewRegister.Find(E_Id);

            //check E_id
            if (clsNewRegister.E_Id !=1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);





        }
    }
}
