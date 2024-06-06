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
        [TestMethod]
        public void AddMethodOk()
        {
            clsCmsCollection allCustomer = new clsCmsCollection();
            //create some test data to assign o the property
            clsCms TestItem = new clsCms();
            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerId = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.CustomerName = "Hasibe Genc";
            TestItem.CustomerEmail = "hasibeegencc@gmail.com";
            TestItem.CustomerPassword = "Hasibe03";
            TestItem.PostCode = "LE1 1ST";
            TestItem.Membership = true;
            // set ThisCustommers to the test data
            allCustomer.ThisCustomer = TestItem;
            //Add the record
            PrimaryKey = allCustomer.Add();
            // set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            allCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(allCustomer.ThisCustomer, TestItem);    
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCmsCollection allCustomer = new clsCmsCollection();
            clsCms TestItem = new clsCms();
            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.DateAdded = DateTime.Now;
            TestItem.CustomerName = "Hasibe Genc";
            TestItem.CustomerEmail = "hasibeegencc@gmail.com";
            TestItem.CustomerPassword = "Hasibe04";
            TestItem.PostCode = "LE1 1ST";
            TestItem.Membership = true;
            //set thisCustomer to the test data 
            allCustomer.ThisCustomer = TestItem;    
            //add the ecord
            PrimaryKey=allCustomer.Add();   
            //set the primary key of the test data 
            TestItem.CustomerId= PrimaryKey;    
            //modify the test record
            TestItem.DateAdded=DateTime.Now;
            TestItem.CustomerName= "Name";
            TestItem.CustomerEmail = "email";
            TestItem.CustomerPassword = "password";
            TestItem.PostCode = "PostCode";
            TestItem.Membership = false;
            // set the record based on the new test data
            allCustomer.ThisCustomer= TestItem;
            // update the record
            allCustomer.Update();
            //ind the record
            allCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see if thisCustomer matches the test data
            Assert.AreEqual(allCustomer.ThisCustomer, TestItem);
           
        }
        [TestMethod]        
        public void DeleteMethodOk() 
        {
            //create an instance of the class we want to create
            clsCmsCollection allCustomer = new clsCmsCollection();
            clsCms TestItem = new clsCms();
            //variable to stroe the primary key
            Int32 PrimaryKey = 0;
            TestItem.CustomerId = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.CustomerName = "Hasibe Genc";
            TestItem.CustomerEmail = "hasibeegencc@gmail.com";
            TestItem.CustomerPassword = "Hasibe04";
            TestItem.PostCode = "LE1 1ST";
            TestItem.Membership = true;
            allCustomer.ThisCustomer = TestItem;
            //set ThisCustomer to the tes data
            PrimaryKey = allCustomer.Add(); 
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            allCustomer.ThisCustomer.Find(PrimaryKey);
            //find the record
            allCustomer.Delete();
            //now find the record
            Boolean Found = allCustomer.ThisCustomer.Find(PrimaryKey);  
            Assert.IsFalse(Found); 
        }

        [TestMethod]    
        public void ReportByPostCodeMethodOK()
        {
            clsCmsCollection allCustomers = new clsCmsCollection(); 
            clsCmsCollection FilteredCustomer = new clsCmsCollection();
            FilteredCustomer.ReportByPostCode("");
            Assert.AreEqual(allCustomers.Count, FilteredCustomer.Count);
        }
        [TestMethod]
        public void ReportByPostCodeNoneFound() 
        { 
            clsCmsCollection FilteredCustomer= new clsCmsCollection();
            FilteredCustomer.ReportByPostCode("xxx xxx");
            Assert.AreEqual(0, FilteredCustomer.Count);
        }

        [TestMethod]
        public void ReportByPostCodeTestDataFound()
        {
            clsCmsCollection FilteredCustomer = new clsCmsCollection();
            Boolean OK = true;
            FilteredCustomer.ReportByPostCode("SS0");
            if (FilteredCustomer.Count == 2)
            {
                if (FilteredCustomer.CustomerList[0].CustomerId != 1)
                {
                    OK = false;
                }
                if (FilteredCustomer.CustomerList[1].CustomerId != 2)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

    }
}
