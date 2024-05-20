using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;
using System.Security.Policy;

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

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property 
            AnStock.Active = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStock.Active, TestData);

        }

        [TestMethod]
        public void ProductIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            String TestData = "eylul";
            //assign the data to the property 
            AnStock.ProductID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStock.ProductID, TestData);

        }

        [TestMethod]
        public void ProductNamePropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            String TestData = "eylul";
            //assign the data to the property 
            AnStock.ProductName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStock.ProductName, TestData);

        }

        [TestMethod]
        public void ProductPricePropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            Int32 TestData = 100;
            //assign the data to the property 
            AnStock.ProductPrice = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStock.ProductPrice, TestData);

        }

        [TestMethod]
        public void ProductQuantityPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
           Int32 TestData = 100;
            //assign the data to the property 
            AnStock.ProductQuantity = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStock.ProductQuantity, TestData);

        }

        [TestMethod]
        public void ProductDescriptionPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            String TestData = "eylul";
            //assign the data to the property 
            AnStock.ProductDescription = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStock.ProductDescription, TestData);

        }


        [TestMethod]
        public void ProductSalaryPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
           Int32 TestData = 90;
            //assign the data to the property 
            AnStock.ProductSalary = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStock.ProductSalary, TestData);

        }

        [TestMethod]
        public void ProductImgPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            String TestData = "eylul";
            //assign the data to the property 
            AnStock.ProductImg = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStock.ProductImg, TestData);

        }

    








    }
}
