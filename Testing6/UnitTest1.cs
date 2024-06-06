using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class UserPurchasesTests
        {
            private readonly string _connectionString = ConfigurationManager.ConnectionStrings["Dbcon"].ConnectionString;

            [TestInitialize]
            public void TestInitialize()
            {
                // Set up initial state
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = "DELETE FROM UserPurchases WHERE CustomerEmail = 'test@example.com'";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            [TestMethod]
            public void TestCreate()
            {
                // Arrange
                UserPurchases purchase = new UserPurchases
                {
                    CustomerID = 1,
                    ProductID = 1,
                    CustomerEmail = "test@example.com",
                    Product = "Test Product",
                    DatetimeStamp = DateTime.Now
                };

                // Act
                bool result = purchase.Create();

                // Assert
                Assert.IsTrue(result);
            }

            [TestMethod]
            public void TestRead()
            {
                // Arrange
                UserPurchases purchase = new UserPurchases
                {
                    CustomerID = 1,
                    ProductID = 1,
                    CustomerEmail = "test@example.com",
                    Product = "Test Product",
                    DatetimeStamp = DateTime.Now
                };
                purchase.Create();

                // Act
                bool result = purchase.Read(1, 1);

                // Assert
                Assert.IsTrue(result);
                Assert.AreEqual("test@example.com", purchase.CustomerEmail);
                Assert.AreEqual("Test Product", purchase.Product);
            }

            [TestMethod]
            public void TestUpdate()
            {
                // Arrange
                UserPurchases purchase = new UserPurchases
                {
                    CustomerID = 1,
                    ProductID = 1,
                    CustomerEmail = "test@example.com",
                    Product = "Test Product",
                    DatetimeStamp = DateTime.Now
                };
                purchase.Create();

                // Update values
                purchase.CustomerEmail = "updated@example.com";
                purchase.Product = "Updated Product";

                // Act
                bool result = purchase.Update();

                // Assert
                Assert.IsTrue(result);

                // Verify update
                UserPurchases updatedPurchase = new UserPurchases();
                updatedPurchase.Read(1, 1);
                Assert.AreEqual("updated@example.com", updatedPurchase.CustomerEmail);
                Assert.AreEqual("Updated Product", updatedPurchase.Product);
            }

            [TestMethod]
            public void TestDelete()
            {
                // Arrange
                UserPurchases purchase = new UserPurchases
                {
                    CustomerID = 1,
                    ProductID = 1,
                    CustomerEmail = "test@example.com",
                    Product = "Test Product",
                    DatetimeStamp = DateTime.Now
                };
                purchase.Create();

                // Act
                bool result = purchase.Delete(1, 1);

                // Assert
                Assert.IsTrue(result);

                // Verify deletion
                bool readResult = purchase.Read(1, 1);
                Assert.IsFalse(readResult);
            }
        }
    }