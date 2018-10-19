using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        //[TestMethod]
        public void DefaultConstructorTest()
        {
            // Arrange
            var c1 = new Customer();
            //var c2 = new Customer();

            // Act

            // Assert
            Assert.AreEqual(c1.CustomerId, 0);

        }
        [TestMethod]
        public void StaticTest()
        {
            // Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            var c2 = new Customer();
            c1.FirstName = "Frodo";
            var c3 = new Customer();
            c1.FirstName = "Rosie";

            // Act


            // Assert
            Assert.AreEqual(Customer.InstanceCount, 3);

        }
        [TestMethod]
        public void FullNameTestValid()
        {
            // -- Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";
            string expected = "Baggins, Bilbo";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // -- Arrange
            Customer customer = new Customer();
            customer.LastName = "Baggins";
            string expected = "Baggins";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // -- Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            string expected = "Bilbo";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            var customer = new Customer();
            customer.LastName = "Baggins";
            customer.EmailAddress = "fbaggins@hobbiton.me";

            var expected = true;

            // Act
            var actual = customer.Validata();

            // Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            // Arrange
            var customer = new Customer();
            customer.EmailAddress = "fbaggins@hobbiton.me";

            var expected = false;

            // Act
            var actual = customer.Validata();

            // Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void ValidateMissingEmailAddress()
        {
            // Arrange
            var customer = new Customer();
            customer.LastName = "Baggins";

            var expected = false;

            // Act
            var actual = customer.Validata();

            // Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void ValidateWhiteSpaceLastName()
        {
            // Arrange
            var customer = new Customer();
            customer.LastName = "";
            customer.EmailAddress = "fbaggins@hobbiton.me";

            var expected = false;

            // Act
            var actual = customer.Validata();

            // Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
