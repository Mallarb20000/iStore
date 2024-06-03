using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace Testing1
{
    [TestClass]
    public class tstStockCollection
    {
        

        [TestMethod]
        public void IstanceOK()
        {

            //create an istance of the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that is exist 
            Assert.IsNotNull(AllStock);

        }

        [TestMethod]
        public void StockListOK()

        {
            //create an instance of the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be list of object
            List<clsStock> TestList = new List<clsStock>();
            //Add an Item to the List 
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.Active = true;
            TestItem.ProductID = 1;
            TestItem.ProductName = "mac1";
            TestItem.ProductPrice = 1000;
            TestItem.ProductDescription = "12 inch";
            TestItem.ProductQuantity = 1;
            TestItem.ProductImg = null;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the vlaues 
            Assert.AreEqual(AllStock.StockList, TestList);
        }






        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set its properties
            TestStock.Active = true;
            TestStock.ProductID = 1;
            TestStock.ProductName = "mac1";
            TestStock.ProductPrice = 1000;
            TestStock.ProductDescription = "12 inch";
            TestStock.ProductQuantity = 1;
            TestStock.ProductImg = null;
            //assign the data to the property
            AllStock.ThisStock = TestStock;
            //test to see that the vlaues 
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be list of object
            List<clsStock> TestList = new List<clsStock>();
            //Add an Item to the List 
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.Active = true;
            TestItem.ProductID = 1;
            TestItem.ProductName = "mac1";
            TestItem.ProductPrice = 1000;
            TestItem.ProductDescription = "12 inch";
            TestItem.ProductQuantity = 1;
            TestItem.ProductImg = null;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the vlaues 
            Assert.AreEqual(AllStock.Count, TestList.Count);


        }

        [TestMethod]
        public void AddMethodOK()
        {
           //create an instance of the class we want to create 
           clsStockCollection AllStocks = new clsStockCollection();
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.ProductID = 1;
            TestItem.ProductName = "mac1";
            TestItem.ProductPrice = 1000;
            TestItem.ProductDescription = "12 inch";
            TestItem.ProductQuantity = 1;
            TestItem.ProductImg = null;
            //set ThisStock to the test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data 
            TestItem.ProductID = PrimaryKey;
            //find the record 
            AllStocks.ThisStock.Find(PrimaryKey);
            //test to see that the 2 values are the same 
            Assert.AreEqual(AllStocks.ThisStock,  TestItem);    

        }

      
      





    }
}


