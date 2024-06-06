using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing2
{
    [TestClass]
    public class CMS
    {

        // GOOD TEST DATA
        string CustomerName = "Hasibe";
        string CustomerEmail = "hasibeegencc@gmail.com";
        string CustomerPassword = "Hasibe03";
        string CustomerPostCode = "LE1 1ST";
        string DateAdded = DateTime.Now.ToShortDateString();

        public string Membership { get; private set; }

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
            aCustomer.DateAdded = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aCustomer.DateAdded, TestData);
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
        public void FindCustomerIdMethodOK()
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
        public void TestDateAddedFound()
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
            if (aCustomer.DateAdded != Convert.ToDateTime("30/05/2024"))
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
            if (aCustomer.CustomerEmail != "hasibeegencc@gmail.com")
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
            if (aCustomer.PostCode != "SS0")
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

        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to create
            clsCms aCustomer = new clsCms();
            //string variable to store any error message
            String Error = "";
            // invoke the method
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        //============parameter test for name
        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string CustomerName = "";

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMin()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string CustomerName = "a";

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMinPlussOne()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string CustomerName = "ac";

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";
            string CustomerName = "";
            //create some test to pass to the method
            CustomerName = CustomerName.PadRight(19, 'a');
            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMax()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";
            string CustomerName = "";

            //create some test to pass to the method
            CustomerName = CustomerName.PadRight(50, 'a');

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string CustomerName = new string('a', 100);

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";
            string CustomerName = "";
            //create some test to pass to the method
            CustomerName = CustomerName.PadRight(51,'a');

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMid()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";
            string CustomerName = "";
            //create some test to pass to the method
            CustomerName = CustomerName.PadRight(10,'a');

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        
        //============parameter test for DateAdded
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsCms aCustomer = new clsCms();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsCms aCustomer = new clsCms();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString("");
            //invoke the method
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

            
        }
        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsCms aCustomer = new clsCms();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCms aCustomer = new clsCms();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsCms aCustomer = new clsCms();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string DateAdded = "This is mot a date!";
            //invoke the method
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

       // ============parameter test for password
        [TestMethod]
        public void CustomerPasswordMinLessOne()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string CustomerPassword = "aaaa";

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPasswordMin()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string CustomerPassword = "aaaaa";

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPasswordMinPlussOne()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string CustomerPassword = "aaaaaa";

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMaxLessOne()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";
            string CustomerPassword = "";
            //create some test to pass to the method
            CustomerPassword = CustomerPassword.PadRight(19, 'a');
            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPasswordMax()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";
            string CustomerPassword = "";

            //create some test to pass to the method
            CustomerPassword = CustomerPassword.PadRight(20, 'a');

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPasswordExtremeMax()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string CustomerPassword = new string('a', 100);

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPasswordMaxPlusOne()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";
            string CustomerPassword = "";
            //create some test to pass to the method
            CustomerPassword = CustomerPassword.PadRight(51, 'a');

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPasswordMid()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";
            string CustomerPassword = "";
            //create some test to pass to the method
            CustomerPassword = CustomerPassword.PadRight(10, 'a');

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //============parameter test for email
        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string CustomerEmail = "aaaaaaaaaa"; //10

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMin()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string CustomerPassword = "aaaaaaaaaa";//11

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMinPlussOne()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string CustomerPassword = "aaaaaaaaaaa";//12

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";
            string CustomerEmail = "";
            //create some test to pass to the method
            CustomerEmail = CustomerEmail.PadRight(49, 'a');
            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMax()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";
            string CustomerEmail = "";

            //create some test to pass to the method
            CustomerEmail = CustomerEmail.PadRight(50, 'a');

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailExtremeMax()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string CustomerEmail = new string('a', 100);

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";
            string CustomerEmail = "";
            //create some test to pass to the method
            CustomerEmail = CustomerEmail.PadRight(51, 'a');

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMid()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";
            string CustomerEmail = "";
            //create some test to pass to the method
            CustomerEmail = CustomerEmail.PadRight(25, 'a');

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //============parameter test for postCode

        [TestMethod]
        public void CustomerPostCodeMinLessOne()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string CustomerPostCode = "aaa"; //3

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPostCodeMin()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string CustomerPostCode = "aaaa";//4

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPostCodeMinPlussOne()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string CustomerPostCode = "aaaaa";//5

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMaxLessOne()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";
            string CustomerPostCode = "";
            //create some test to pass to the method
            CustomerPostCode = CustomerPostCode.PadRight(9, 'a');
            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPostCodeMax()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";
            string CustomerEmail = "";

            //create some test to pass to the method
            CustomerEmail = CustomerEmail.PadRight(10, 'a');

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPostCodeExtremeMax()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string CustomerPostCode = new string('a', 50);

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPostCodeMaxPlusOne()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";
            string CustomerPostCode = "";
            //create some test to pass to the method
            CustomerPostCode = CustomerPostCode.PadRight(11, 'a');

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPostCodeMid()
        {
            //Create a instamce of the class we want to create 
            clsCms aCustomer = new clsCms();

            //string variable for error message 
            String Error = "";
            string CustomerPostCode = "";
            //create some test to pass to the method
            CustomerPostCode = CustomerPostCode.PadRight(5, 'a');

            //invoke the method 
            Error = aCustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerPostCode, DateAdded, Membership);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}

