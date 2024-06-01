﻿using ClassLibrary;
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
        public void    StockListOK() 
        
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

       

    }
}

