using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstRegistercollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //instance of new class RegisterCollection
            clsRegisterCollection AllRegistration = new clsRegisterCollection();
            //test to see if it exists
            Assert.IsNotNull(AllRegistration);
        }

        [TestMethod]
        public void RegisterListOK()
        {
            //instance of register collection class
            clsRegisterCollection AllRegister = new clsRegisterCollection();


            //create some test data to assign to the property 
            //in this case a list 
            List<clsRegister> TestList = new List<clsRegister>();
            //add an item to the list 
            //create the item of test data
            clsRegister TestItem = new clsRegister();
            //set its properties
            TestItem.Username = "username";
            TestItem.Password = "password"; 
            TestItem.Name = "name";
            TestItem.E_Id = 1;  
            TestItem.Salary = 1;        
            TestItem.Trained = true;
            TestItem.Timestamp = DateTime.Now;

            //add the test item to list 
            TestList.Add(TestItem);
            //asssign the data to a property
            AllRegister.RegisterList = TestList;
            //test to see two values are th esame
            Assert.AreEqual(AllRegister.RegisterList,TestList);
        }

        

        [TestMethod]

        public void ThisRegisterPropertyOK()
        {
            clsRegisterCollection AllRegister = new clsRegisterCollection();
            //test data 
            clsRegister TestRegister = new clsRegister();
            TestRegister.Username = "username";
            TestRegister.Password = "password";
            TestRegister.Name = "name";
            TestRegister.E_Id = 1;
            TestRegister.Salary = 1;
            TestRegister.Trained = true;
            TestRegister.Timestamp = DateTime.Now;

        
            //asssign the data to a property
            AllRegister.ThisRegister  = TestRegister;
            //test to see two values are th esame
            Assert.AreEqual(AllRegister.ThisRegister,TestRegister);
        }

        [TestMethod]

        public void ListandCountOK()
        {
            //instance of register collection class
            clsRegisterCollection AllRegister = new clsRegisterCollection();


            //create some test data to assign to the property 
            //in this case a list 
            List<clsRegister> TestList = new List<clsRegister>();
            //add an item to the list 
            //create the item of test data
            clsRegister TestItem = new clsRegister();
            //set its properties
            TestItem.Username = "username";
            TestItem.Password = "password";
            TestItem.Name = "name";
            TestItem.E_Id = 1;
            TestItem.Salary = 1;
            TestItem.Trained = true;
            TestItem.Timestamp = DateTime.Now;

            //add the test item to list 
            TestList.Add(TestItem);
            //asssign the data to a property
            AllRegister.RegisterList = TestList;
            //test to see two values are th esame
            Assert.AreEqual(AllRegister.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsRegisterCollection AllRegister = new clsRegisterCollection();
            //test data 
            clsRegister TestRegister = new clsRegister();
            TestRegister.Username = "username";
            TestRegister.Password = "password";
            TestRegister.Name = "name";
            TestRegister.E_Id = 10;
            TestRegister.Salary = 1;
            TestRegister.Trained = true;
            TestRegister.Timestamp = DateTime.Now;


            //asssign the data to a property
            AllRegister.ThisRegister = TestRegister;
            //add record
            Int32 PrimaryKey = 0;
            PrimaryKey = AllRegister.Add();
            //set the primary key to test data
            TestRegister.E_Id = PrimaryKey;
            //find the record
            AllRegister.ThisRegister.Find(PrimaryKey);
            //test to see that two values are the same
            Assert.AreEqual(AllRegister.ThisRegister, TestRegister);
        }

        [TestMethod]

        public void UpdateMethodOK() 
        {
            clsRegisterCollection AllRegister = new clsRegisterCollection();
            //test data 
            clsRegister TestRegister = new clsRegister();

            Int32 PrimaryKey = 0;

            TestRegister.Username = "username";
            TestRegister.Password = "password";
            TestRegister.Name = "name";
            TestRegister.E_Id = 10;
            TestRegister.Salary = 1;
            TestRegister.Trained = true;
            TestRegister.Timestamp = DateTime.Now;


            //asssign the data to a property
            AllRegister.ThisRegister = TestRegister;
            //add record
         
            PrimaryKey = AllRegister.Add();
            //set the primary key to test data
            TestRegister.E_Id = PrimaryKey;
            //modyfy the record

            TestRegister.Username = "username12";
            TestRegister.Password = "password12";
            TestRegister.Name = "name12";
            TestRegister.E_Id = 11;
            TestRegister.Salary = 12;
            TestRegister.Trained = true;
            TestRegister.Timestamp = DateTime.Now;
            AllRegister.ThisRegister = TestRegister;
            AllRegister.Update();
            AllRegister.ThisRegister.Find(PrimaryKey);
            //test to see that two values are the same
            Assert.AreEqual(AllRegister.ThisRegister, TestRegister);
        }

        [TestMethod]

        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsRegisterCollection AllRegister = new clsRegisterCollection();
            //create a new item for test data 
            clsRegister TestRegister = new clsRegister();

            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its property 
            TestRegister.Username = "username3";
            TestRegister.Password = "password3";
            TestRegister.Name = "name3";
            TestRegister.E_Id = 13;
            TestRegister.Salary = 1;
            TestRegister.Trained = true;
            TestRegister.Timestamp = DateTime.Now;

            AllRegister.ThisRegister = TestRegister;
            //add the record
            PrimaryKey = AllRegister.Add();
            //set the primary key of the test data
            TestRegister.E_Id = PrimaryKey;
            //find the record
            AllRegister.ThisRegister.Find(PrimaryKey);
            //delete the record 
            AllRegister.Delete();
            //now find the record
            Boolean Found = AllRegister.ThisRegister.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByUsernameMethodOK()
        {
            clsRegisterCollection AllRegister = new clsRegisterCollection();
            clsRegisterCollection FilteredUsername = new clsRegisterCollection();
            FilteredUsername.Filter("");
            Assert.AreEqual(AllRegister.Count, FilteredUsername.Count);
        }

        [TestMethod]
        public void ReportByUsernameNoneFound()
        {
            clsRegisterCollection AllRegister = new clsRegisterCollection();
            clsRegisterCollection FilteredUsername = new clsRegisterCollection();
            FilteredUsername.Filter("mnb");
            Assert.AreEqual(0, FilteredUsername.Count);
        }

        [TestMethod]
        public void FilterByUsernameTestDataFound()
        {
            //create an instance of the class we want to create
            clsRegisterCollection FilteredUsername = new clsRegisterCollection();
            
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //non-existing username
            FilteredUsername.Filter("ggggg");

            //check the ucorrect is found
            if (FilteredUsername.Count == 2)
            {
                //checked to see that the first record is 23
                if (FilteredUsername.RegisterList[0].E_Id != 23)
                {
                    OK = false;
                }
                if (FilteredUsername.RegisterList[1].E_Id != 26)
                {
                    OK = false;
                }

            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }



    }
}
