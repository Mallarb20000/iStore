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
        //String Street = "Some Street";
        String DateAdded = DateTime.Now.ToShortDateString();
        String ProductID = Int32.MinValue.ToString();
        String OrderStatus = "Pending";
        String CustomerID = Int32.MinValue.ToString();
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
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerID, TestData);
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
        public void ProductIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 101;
            //assign the data to the property
            AnOrder.ProductID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ProductID, TestData);
        }
        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Some Street";
            //assign the data to the property
            AnOrder.OrderStatus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderStatus, TestData);
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

        /*[TestMethod]

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
        }*/

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
            Int32 OrderID = 1;
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
            Error = AnOrder.Valid(Town, DateAdded, OrderStatus, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderStatus = ""; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(Town, DateAdded, OrderStatus, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void OrderStatusMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderStatus = "p";
            //invoke the method
            Error = AnOrder.Valid(Town, DateAdded, OrderStatus, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderStatus = "pp";
            //invoke the method
            Error = AnOrder.Valid(Town, DateAdded, OrderStatus, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderStatus = "ppppp";
            //invoke the method
            Error = AnOrder.Valid(Town, DateAdded, OrderStatus, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderStatus = "ppppppp";
            //invoke the method
            Error = AnOrder.Valid(Town, DateAdded, OrderStatus, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderStatus = "ppp";
            //invoke the method
            Error = AnOrder.Valid(Town, DateAdded, OrderStatus, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderStatus = "pppppppp";
            //invoke the method
            Error = AnOrder.Valid(Town, DateAdded, OrderStatus, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(500, 'p');
            //invoke the method
            Error = AnOrder.Valid(Town, DateAdded, OrderStatus, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Town, DateAdded, OrderStatus, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Town, DateAdded, OrderStatus, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

      /*  [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Town, DateAdded, OrderStatus, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }*/

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 100 years
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Town, DateAdded, OrderStatus, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Town, DateAdded, OrderStatus, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //String variable to store any error message
            String Error = "";
            //set the Dateadded to a non date value
            string DateAdded = "this is not a date!";
            //invoke the method
            Error = AnOrder.Valid(Town, DateAdded, OrderStatus, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TownMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Town = "";
            //invoke the method
            Error = AnOrder.Valid(Town, DateAdded, OrderStatus, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TownMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Town = "a";
            //invoke the method
            Error = AnOrder.Valid(Town, DateAdded, OrderStatus, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Town = "aa";
            //invoke the method
            Error = AnOrder.Valid(Town, DateAdded, OrderStatus, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TownMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Town = "";
            Town = Town.PadRight(49, 'a');
            //invoke the method
            Error = AnOrder.Valid(Town, DateAdded, OrderStatus, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TownMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Town = "";
            Town = Town.PadRight(50, 'a');
            //invoke the method
            Error = AnOrder.Valid(Town, DateAdded, OrderStatus, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string Town = "";
            Town = Town.PadRight(51, 'a');
            //invoke the method
            Error = AnOrder.Valid(Town, DateAdded, OrderStatus, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TownMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Town = "";
            Town = Town.PadRight(25, 'a');
            //invoke the method
            Error = AnOrder.Valid(Town, DateAdded, OrderStatus, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
