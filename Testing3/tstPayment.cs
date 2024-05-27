using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using System.Globalization;

namespace Testing3
{
    [TestClass]
    public class tstPayment
    {
        private int PaymentDate;

        public int OrderID { get; private set; }

        [TestMethod]
        public void TestMethod1()
        {
            clsPayment AnPayment = new clsPayment();
            Assert.IsNotNull(AnPayment);
        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property 
            AnPayment.Active = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.Active, TestData);
        }
            [TestMethod]
            public void PaymentAmountPropertyOK()
            {
                //create an instance of the class we want to create 
                clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            Boolean TestData = true;
                //assign the data to the property 
                AnPayment.PaymentAmount = TestData;
                //test to see that the two values are the same 
                Assert.AreEqual(AnPayment.PaymentAmount, TestData);
            }
        [TestMethod]
        public void PaymentDatePropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            AnPayment.PaymentDate = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.PaymentDate, TestData);
        }
        [TestMethod]
        public void PaymentMethodPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            Int32 TestData = 50;
            //assign the data to the property 
            AnPayment.PaymentMethod = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.PaymentMethod, TestData);
        }
        [TestMethod]
        public void TransactionStatusPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            string TestData = "Hi";
            //assign the data to the property 
            AnPayment.TransactionStatus = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.TransactionStatus, TestData);
        }
        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            Int32 TestData = 100;
            //assign the data to the property 
            AnPayment.OrderID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.OrderID, TestData);
        }
        [TestMethod]
        public void TransactionIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            Int32 TestData = 10;
            //assign the data to the property 
            AnPayment.TransactionID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.TransactionID, TestData);
        }

        [TestMethod]
        public void TestTransactionIDFound()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 TransactionID = 1;
            //invoke the method 
            Found = AnPayment.Find(TransactionID);
            //check the address id property 
            if (AnPayment.TransactionID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //invoke the method 
            Found = AnPayment.Find(OrderID);
            //check the house no property 
            if (AnPayment.OrderID != 10)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPaymentAmountFound()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //invoke the method 
            Found = AnPayment.Find(PaymentAmount);
            //check the street property 
            if (AnPayment.PaymentAmount != "PaymentAmount")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPaymentDateFound()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 TransactionID = 21;
            //invoke the method 
            Found = AnPayment.Find(PaymentDate);
            //check the date added property 
            if (AnPayment.PaymentDate != Convert.ToDateTime("23/12/2022"))
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
            clsPayment AnPaymenmt = new clsPayment();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 PaymentID = 21;
            //invoke the method 
            Found = AnPayment.Find(PaymentDate);
            //check the active property 
            if (AnPayment.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
    }
}
