using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstPaymentCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            Assert.IsNotNull(AllPayments);
        }

        [TestMethod]
        public void PaymentListOK()
        {
            //create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsPayment> TestList = new List<clsPayment>();
            //Add an Item to the List
            //create the item of test data
            clsPayment TestItem = new clsPayment();
            //set its properties
            TestItem.PaymentID = 1;
            TestItem.PaymentDate = DateTime.Now;
            TestItem.Name = "Siyam";
            TestItem.PostCode = "LE30BS";
            TestItem.PaymentAmount = "1500.00";
            TestItem.Email = "sbsr31@gmail.com";
            TestItem.TransactionStatus = "Pending";
            //add the tiem to the test list
            TestList.Add(TestItem);
            //assign the data to the proprty
            AllPayments.PaymentList = TestList;
            //test to see that the two values are the dsame
            Assert.AreEqual(AllPayments.PaymentList, TestList);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            clsPayment TestName = new clsPayment();
            //set its properties
            TestName.PaymentID = 1;
            TestName.PaymentDate = DateTime.Now;
            TestName.Name = "Siyam";
            TestName.PostCode = "LE30BS";
            TestName.PaymentAmount = "1500.00";
            TestName.Email = "sbsr31@gmail.com";
            TestName.TransactionStatus = "Pending";
            //assign the data to the proprty
            AllPayments.Name = TestName;
            //test to see that the two values are the dsame
            Assert.AreEqual(AllPayments.Name, TestName);
        }


        [TestMethod]
        public void ListAndCountOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();

            List<clsPayment> TestList = new List<clsPayment>();

            clsPayment TestItem = new clsPayment();
            //set its properties
            TestItem.PaymentID = 1;
            TestItem.PaymentDate = DateTime.Now;
            TestItem.Name = "Siyam";
            TestItem.PostCode = "LE30BS";
            TestItem.PaymentAmount = "1500.00";
            TestItem.Email = "sbsr31@gmail.com";
            TestItem.TransactionStatus = "Pending";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the proprty
            AllPayments.PaymentList = TestList;
            //test to see that the two values are the dsame
            Assert.AreEqual(AllPayments.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create the item of test data
            clsPayment TestItem = new clsPayment();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PaymentID = 1;
            TestItem.PaymentDate = DateTime.Now;
            TestItem.Name = "Siyam";
            TestItem.PostCode = "LE30BS";
            TestItem.PaymentAmount = "1500.00";
            TestItem.Email = "sbsr31@gmail.com";
            TestItem.TransactionStatus = "Pending";
            //set ThisPayment to the test data
            AllPayments.Name = TestItem;
            //add the record
            PrimaryKey = AllPayments.Add();
            //set the primary ket of the test data
            TestItem.PaymentID = PrimaryKey;
            //find the record
            AllPayments.Name.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllPayments.Name, TestItem);
        }


        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();

            //create the item of test data
            clsPayment TestItem = new clsPayment();
            //variable to store the primary key
            Int32 PrimaryKey = 0;

            //set its properties
            TestItem.PaymentID = 1;
            TestItem.PaymentDate = DateTime.Now;
            TestItem.Name = "Siyam";
            TestItem.PostCode = "LE30BS";
            TestItem.PaymentAmount = "1500.00";
            TestItem.Email = "sbsr31@gmail.com";
            TestItem.TransactionStatus = "Pending";
            //set Name to the test data
            AllPayments.Name = TestItem;
            //add the record
            PrimaryKey = AllPayments.Add();
            //set the primary ket of the test data TestItem.AddressId = PrimaryKey;
            //modify the test record
            TestItem.PaymentID = 11;
            TestItem.PaymentDate = DateTime.Now;
            TestItem.Name = "Sam";
            TestItem.PostCode = "LE40BS";
            TestItem.PaymentAmount = "4500.00";
            TestItem.Email = "sam30@gmail.com";
            TestItem.TransactionStatus = "Paid";
            //set the record based on the new test data
            AllPayments.Name = TestItem;
            //update the record
            AllPayments.Update(); //find the record
            AllPayments.Name.Find(PrimaryKey);
            //test to see if Name matches the test data Assert. AreEqual(AllAddresses. ThisAddress, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create the item of test data
            clsPayment TestItem = new clsPayment();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PaymentID = 1;
            TestItem.PaymentDate = DateTime.Now;
            TestItem.Name = "Siyam";
            TestItem.PostCode = "LE30BS";
            TestItem.PaymentAmount = "1500.00";
            TestItem.Email = "sbsr31@gmail.com";
            TestItem.TransactionStatus = "Pending";
            //set ThisAddress to the test data
            AllPayments.Name = TestItem;
            //add the record
            PrimaryKey = AllPayments.Add();

            TestItem.PaymentID = PrimaryKey;

            AllPayments.Name.Find(PrimaryKey);
            //delete the record
            AllPayments.Delete();
            //now find the record
            Boolean Found = AllPayments.Name.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByPostCodeMethodOK() 
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            clsPaymentCollection FilteredPayments = new clsPaymentCollection();
            FilteredPayments.ReportByPostCode("");
            Assert.AreEqual(AllPayments.Count, FilteredPayments.Count);
        }
    }
}
