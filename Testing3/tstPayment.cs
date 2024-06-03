using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;

namespace Testing3
{
    [TestClass]
    public class tstPayment
    {
        //good test data
        //create some test data to pass the method
        string Name = "Siyam";
        string Email = "sbsr31@gmail.com";
        string PostCode = "LE30BS";
        string TransactionStatus = "Pending";
        string PaymentAmount = "1500.00";
        string PaymentDate = "(12/12/2023)";

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
            string TestData = "1500.00";
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
            if (AnPayment.PaymentDate != Convert.ToDateTime("12/12/2023"))
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
            if (AnPayment.Email != "sbsr31@gmail.com")
            {
                OK = false;
            }
        }

        [TestMethod]
        public void TestPostCodeFound()
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
            if (AnPayment.PostCode != "LE30BS")
            {
                OK = false;
            }
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
            //create some test data to use with the method 
            Int32 PaymentID = 1;
            //invoke the method 
            Found = AnPayment.Find(PaymentID);
            //check the house no property 
            if (AnPayment.PaymentAmount != "1500.00")
            {
                OK = false;
            }
        }

        [TestMethod]
        public void TestTransactionStatusFound()
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
            if (AnPayment.TransactionStatus != "Pending")
            {
                OK = false;
            }
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we went to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMInLessOne()
        {
            //create an instanceof the class we went to create
            clsPayment AnPayment = new clsPayment();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to method
            string Name = ""; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "a"; //this should be ok
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "aa"; //this should be ok
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMid()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "aaa"; //this should be ok
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "aaaaaa"; //this should fail
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = clsPayment();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string PaymentDate = TestDate.ToString();
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        private clsPayment clsPayment()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void PaymentDateInvalidDate()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //convert the date variable to a string variable
            string PaymentDate = "this is not a date!";
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PaymentDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string PaymentDate = TestDate.ToString();
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentDateMin()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string PaymentDate = TestDate.ToString();
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string PaymentDate = TestDate.ToString();
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PaymentDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string PaymentDate = TestDate.ToString();
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string PostCode = "";
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMin()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string PostCode = "a";
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new  clsPayment();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string PostCode = "aa";
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string PostCode = "aaaaaaaa";
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of the class we want to create
                clsPayment   AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string PostCode = "aaaaaaaaa";
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string PostCode = "aaaaaaaaaa";
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string PostCode = "aaaa";
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string Email = "";
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string Email = "a";
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string Email = "aa";
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(49, 'a');
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(50, 'a');
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string Email = "";
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(25, 'a');
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentAmountMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string PaymentAmount = "";
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PaymentAmountMin()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string PaymentAmount = "a";
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentAmountMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string PaymentAmount = "aa";
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentAmountMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string PaymentAmount = "";
            PaymentAmount = PaymentAmount.PadRight(49, 'a');
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentAmountMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string PaymentAmount = "";
            PaymentAmount = PaymentAmount.PadRight(50, 'a');
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentAmountMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this shold fail
            string PaymentAmount = "";
            PaymentAmount = PaymentAmount.PadRight(51, 'a');
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PaymentAmountMid()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string PaymentAmount = "";
            PaymentAmount = PaymentAmount.PadRight(25, 'a');
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TransactionStatusMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string TransactionStatus = "";
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TransactionStatusMin()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string TransactionStatus = "a";
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TransactionStatusMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string TransactionStatus = "aa";
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TransactionStatusMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string TransactionStatus = "";
            TransactionStatus = TransactionStatus.PadRight(49, 'a');
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TransactionStatusMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string TransactionStatus = "";
            TransactionStatus = TransactionStatus.PadRight(50, 'a');
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TransactionStatusMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this shold fail
            string TransactionStatus = "";
            TransactionStatus = TransactionStatus.PadRight(51, 'a');
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TransactionStatusMid()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string TransactionStatus = "";
            TransactionStatus = TransactionStatus.PadRight(25, 'a');
            //invoke the method
            Error = AnPayment.Valid(Name, Email, PostCode, PaymentAmount, PaymentDate, TransactionStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
