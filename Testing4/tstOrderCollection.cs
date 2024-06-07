using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }
        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to asign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //Add an item to the List
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            // set its properties
            TestItem.Active = true;
            TestItem.OrderID = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.OrderStatus = "pending";
            TestItem.Town = "Leicester";
            TestItem.CustomerID = 101;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        /*[TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllOrders.Count = SomeCount;
            //test to see that two values are the same
            Assert.AreEqual(AllOrders.Count, SomeCount);
        }*/

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //Set the properties of the test Object
            TestOrder.Active = true;
            TestOrder.OrderID = 1;
            TestOrder.DateAdded = DateTime.Now;
            TestOrder.OrderStatus = "pending";
            TestOrder.Town = "Leicester";
            TestOrder.CustomerID = 101;
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            // create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.Active = true;
            TestItem.OrderID = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.OrderStatus = "pending";
            TestItem.Town = "Leicester";
            TestItem.CustomerID = 101;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary Key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.OrderID = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.OrderStatus = "pending";
            TestItem.Town = "Leicester";
            // set thisOrder to the testData
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // create an instance of the class we want
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its propeerties
            TestItem.Active = true;
            TestItem.OrderID = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.OrderStatus = "pending";
            TestItem.Town = "Leicester";
            //set thisorderto test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of test data
            TestItem.OrderID = PrimaryKey;
            //modify the test record
            TestItem.Active = false;
            TestItem.OrderID = 3;
            TestItem.DateAdded = DateTime.Now;
            TestItem.OrderStatus = "completed";
            TestItem.Town = "Hull";
            //set the record based on new data
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see if this Order matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.OrderID = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.OrderStatus = "Pending";
            TestItem.Town = "Leicester";
            //set ThisAddress to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();

            TestItem.OrderID = PrimaryKey;

            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByPostCodeMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByPostCode("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByPostCodeTestDataFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a post code that doesn't exist
            FilteredOrders.ReportByPostCode("yyy yyy");
            //check that the correct number of records are found
            if (FilteredOrders.Count == 2)
            {
                //check to see that the first record is 25
                if (FilteredOrders.OrderList[0].OrderID != 25)
                {
                    OK = false;
                }
                //check to see that the first record is 26
                if (FilteredOrders.OrderList[1].OrderID != 26)
                {
                    OK = false;
                }
                else
                {
                    OK = false;
                }
                //test to see that there are no records
                Assert.IsTrue(OK);
            }
        }
    }
}
