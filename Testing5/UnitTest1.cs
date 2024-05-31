﻿using ClassLibrary;
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
        public void AddressListOK()
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
            TestRegister.E_Id = 1;
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



    }
}
