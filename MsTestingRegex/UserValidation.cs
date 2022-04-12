using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTesting_RegularExpression;
using System;

namespace MsTestingRegex
{
    [TestClass]
    public class UserValidation
    {
        Validation validation;
        [TestInitialize]
        public void SetUp()
        {
            // common Arrange
            validation = new Validation();
        }
        [TestMethod]
        //Checking for multiple first name
        [DataRow("Madhavee",true)]
        [DataRow("Ab", false)]
        [DataRow("madhavee",false)]
        public void GivenFirstNameValidation(string firstName,bool expected) // Testing for Firstname Validation
        {
            //Act
            bool actual = validation.FirstNameValidation(firstName);
            //Assert
            Assert.AreEqual(expected, actual);            
        }
        [TestMethod]
        //Checking for multiple last name
        [DataRow("Kadivar", true)]
        [DataRow("Ab", false)]
        [DataRow("kadivar", false)]
        public void GivenLastNameValidation(string lastName, bool expected) // Testing for Lastname Validation
        {
            //Act
            bool actual = validation.FirstNameValidation(lastName);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        //Checking for multiple email samples
        [DataRow("abc123@.com", false)]
        [DataRow("abc@abc@gmail.com", false)]
        [DataRow("abc+100@gmail.com", true)]
        [DataRow("abc@1.com", true)]
        public void GivenEmailValidation(string email, bool expected) // Testing for Email Validation
        {
            //Act
            bool actual = validation.EmailValidation(email);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        //Checking for multiple email samples
        [DataRow("91 9652545874", true)]
        [DataRow("919652545874", false)]
        [DataRow("9144 9652545874", false)]
        [DataRow("91 1652545874", false)]
        public void GivenMobileNumberValidation(string mobileNumber, bool expected) // Testing for Email Validation
        {
            //Act
            bool actual = validation.MobileNumberValidation(mobileNumber);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
