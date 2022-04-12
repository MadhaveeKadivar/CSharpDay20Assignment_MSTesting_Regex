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
        //Checking for multiple mobile numbers
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
        [TestMethod]
        //Checking for multiple password samples
        [DataRow("dfghnjvbn", true)]
        [DataRow("ADF@#$%JVGB", true)]
        [DataRow("FVGdf", false)]
        [DataRow("8745fgvhA", true)]
        public void GivenPasswordRule1Validation(string password, bool expected) // Testing for Password Rule - 1  Validation
        {
            //Act
            bool actual = validation.PasswordRule1Validation(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        //Checking for multiple password samples
        [DataRow("dfghnjvbn", false)]
        [DataRow("A5sdf@#34", true)]
        [DataRow("FVGdf", false)]
        [DataRow("wsdfgADFG65@3", true)]
        public void GivenPasswordRule2Validation(string password, bool expected) // Testing for Password Rule - 2  Validation
        {
            //Act
            bool actual = validation.PasswordRule2Validation(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        //Checking for multiple password samples
        [DataRow("dfgDnjvbn", false)]
        [DataRow("A5sdf@#df", true)]
        [DataRow("F5G@f", false)]
        [DataRow("8465ADFG", true)]
        public void GivenPasswordRule3Validation(string password, bool expected) // Testing for Password Rule - 3  Validation
        {
            //Act
            bool actual = validation.PasswordRule3Validation(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
