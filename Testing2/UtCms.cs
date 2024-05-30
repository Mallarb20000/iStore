using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace TestingCms
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]


        //================ instance of the class test
        public void InstanceOK()
        {
            clsCms aCustomer = new clsCms();
            Assert.IsNotNull(aCustomer);
        }


        //=================property ok tests
 
        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCms aCustomer = new clsCms();
            //create some test data to assign to the property 
            Int32 TestData = 1;
            //assign the data to the property 
            aCustomer.CustomerId = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aCustomer.CustomerId, TestData);
        }
        [TestMethod]
        public void CustomerTimeStrapPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCms aCustomer = new clsCms();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now;
            //assign the data to the property 
            aCustomer.TimeStrap = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aCustomer.TimeStrap, TestData);
        }
        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            //create an instance of the class we want to create 
            clsCms aCustomer = new clsCms();
            //create some test data to assign to the property 
            string TestData = "Hasibe Genc";
            //assign the data to the property 
            aCustomer.CustomerName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aCustomer.CustomerName, TestData);

        }
        [TestMethod]

        public void CustomerEmailPropertyOK()
        {
            // Create an instance of the class we want to test
            clsCms aCustomer = new clsCms();

            // Create some test data to assign to the property
            string TestData = "hasibeegencc@gmail.com";

            // Assign the data to the property
            aCustomer.CustomerEmail = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(aCustomer.CustomerEmail, TestData);
        }
        [TestMethod]
        public void CustomerPasswordPropertyOK()
        {
            // Create an instance of the class we want to test
            clsCms aCustomer = new clsCms();

            // Create some test data to assign to the property
            string TestData = "Hasibe03";

            // Assign the data to the property
            aCustomer.CustomerPassword = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(aCustomer.CustomerPassword, TestData);
        }
        [TestMethod]
        public void CustomerPostCodePropertyOK()
        {
            //create an instance of the class we want to create 
            clsCms aCustomer = new clsCms();
            //create some test data to assign to the property 
            string TestData = "LE1 4AB";
            //assign the data to the property 
            aCustomer.PostCode=TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aCustomer.PostCode, TestData);


        }

        [TestMethod]
        public void MemebershipActivePropertyOK()
        {
            //create an instance of the class we want to create 
            clsCms aCustomer = new clsCms();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property 
            aCustomer.Active = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aCustomer.Active, TestData);
        }

        //===========find method tests


        [TestMethod]
        public void FindCustomerIdMethodOk()
        {
            // Create an instance of the class we want to test
            clsCms aCustomer = new clsCms();

            // Create a boolean variable to store the results of the validation
            bool Found = false;

            // Create some test data to use with the method
            int CustomerId = 1;

            // Invoke the method
            Found = aCustomer.Find(CustomerId);

            // Test to see if the result is true
            Assert.IsTrue(Found);

        }

       //========Property data tests

        
        [TestMethod]
        public void TestCustomerIdMethodOK()
        {
            // Create an instance of the class we want to test
            clsCms aCustomer = new clsCms();

            Boolean Found = false;
            // Create a boolean variable to record if the data is OK
            Boolean OK = false;

            // Create some test data to use with the method
            Int32 CustomerId = 1;

            //check the Customer id
            Found = aCustomer.Find(CustomerId);

            if (aCustomer.CustomerId != 1)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);   


            
        }
        [TestMethod]
        public void TestCustomerDateAddedPropertyOK()
        {
            // Create an instance of the class we want to test
            clsCms aCustomer = new clsCms();

            // Create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;

            // Assign the data to the property
            aCustomer.TimeStrap = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(aCustomer.TimeStrap, TestData);
        }


        [TestMethod]
        public void TestCustomerNamePropertyOK()
        {
            // Create an instance of the class we want to test
            clsCms aCustomer = new clsCms();

            // Create some test data to assign to the property
            int TestData = 100;

            // Assign the data to the property
            aCustomer.CustomerName = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(aCustomer.CustomerName, TestData);
        }

        [TestMethod]
        public void TestCustomerEmailPropertyOK()
        {
            // Create an instance of the class we want to test
            clsCms aCustomer = new clsCms();

            // Create some test data to assign to the property
            string TestData = "hasibeegenc@gmail.com";

            // Assign the data to the property
            aCustomer.CustomerEmail = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(aCustomer.CustomerEmail, TestData);
        }
        [TestMethod]
        public void TestCustomerPasswordPropertyOK()
        {
            // Create an instance of the class we want to test
            clsCms aCustomer = new clsCms();

            // Create some test data to assign to the property
            string TestData = "Hasibe2003";

            // Assign the data to the property
            aCustomer.CustomerPassword = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(aCustomer.CustomerPassword, TestData);
        }

        [TestMethod]
        public void TestCustomerPostCodePropertyOK()
        {
            // Create an instance of the class we want to test
            clsCms aCustomer = new clsCms();

            // Create some test data to assign to the property
            string TestData = "LE1 4AB";

            // Assign the data to the property
            aCustomer.PostCode= TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(aCustomer.PostCode, TestData);
        }
        [TestMethod]
        public void TestMembershipActivePropertyOK()
        {
            // Create an instance of the class we want to test
            clsCms aCustomer = new clsCms();

            // Create some test data to assign to the property
            bool TestData = true;

            // Assign the data to the property
            aCustomer.Active = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(aCustomer.Active, TestData);
        }

    }
    
}




   
