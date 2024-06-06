using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create 
            clsTstUser AnUser = new clsTstUser();   
            Assert.IsNotNull(AnUser);
        }
        [TestMethod]
        public void UserIdPropertyOK() 
        { 
            //Create an instance of the class we want to create 
            clsTstUser AnUser = new clsTstUser();
            // create some test data to assign to the propert
            Int32 TestData = 1;
            //assign the data to the property
            AnUser.UserId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserId,TestData);
        }
        [TestMethod]    
        public void UserNamePropertyOK()
        {
            //Create an instance of the class we want to create 
            clsTstUser AnUser = new clsTstUser();
            string TestData = "Hasibe";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName,TestData);      
        }
        [TestMethod]
        public void PasswordPropertyOK() 
        {
            //Create an instance of the class we want to create 
            clsTstUser AnUser = new clsTstUser();
            string TestData = "Hasibe03";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK() 
        {
            //Create an instance of the class we want to create 
            clsTstUser AnUser = new clsTstUser();
            string TestData = "Management";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }
        [TestMethod]
        public void RolePropertyOK() 
        {
            //Create an instance of the class we want to create 
            clsTstUser AnUser = new clsTstUser();
            // create a Boolean Variable to store the results of the validation
            Boolean Found = false;
            // create some test data to use with the method
            string UserName = "Hasibe";
            string Password = "Hasibe2003";  
            // invoke the method
            Found= AnUser.FindUser (UserName, Password);
            //test to see the result is true 
            Assert.IsTrue(Found);
            
        }
        [TestMethod]
        public void TestUserNamePWFound()
        {
            //Create an instance of the class we want to create 
            clsTstUser AnUser = new clsTstUser();
            // create a Boolean Variable to store the results of the validation
            Boolean Found = false;
            // create a Boolean varible to record if the data is OK (assume it is)
            Boolean OK= true;
            // create test data to use with the method
            string UserName = "Hasibe";
            string Password = "Hasibe03";
            //invoke the method
            Found = AnUser.FindUser (UserName, Password);
            //check the user id property
            if(AnUser.UserName!= UserName && AnUser.Password!= Password)
            {
                OK = false;     
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}
