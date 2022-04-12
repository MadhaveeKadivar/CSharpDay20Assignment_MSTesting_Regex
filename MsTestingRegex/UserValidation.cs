using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTesting_RegularExpression;
using System;

namespace MsTestingRegex
{
    [TestClass]
    public class UserValidation
    {
        [TestMethod]
        //Checking for multiple first name
        [DataRow("Madhavee",true)]
        [DataRow("Ab", false)]
        [DataRow("madhavee",false)]
        public void GivenFirstNameValidation(string firstName,bool expected) // Testing for Firstname Validation
        {
            //Arrange
            Validation validation = new Validation();
            //Act
            bool actual = validation.FirstNameValidation(firstName);
            //Assert
            Assert.AreEqual(expected, actual);            
        }        
    }
}
