using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using System.Globalization;

namespace Testing3
{
    [TestClass]
    public class tstPayment
    {
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
           Int32 TestData = 130;
            //assign the data to the property 
            AnPayment.TransactionID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.TransactionID, TestData);
        }
    }
}
