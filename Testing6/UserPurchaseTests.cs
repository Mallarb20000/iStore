using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace UserPurchasesTests
{
    [TestClass]
    public class UserPurchasesTests
    {
        [TestInitialize]
        public void Setup()
        {
            UserPurchasesBase.ClearPurchases();
        }

        private UserPurchasesBase GetTestUserPurchase()
        {
            return new UserPurchasesBase
            {
                CustomerID = 1,
                ProductID = 1,
                CustomerEmail = "test@example.com",
                Product = "Test Product",
                DatetimeStamp = DateTime.Now
            };
        }

        [TestMethod]
        public void TestCreate()
        {
            // Arrange
            var purchase = GetTestUserPurchase();

            // Act
            bool result = purchase.Create();

            // Assert
            Assert.IsTrue(result, "Purchase should be created successfully.");
        }

        [TestMethod]
        public void TestRead()
        {
            // Arrange
            var purchase = GetTestUserPurchase();
            purchase.Create();

            // Act
            bool result = purchase.Read(purchase.CustomerID, purchase.ProductID, out UserPurchasesBase foundPurchase);

            // Assert
            Assert.IsTrue(result, "Purchase should be read successfully.");
            Assert.AreEqual("test@example.com", foundPurchase.CustomerEmail);
            Assert.AreEqual("Test Product", foundPurchase.Product);
        }

        [TestMethod]
        public void TestUpdate()
        {
            // Arrange
            var purchase = GetTestUserPurchase();
            purchase.Create();

            // Update values
            purchase.CustomerEmail = "updated@example.com";
            purchase.Product = "Updated Product";

            // Act
            bool result = purchase.Update();

            // Assert
            Assert.IsTrue(result, "Purchase should be updated successfully.");

            // Verify update
            purchase.Read(purchase.CustomerID, purchase.ProductID, out UserPurchasesBase updatedPurchase);
            Assert.AreEqual("updated@example.com", updatedPurchase.CustomerEmail);
            Assert.AreEqual("Updated Product", updatedPurchase.Product);
        }

        [TestMethod]
        public void TestDelete()
        {
            // Arrange
            var purchase = GetTestUserPurchase();
            purchase.Create();

            // Act
            bool result = purchase.Delete(purchase.CustomerID, purchase.ProductID);

            // Assert
            Assert.IsTrue(result, "Purchase should be deleted successfully.");

            // Verify deletion
            bool readResult = purchase.Read(purchase.CustomerID, purchase.ProductID, out _);
            Assert.IsFalse(readResult, "Purchase should not be found after deletion.");
        }

        [TestMethod]
        public void TestFind()
        {
            // Arrange
            var purchase = GetTestUserPurchase();
            purchase.Create();

            // Act
            bool result = purchase.Find(purchase.PurchaseID);

            // Assert
            Assert.IsTrue(result, "Purchase should be found successfully.");
            Assert.AreEqual("test@example.com", purchase.CustomerEmail);
            Assert.AreEqual("Test Product", purchase.Product);
        }

        [TestMethod]
        public void TestValid()
        {
            // Arrange
            var purchase = new UserPurchasesBase
            {
                CustomerID = -1,
                ProductID = -1,
                CustomerEmail = "",
                Product = "",
                DatetimeStamp = default(DateTime)
            };

            // Act
            string error = purchase.Valid();

            // Assert
            Assert.IsFalse(string.IsNullOrEmpty(error), "Validation should return errors.");
        }

        [TestMethod]
        public void TestValid_NoErrors()
        {
            // Arrange
            var purchase = GetTestUserPurchase();

            // Act
            string error = purchase.Valid();

            // Assert
            Assert.IsTrue(string.IsNullOrEmpty(error), "Validation should not return any errors.");
        }
    }
} 