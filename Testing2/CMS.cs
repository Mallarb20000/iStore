using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class CMS
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCms aCustomer = new clsCms();
            Assert.IsNotNull(aCustomer);
        }

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
            string TestData = "LE1 1ST";
            //assign the data to the property 
            aCustomer.PostCode = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aCustomer.PostCode, TestData);


        }

        [TestMethod]
        public void MemebershipPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCms aCustomer = new clsCms();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property 
            aCustomer.Membership = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aCustomer.Membership, TestData);
        }
        //===========find method tests
        [TestMethod]
        public void FindCustomerIdMethodOk()
        {
            // Create an instance of the class we want to test
            clsCms aCustomer = new clsCms();

            // Create a boolean variable to store the results of the validation
            Boolean Found = false;
            // Create some test data to use with the method
            Int32 CustomerId = 1;
            // Invoke the method
            Found = aCustomer.Find(CustomerId);

            // Test to see if the result is true
            Assert.IsTrue(Found);

        }
        //========Property data tests


        [TestMethod]
        public void TestCustomerIdFound()
        {
            // Create an instance of the class we want to test
            clsCms aCustomer = new clsCms();

            Boolean Found = false;
            // Create a boolean variable to record if the data is OK
            Boolean OK = true;

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
        public void TestTimeStrapFound()
        {
            //create an instance of the class we want to create
            clsCms aCustomer = new clsCms();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = aCustomer.Find(CustomerId);
            //check the timestamp property
            if (aCustomer.TimeStrap != Convert.ToDateTime("12/10/2023"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        { //create an instance of the class we want to create
            clsCms aCustomer = new clsCms();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = aCustomer.Find(CustomerId);
            //check the timestamp property
            if (aCustomer.CustomerName != "Hasibe Genc")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCustomerEmailFound()
        { //create an instance of the class we want to create
            clsCms aCustomer = new clsCms();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = aCustomer.Find(CustomerId);
            //check the timestamp property
            if (aCustomer.CustomerEmail != "Hasibeegencc@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerPasswordFound()
        { //create an instance of the class we want to create
            clsCms aCustomer = new clsCms();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = aCustomer.Find(CustomerId);
            //check the timestamp property
            if (aCustomer.CustomerPassword != "Hasibe03")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPostCodeFound()
        { //create an instance of the class we want to create
            clsCms aCustomer = new clsCms();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = aCustomer.Find(CustomerId);
            //check the timestamp property
            if (aCustomer.PostCode != "LE1 1ST")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestMembershipFound()
        { //create an instance of the class we want to create
            clsCms aCustomer = new clsCms();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = aCustomer.Find(CustomerId);
            //check the timestamp property
            if (aCustomer.Membership != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }

}

