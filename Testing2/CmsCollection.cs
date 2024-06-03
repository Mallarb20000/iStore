using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class CmsCollection
    {
        [TestMethod]
        public void InsatanceOK()
        {
            clsCmsCollection allCustomer = new clsCmsCollection();
            Assert.IsNotNull(allCustomer);  

        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCmsCollection allCustomer = new clsCmsCollection();
            //create some test data to assign to the property
            // in his case he data need to be a list of objects
            List<clsCms>TestList= new List<clsCms>();
            //Add an item to the list 
            //create the item of test data
            clsCms TestItem = new clsCms();
            // see its properties
            TestItem.CustomerId = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.CustomerName = "Hasibe Genc";
            TestItem.CustomerEmail = "hasibeegencc@gmail.com";
            TestItem.CustomerPassword= "Hasibe03";
            TestItem.PostCode = "LE1 1ST";
            TestItem.Membership = true;
            //assign the data to he property
            allCustomer.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(allCustomer.CustomerList,TestList);
        }

        
        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCmsCollection allCustomer = new clsCmsCollection();
            //create some test data to assign o the property
            clsCms TestCustomer = new clsCms();
            //set the properties of the test object
            TestCustomer.CustomerId = 1;
            TestCustomer.DateAdded = DateTime.Now;
            TestCustomer.CustomerName = "Hasibe Genc";
            TestCustomer.CustomerEmail = "hasibeegencc@gmail.com";
            TestCustomer.CustomerPassword = "Hasibe03";
            TestCustomer.PostCode = "LE1 1ST";
            TestCustomer.Membership = true;
            //assign the data to he property
            allCustomer.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(allCustomer.ThisCustomer, TestCustomer);

        }
        [TestMethod]
        public void ListAndCountOK()
        {

            clsCmsCollection allCustomer = new clsCmsCollection();
            //create some test data to assign to the property
            // in his case he data need to be a list of objects
            List<clsCms> TestList = new List<clsCms>();
            //Add an item to the list 
            //create the item of test data
            clsCms TestItem = new clsCms();
            // see its properties
            TestItem.CustomerId = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.CustomerName = "Hasibe Genc";
            TestItem.CustomerEmail = "hasibeegencc@gmail.com";
            TestItem.CustomerPassword = "Hasibe03";
            TestItem.PostCode = "LE1 1ST";
            TestItem.Membership = true;
            //Add the item to the test list
            TestList.Add(TestItem); 
            //assign he data to the property
            allCustomer.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(allCustomer.Count, TestList.Count);

        }
       

    }
}
