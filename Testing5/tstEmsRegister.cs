using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstEmsRegister
    {
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
            Int32 TestData = 1;
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
            Int32 E_Id = 1;
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
            Int32 E_Id = 1;
            //invoke the method
            Found = ARegister.Find(E_Id);
            //check the E_Id property
            if (ARegister.E_Id != 1)
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
            Int32 E_Id = 1;
            //invoke the method
            Found = ARegister.Find(E_Id);
            //check the username property
            if (ARegister.Username != "Qwe")
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
            Int32 E_Id = 1;
            //invoke the method
            Found = ARegister.Find(E_Id);
            //check the name property
            if (ARegister.Name != "Qwe")
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
            Int32 E_Id = 1;
            //invoke the method
            Found = ARegister.Find(E_Id);
            //check the password property
            if (ARegister.Password != "Qwe")
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
            Int32 E_Id = 1;
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
            Int32 E_Id = 1;
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
            Int32 E_Id = 1;
            //invoke the method
            Found = ARegister.Find(E_Id);
            //check the timestamp property
            if (ARegister.Timestamp != Convert.ToDateTime("10/10/2023"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
