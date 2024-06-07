using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing6
{
    [TestClass]
    public class tstClsSupplierCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            ClsSuppliersCollection allSuppliers = new ClsSuppliersCollection();
            Assert.IsNotNull(allSuppliers);
        }

        [TestMethod]
        public void SuppliersListOk()
        {
            ClsSuppliersCollection allSuppliers = new ClsSuppliersCollection();
            List<ClsSupplier> testList = new List<ClsSupplier>();
            ClsSupplier testItem = new ClsSupplier
            {
                SupplierId = 1,
                SupplierName = "Test Supplier",
                ContactName = "Test Contact",
                ContactEmail = "test@example.com",
                IsActive = true,
                JoinDate = DateTime.Now.Date,
                Rating = 5,
                Password = "testPassword"
            };
            testList.Add(testItem);
            allSuppliers.SuppliersList = testList;
            Assert.AreEqual(allSuppliers.SuppliersList, testList);
        }

        [TestMethod]
        public void ThisSupplierPropertyOk()
        {
            ClsSuppliersCollection allSuppliers = new ClsSuppliersCollection();
            ClsSupplier testSupplier = new ClsSupplier
            {
                SupplierId = 1,
                SupplierName = "Test Supplier",
                ContactName = "Test Contact",
                ContactEmail = "test@example.com",
                IsActive = true,
                JoinDate = DateTime.Now.Date,
                Rating = 5,
                Password = "testPassword"
            };
            allSuppliers.ThisSupplier = testSupplier;
            Assert.AreEqual(allSuppliers.ThisSupplier, testSupplier);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            ClsSuppliersCollection allSuppliers = new ClsSuppliersCollection();
            List<ClsSupplier> testList = new List<ClsSupplier>();
            ClsSupplier testItem = new ClsSupplier
            {
                SupplierId = 1,
                SupplierName = "Test Supplier",
                ContactName = "Test Contact",
                ContactEmail = "test@example.com",
                IsActive = true,
                JoinDate = DateTime.Now.Date,
                Rating = 5,
                Password = "testPassword"
            };
            testList.Add(testItem);
            allSuppliers.SuppliersList = testList;
            Assert.AreEqual(allSuppliers.Count, testList.Count);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            ClsSuppliersCollection allSuppliers = new ClsSuppliersCollection();
            ClsSupplier testItem = new ClsSupplier
            {
                SupplierName = "Test Supplier",
                ContactName = "Test Contact",
                ContactEmail = "test@example.com",
                IsActive = true,
                JoinDate = DateTime.Now.Date,
                Rating = 5,
                Password = "testPassword"
            };
            allSuppliers.ThisSupplier = testItem;
            int primaryKey = allSuppliers.Add();
            testItem.SupplierId = primaryKey;
            allSuppliers.ThisSupplier.Find(primaryKey);
            Assert.AreEqual(allSuppliers.ThisSupplier, testItem);
        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            ClsSuppliersCollection allSuppliers = new ClsSuppliersCollection();
            ClsSupplier testItem = new ClsSupplier
            {
                SupplierName = "Test Supplier",
                ContactName = "Test Contact",
                ContactEmail = "test@example.com",
                IsActive = true,
                JoinDate = DateTime.Now.Date,
                Rating = 5,
                Password = "testPassword"
            };
            allSuppliers.ThisSupplier = testItem;
            int primaryKey = allSuppliers.Add();
            testItem.SupplierId = primaryKey;
            allSuppliers.Delete(primaryKey);
            bool found = allSuppliers.ThisSupplier.Find(primaryKey);
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void UpdateMethodOk()
        {
            ClsSuppliersCollection allSuppliers = new ClsSuppliersCollection();
            ClsSupplier testItem = new ClsSupplier
            {
                SupplierName = "Test Supplier",
                ContactName = "Test Contact",
                ContactEmail = "test@example.com",
                IsActive = true,
                JoinDate = DateTime.Now.Date,
                Rating = 5,
                Password = "testPassword"
            };
            allSuppliers.ThisSupplier = testItem;
            int primaryKey = allSuppliers.Add();
            testItem.SupplierId = primaryKey;

            testItem.SupplierName = "Updated Supplier";
            testItem.ContactName = "Updated Contact";
            testItem.ContactEmail = "updated@example.com";
            testItem.IsActive = false;
            testItem.JoinDate = DateTime.Now.Date.AddYears(-1);
            testItem.Rating = 4;
            testItem.Password = "updatedPassword";

            allSuppliers.ThisSupplier = testItem;
            allSuppliers.Update();
            allSuppliers.ThisSupplier.Find(primaryKey);
            Assert.AreEqual(allSuppliers.ThisSupplier, testItem);
        }

        [TestMethod]
        public void IsEmailRegisteredMethodOk()
        {
            ClsSuppliersCollection allSuppliers = new ClsSuppliersCollection();
            ClsSupplier testItem = new ClsSupplier
            {
                SupplierName = "Test Supplier",
                ContactName = "Test Contact",
                ContactEmail = "unique@example.com",
                IsActive = true,
                JoinDate = DateTime.Now.Date,
                Rating = 5,
                Password = "testPassword"
            };
            allSuppliers.ThisSupplier = testItem;
            int primaryKey = allSuppliers.Add();
            bool isRegistered = allSuppliers.IsEmailRegistered("unique@example.com");
            Assert.IsTrue(isRegistered);
        }

        [TestMethod]
        public void IsEmailRegisteredMethodNotFound()
        {
            ClsSuppliersCollection allSuppliers = new ClsSuppliersCollection();
            bool isRegistered = allSuppliers.IsEmailRegistered("notfound@example.com");
            Assert.IsFalse(isRegistered);
        }
    }
}