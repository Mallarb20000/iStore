using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstEmsRegister
    {

        
            //good test data
            string Username = "qwe";
            string Name = "qwe";
            string password = "password";
            string Timestamp = DateTime.Now.ToShortDateString();
            string Salary = Convert.ToString("1000");
        
        /******************INSTANCE OF THE CLASS TEST******************/

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsRegister ARegister = new clsRegister();
            //test to see that it exists
            Assert.IsNotNull(ARegister);
        }

        /******************PROPERTY OK TESTS******************/

        [TestMethod]
        public void UsernamePropertyOK()
        {
            //create an instance of the class we want to create
            clsRegister ARegister = new clsRegister();
            //create some test data to assign to the property
            string TestData = "TestUsername";
            //assign the data to the property
            ARegister.Username = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ARegister.Username, TestData);
        }

        [TestMethod]
        public void E_IdPropertyOK()
        {
            //create an instance of the class we want to create
            clsRegister ARegister = new clsRegister();
            //create some test data to assign to the property
            Int32 TestData = 3;
            //assign the data to the property
            ARegister.E_Id = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ARegister.E_Id, TestData);
        }

        [TestMethod]
        public void SalaryPropertyOK()
        {
            //create an instance of the class we want to create
            clsRegister ARegister = new clsRegister();
            //create some test data to assign to the property
            Int32 TestData = 50000;
            //assign the data to the property
            ARegister.Salary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ARegister.Salary, TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsRegister ARegister = new clsRegister();
            //create some test data to assign to the property
            string TestData = "TestName";
            //assign the data to the property
            ARegister.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ARegister.Name, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsRegister ARegister = new clsRegister();
            //create some test data to assign to the property
            string TestData = "TestPassword";
            //assign the data to the property
            ARegister.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ARegister.Password, TestData);
        }

        [TestMethod]
        public void TrainedPropertyOK()
        {
            //create an instance of the class we want to create
            clsRegister ARegister = new clsRegister();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ARegister.Trained = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ARegister.Trained, TestData);
        }

        [TestMethod]
        public void TimestampPropertyOK()
        {
            //create an instance of the class we want to create
            clsRegister ARegister = new clsRegister();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now;
            //assign the data to the property
            ARegister.Timestamp = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ARegister.Timestamp, TestData);
        }

        /******************FIND METHOD TEST******************/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsRegister ARegister = new clsRegister();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 E_Id = 3;
            //invoke the method
            Found = ARegister.Find(E_Id);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        /******************PROPERTY DATA TESTS******************/

        [TestMethod]
        public void TestE_IdFound()
        {
            //create an instance of the class we want to create
            clsRegister ARegister = new clsRegister();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 E_Id = 3;
            //invoke the method
            Found = ARegister.Find(E_Id);
            //check the E_Id property
            if (ARegister.E_Id != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

     

        [TestMethod]
        public void TestUsernameFound()
        {
            //create an instance of the class we want to create
            clsRegister ARegister = new clsRegister();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 E_Id = 3;
            //invoke the method
            Found = ARegister.Find(E_Id);
            //check the username property
            if (ARegister.Username != "malla")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsRegister ARegister = new clsRegister();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 E_Id = 3;
            //invoke the method
            Found = ARegister.Find(E_Id);
            //check the name property
            if (ARegister.Name != "malla")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPasswordFound()
        {
            //create an instance of the class we want to create
            clsRegister ARegister = new clsRegister();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 E_Id = 3;
            //invoke the method
            Found = ARegister.Find(E_Id);
            //check the password property
            if (ARegister.Password != "malla")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTrainedFound()
        {
            //create an instance of the class we want to create
            clsRegister ARegister = new clsRegister();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 E_Id = 3;
            //invoke the method
            Found = ARegister.Find(E_Id);
            //check the trained property
            if (ARegister.Trained != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSalaryFound()
        {
            //create an instance of the class we want to create
            clsRegister ARegister = new clsRegister();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 E_Id = 3;
            //invoke the method
            Found = ARegister.Find(E_Id);
            //check the trained property
            if (ARegister.Salary != Convert.ToInt32("1000"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTimestampFound()
        {
            //create an instance of the class we want to create
            clsRegister ARegister = new clsRegister();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 E_Id = 3;
            //invoke the method
            Found = ARegister.Find(E_Id);
            //check the timestamp property
            if (ARegister.Timestamp != Convert.ToDateTime("12/10/2023"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //Create a instamce of the class we want to create 
            clsRegister ARegister = new clsRegister();

            //string variable for error message 
            String Error = "";

            //invoke the method 
            Error = ARegister.Valid(Username, Name, password, Salary, Timestamp);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            //Create a instamce of the class we want to create 
            clsRegister ARegister = new clsRegister();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string Name = "";

            //invoke the method 
            Error = ARegister.Valid(Username, Name, password, Salary, Timestamp);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            //Create a instamce of the class we want to create 
            clsRegister ARegister = new clsRegister();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string Name = "a";

            //invoke the method 
            Error = ARegister.Valid(Username, Name, password, Salary, Timestamp);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinplusone()
        {
            //Create a instamce of the class we want to create 
            clsRegister ARegister = new clsRegister();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string Name = "ab";

            //invoke the method 
            Error = ARegister.Valid(Username, Name, password, Salary, Timestamp);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            //Create a instamce of the class we want to create 
            clsRegister ARegister = new clsRegister();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            //invoke the method 
            Error = ARegister.Valid(Username, Name, password, Salary, Timestamp);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            //Create a instamce of the class we want to create 
            clsRegister ARegister = new clsRegister();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string Name = "aaaaaaaaaaa";

            //invoke the method 
            Error = ARegister.Valid(Username, Name, password, Salary, Timestamp);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            //Create a instamce of the class we want to create 
            clsRegister ARegister = new clsRegister();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string Name = "aaa";

            //invoke the method 
            Error = ARegister.Valid(Username, Name, password, Salary, Timestamp);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            //Create a instamce of the class we want to create 
            clsRegister ARegister = new clsRegister();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string Name = new string('a', 101);

            //invoke the method 
            Error = ARegister.Valid(Username, Name, password, Salary, Timestamp);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            //Create a instamce of the class we want to create 
            clsRegister ARegister = new clsRegister();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string Name = Name.PadRight(500, 'a');

            //invoke the method 
            Error = ARegister.Valid(Username, Name, password, Salary, Timestamp);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
            public void UsernameMinLessOne()
            {
                clsRegister ARegister = new clsRegister();
                string Error = "";
                string Username = "";  // 0 characters
                Error = ARegister.Valid(Username, Name, password, Salary, Timestamp);
                Assert.AreNotEqual("", Error, "UsernameMinLessOne test failed: No error message was returned for an empty username.");
            }

            [TestMethod]
            public void UsernameMin()
            {
                clsRegister ARegister = new clsRegister();
                string Error = "";
                string Username = "a";  // 1 character
                Error = ARegister.Valid(Username, Name, password, Salary, Timestamp);
                Assert.AreEqual("", Error, "UsernameMin test failed: An error message was returned for a valid username.");
            }

            [TestMethod]
            public void UsernameMinPlusOne()
            {
                clsRegister ARegister = new clsRegister();
                string Error = "";
                string Username = "ab";  // 2 characters
                Error = ARegister.Valid(Username, Name, password, Salary, Timestamp);
                Assert.AreEqual("", Error, "UsernameMinPlusOne test failed: An error message was returned for a valid username.");
            }

            [TestMethod]
            public void UsernameMaxLessOne()
            {
                clsRegister ARegister = new clsRegister();
                string Error = "";
                string Username = new string('a', 99);  // 99 characters
                Error = ARegister.Valid(Username, Name, password, Salary, Timestamp);
                Assert.AreEqual("", Error, "UsernameMaxLessOne test failed: An error message was returned for a valid username.");
            }

            [TestMethod]
            public void UsernameMax()
            {
                clsRegister ARegister = new clsRegister();
                string Error = "";
                string Username = new string('a', 100);  // 100 characters
                Error = ARegister.Valid(Username, Name, password, Salary, Timestamp);
                Assert.AreEqual("", Error, "UsernameMax test failed: An error message was returned for a valid username.");
            }

            [TestMethod]
            public void UsernameMaxPlusOne()
            {
                clsRegister ARegister = new clsRegister();
                string Error = "";
                string Username = new string('a', 101);  // 101 characters
                Error = ARegister.Valid(Username, Name, password, Salary, Timestamp);
                Assert.AreNotEqual("", Error, "UsernameMaxPlusOne test failed: No error message was returned for a username exceeding the maximum length.");
            }

            [TestMethod]
            public void UsernameMid()
            {
                clsRegister ARegister = new clsRegister();
                string Error = "";
                string Username = new string('a', 50);  // 50 characters
                Error = ARegister.Valid(Username, Name, password, Salary, Timestamp);
                Assert.AreEqual("", Error, "UsernameMid test failed: An error message was returned for a valid username.");
            }
        }







    }

