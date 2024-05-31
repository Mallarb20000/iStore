using ClassLibrary;
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
        public void NamePropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            string TestData = "Siyam";
            //assign the data to the property 
            AnPayment.Name = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.Name, TestData);
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
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            string TestData = "LE30BS";
            //assign the data to the property 
            AnPayment.PostCode = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.PostCode, TestData);
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
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            string TestData = "sbsr31@gmail.com";
            //assign the data to the property 
            AnPayment.Email = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.Email, TestData);
        }
        [TestMethod]
        public void PaymentIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            Int32 TestData = 10;
            //assign the data to the property 
            AnPayment.PaymentID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.PaymentID, TestData);
        }

        [TestMethod]
        public void TestPaymentIDFound()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 PaymentID = 1;
            //invoke the method 
            Found = AnPayment.Find(PaymentID);
            //check the address id property 
            if (AnPayment.PaymentID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 PaymentID = 1;
            //invoke the method 
            Found = AnPayment.Find(PaymentID);
            //check the house no property 
            if (AnPayment.Name != "Siyam")
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
            Int32 PaymentID = 1;
            //invoke the method 
            Found = AnPayment.Find(PaymentID);
            //check the date added property 
            if (AnPayment.PaymentDate != Convert.ToDateTime(value: "12/12/2023"))
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 PaymentID = 1;
            //invoke the method 
            Found = AnPayment.Find(PaymentID);
            //check the house no property 
            if (AnPayment.Name != "sbsr31@gmail.com")
            {
                OK = false;
            }
        }
    }
}
