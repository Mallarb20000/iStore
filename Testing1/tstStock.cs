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

         //good test data
         //create some test data to pass the method
        string ProductName = "Mac2";
        string ProductPrice = "800";
        string ProductQuantity = "15";
        string ProductDescription = "15 inch";
        string ProductImg = "";

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
            Int32 TestData = 100;
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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create a Boolean variable to store the results of the validation 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 21;
            //invoke the method
            Found = AnStock.Find(ProductID);
            //test to see if the result is true
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestProductIDFound()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create a Boolean variable to store the results of the validation 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 6;
            //invoke the method
            Found = AnStock.Find(ProductID);
            //check the ProductID Property
            if (AnStock.ProductID != 6)
            {
                OK = false;
            }

            //test to see if the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestProductNameFound()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductName = 6;
            //create a Boolean variable to store the results of the validation 
            //invoke the method
            bool Found = AnStock.Find(ProductName);
            //check the product name property
            if (AnStock.ProductName != "mac6")
            {
                OK = false;
            }

            //test to see if the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestProductPriceFound()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create a Boolean variable to store the results of the validation 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductPrice = 6;
            //invoke the method
            Found = AnStock.Find(ProductPrice);
            //check the product price property
            if (AnStock.ProductPrice != Convert.ToInt32("1000"))
            {
                OK = false;
            }

            //test to see if the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestProductQuantityFound()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create a Boolean variable to store the results of the validation 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductQuantity = 6;
            //invoke the method
            Found = AnStock.Find(ProductQuantity);
            //check the product quantity property
            if (AnStock.ProductQuantity != Convert.ToInt32("7"))
            {
                OK = false;
            }

            //test to see if the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestProductDescriptionFound()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create a Boolean variable to store the results of the validation 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductDescription = 6;
            //invoke the method
            Found = AnStock.Find(ProductDescription);
            //check the product description property
            if (AnStock.ProductDescription != "13 inch")
            {
                OK = false;
            }

            //test to see if the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestProductImgFound()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create a Boolean variable to store the results of the validation 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductImg = 6;
            //invoke the method
            Found = AnStock.Find(ProductImg);
            //check the product Img property
            if (AnStock.ProductImg != "Test ProductImg")
            {
                OK = false;
            }

            //test to see if the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create a Boolean variable to store the results of the validation 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 6;
            //invoke the method
            Found = AnStock.Find(ProductID);
            //check the Active property
            if (AnStock.Active != true)
            {
                OK = false;
            }

            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String variable to stor any error message
            string Error = "";
            //invoke the method
            Error = AnStock.Valid(ProductName, ProductPrice, ProductDescription, ProductImg);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductNameMinLessOne()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String variable to stor any error message
            string Error = "";
            //invoke the method

            //create some test to pass to the method
            string ProductName = "";

            //invoke the method 
            Error = AnStock.Valid(ProductName, ProductPrice, ProductDescription, ProductImg);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        



    }
}
