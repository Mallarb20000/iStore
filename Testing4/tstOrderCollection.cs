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
        public void OrderListOK ()
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

        /*[TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, 2);
        }*/
    }
}
