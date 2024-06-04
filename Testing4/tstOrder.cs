using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        //good test data 
        //create some test data to pass the method
        String Town = "Leicester";
        String Street = "Some Street";
        String DateAdded = DateTime.Now.ToShortDateString();
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Active, TestData);
        }

        public void DateAddedPropertyOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test Data to asssign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DateAdded, TestData);
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void CountyCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.CountyCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CountyCode, TestData);
        }

        [TestMethod]
        public void SearchOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AnOrder.Search = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Search, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            AnOrder.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.PostCode, TestData);
        }
        [TestMethod]
        public void StreetPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Some Street";
            //assign the data to the property
            AnOrder.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Street, TestData);
        }

        [TestMethod]
        public void TownPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            AnOrder.Town = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Town, TestData);
        }

        [TestMethod]

        public void FindMethod()
        {
            //create an instacne of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean Variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderID = 2;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestOrdderIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean Variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 1;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the Order ID
            if (AnOrder.OrderID != 1)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 2;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the dateAdded property
            if (AnOrder.DateAdded != Convert.ToDateTime("23/12/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 2;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the active property
            if (AnOrder.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(Town, Street, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Street = ""; //this should be ok
            //invoke the method
            Error = AnOrder.Valid( Street, Town, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        } 
    }
}
