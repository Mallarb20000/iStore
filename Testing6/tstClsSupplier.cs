using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstClsSupplier
    {
        [TestClass]
        public class ClsSupplierTests
        {
            // Good test data
            private string supplierName = "Good Supplier";
            private string contactName = "Good Contact";
            private string contactEmail = "good@example.com";
            private string isActive = "True";
            private string joinDate = DateTime.Now.Date.ToString();
            private string rating = "3";
            private string password = "goodPassword123";

            // SupplierName Tests
            [TestMethod]
            public void SupplierNameExtremeMin()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid("", contactName, contactEmail, isActive, joinDate, rating, password);
                Assert.AreNotEqual(error, "");
            }

            [TestMethod]
            public void SupplierNameMinBoundary()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid("a", contactName, contactEmail, isActive, joinDate, rating, password);
                Assert.AreEqual(error, "");
            }

            [TestMethod]
            public void SupplierNameMinPlusOne()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid("aa", contactName, contactEmail, isActive, joinDate, rating, password);
                Assert.AreEqual(error, "");
            }

            [TestMethod]
            public void SupplierNameMaxLessOne()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(new string('a', 49), contactName, contactEmail, isActive, joinDate, rating, password);
                Assert.AreEqual(error, "");
            }

            [TestMethod]
            public void SupplierNameMaxBoundary()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(new string('a', 50), contactName, contactEmail, isActive, joinDate, rating, password);
                Assert.AreEqual(error, "");
            }

            [TestMethod]
            public void SupplierNameMaxPlusOne()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(new string('a', 51), contactName, contactEmail, isActive, joinDate, rating, password);
                Assert.AreNotEqual(error, "");
            }

            [TestMethod]
            public void SupplierNameMid()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(new string('a', 25), contactName, contactEmail, isActive, joinDate, rating, password);
                Assert.AreEqual(error, "");
            }

            // ContactName Tests
            [TestMethod]
            public void ContactNameExtremeMin()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, "", contactEmail, isActive, joinDate, rating, password);
                Assert.AreNotEqual(error, "");
            }

            [TestMethod]
            public void ContactNameMinBoundary()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, "a", contactEmail, isActive, joinDate, rating, password);
                Assert.AreEqual(error, "");
            }

            [TestMethod]
            public void ContactNameMinPlusOne()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, "aa", contactEmail, isActive, joinDate, rating, password);
                Assert.AreEqual(error, "");
            }

            [TestMethod]
            public void ContactNameMaxLessOne()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, new string('a', 49), contactEmail, isActive, joinDate, rating, password);
                Assert.AreEqual(error, "");
            }

            [TestMethod]
            public void ContactNameMaxBoundary()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, new string('a', 50), contactEmail, isActive, joinDate, rating, password);
                Assert.AreEqual(error, "");
            }

            [TestMethod]
            public void ContactNameMaxPlusOne()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, new string('a', 51), contactEmail, isActive, joinDate, rating, password);
                Assert.AreNotEqual(error, "");
            }

            [TestMethod]
            public void ContactNameMid()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, new string('a', 25), contactEmail, isActive, joinDate, rating, password);
                Assert.AreEqual(error, "");
            }

            // ContactEmail Tests
            [TestMethod]
            public void ContactEmailExtremeMin()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, "", isActive, joinDate, rating, password);
                Assert.AreNotEqual(error, "");
            }

            [TestMethod]
            public void ContactEmailMinBoundary()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, "a", isActive, joinDate, rating, password);
                Assert.AreNotEqual(error, "");
            }

            [TestMethod]
            public void ContactEmailMinPlusOne()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, "aa", isActive, joinDate, rating, password);
                Assert.AreNotEqual(error, "");
            }

            [TestMethod]
            public void ContactEmailMaxLessOne()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, new string('a', 99), isActive, joinDate, rating, password);
                Assert.AreNotEqual(error, "");
            }

            [TestMethod]
            public void ContactEmailMaxBoundary()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, new string('a', 100), isActive, joinDate, rating, password);
                Assert.AreNotEqual(error, "");
            }

            [TestMethod]
            public void ContactEmailMaxPlusOne()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, new string('a', 101), isActive, joinDate, rating, password);
                Assert.AreNotEqual(error, "");
            }

            [TestMethod]
            public void ContactEmailMid()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, new string('a', 50), isActive, joinDate, rating, password);
                Assert.AreNotEqual(error, "");
            }

            [TestMethod]
            public void ContactEmailInvalidFormat()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, "invalidemail.com", isActive, joinDate, rating, password);
                Assert.AreNotEqual(error, "");
            }

            // IsActive Tests
            [TestMethod]
            public void IsActiveValidTrue()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, contactEmail, "True", joinDate, rating, password);
                Assert.AreEqual(error, "");
            }

            [TestMethod]
            public void IsActiveValidFalse()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, contactEmail, "False", joinDate, rating, password);
                Assert.AreEqual(error, "");
            }

            [TestMethod]
            public void IsActiveInvalidString()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, contactEmail, "Yes", joinDate, rating, password);
                Assert.AreNotEqual(error, "");
            }

            [TestMethod]
            public void IsActiveEmpty()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, contactEmail, "", joinDate, rating, password);
                Assert.AreNotEqual(error, "");
            }

            // JoinDate Tests
            [TestMethod]
            public void JoinDateExtremeMin()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, contactEmail, isActive, "1900-01-01", rating, password);
                Assert.AreEqual(error, "");
            }

            [TestMethod]
            public void JoinDateMinBoundary()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, contactEmail, isActive, DateTime.Now.AddYears(-100).ToString(), rating, password);
                Assert.AreEqual(error, "");
            }

            [TestMethod]
            public void JoinDateMinPlusOne()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, contactEmail, isActive, DateTime.Now.AddYears(-99).ToString(), rating, password);
                Assert.AreEqual(error, "");
            }

            [TestMethod]
            public void JoinDateMaxBoundary()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, contactEmail, isActive, DateTime.Now.ToString(), rating, password);
                Assert.AreEqual(error, "");
            }
 

            [TestMethod]
            public void JoinDateInvalid()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, contactEmail, isActive, "invalid date", rating, password);
                Assert.AreNotEqual(error, "");
            }
 

            [TestMethod]
            public void RatingMinBoundary()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, contactEmail, isActive, joinDate, "1", password);
                Assert.AreEqual(error, "");
            }

            [TestMethod]
            public void RatingMinPlusOne()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, contactEmail, isActive, joinDate, "2", password);
                Assert.AreEqual(error, "");
            }

            [TestMethod]
            public void RatingMaxBoundary()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, contactEmail, isActive, joinDate, "5", password);
                Assert.AreEqual(error, "");
            }

         

            [TestMethod]
            public void RatingInvalid()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, contactEmail, isActive, joinDate, "notarating", password);
                Assert.AreNotEqual(error, "");
            }

            // Password Tests
            [TestMethod]
            public void PasswordExtremeMin()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, contactEmail, isActive, joinDate, rating, "");
                Assert.AreNotEqual(error, "");
            }

            [TestMethod]
            public void PasswordMinBoundary()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, contactEmail, isActive, joinDate, rating, "a");
                Assert.AreEqual(error, "");
            }

            [TestMethod]
            public void PasswordMinPlusOne()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, contactEmail, isActive, joinDate, rating, "aa");
                Assert.AreEqual(error, "");
            }

            [TestMethod]
            public void PasswordMaxLessOne()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, contactEmail, isActive, joinDate, rating, new string('a', 99));
                Assert.AreEqual(error, "");
            }

            [TestMethod]
            public void PasswordMaxBoundary()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, contactEmail, isActive, joinDate, rating, new string('a', 100));
                Assert.AreEqual(error, "");
            }

            [TestMethod]
            public void PasswordMaxPlusOne()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, contactEmail, isActive, joinDate, rating, new string('a', 101));
                Assert.AreNotEqual(error, "");
            }

            [TestMethod]
            public void PasswordMid()
            {
                ClsSupplier supplier = new ClsSupplier();
                string error = supplier.Valid(supplierName, contactName, contactEmail, isActive, joinDate, rating, new string('a', 50));
                Assert.AreEqual(error, "");
            }
        }
    }
}
