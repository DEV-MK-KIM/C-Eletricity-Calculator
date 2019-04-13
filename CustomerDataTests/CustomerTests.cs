using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2;

namespace CustomerData.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        [TestMethod()]
        public void TestResidentialPositiveAmount()
        {
            // Arrange
            Customer cust = new Customer(1, "mk", 'R');
            int usage = 200;
            decimal expectedValue = 16.40m;
            decimal actualValue;

            // Act
            actualValue = cust.Residential(usage);

            // Assert
            Assert.AreEqual(actualValue, expectedValue);
   
        }

        [TestMethod()]
        public void TestResidentialZeroAmount()
        {
            // Arrange
            Customer cust = new Customer(1, "mk", 'R');
            int usage = 0;
            decimal expectedValue = 6.00m;
            decimal actualValue;

            // Act
            actualValue = cust.Residential(usage);

            // Assert
            Assert.AreEqual(actualValue, expectedValue);

        }

        [TestMethod()]
        public void TestCommercialMoreThanThousandAmount()
        {
            // Arrange
            Customer cust = new Customer(1, "mk", 'C');
            int usage = 1001;
            decimal expectedValue = 60.045m;
            decimal actualValue;

            // Act
            actualValue = cust.Commercial(usage);

            // Assert
            Assert.AreEqual(actualValue, expectedValue);

        }

        [TestMethod()]
        public void TestCommercialEqualOrLessThanThousandAmount()
        {
            // Arrange
            Customer cust = new Customer(1, "mk", 'C');
            int usage = 1000;
            decimal expectedValue = 60.00m;
            decimal actualValue;

            // Act
            actualValue = cust.Commercial(usage);

            // Assert
            Assert.AreEqual(actualValue, expectedValue);

        }
        [TestMethod()]
        public void TestIndustrialMoreThanThousandAmount()
        {
            // Arrange
            Customer cust = new Customer(1, "mk", 'I');
            int peak = 1001;
            int noPeak = 1001;
            decimal expectedValue = 116.093m;
            decimal actualValue;

            // Act
            actualValue = cust.Industrial(peak, noPeak);

            // Assert
            Assert.AreEqual(actualValue, expectedValue);

        }

        [TestMethod()]
        public void TestIndustrialEqualOrLessThanThousandAmount()
        {
            // Arrange
            Customer cust = new Customer(1, "mk", 'I');
            int peak = 1000;
            int noPeak = 1000;
            decimal expectedValue = 116.00m;
            decimal actualValue;

            // Act
            actualValue = cust.Industrial(peak, noPeak);

            // Assert
            Assert.AreEqual(actualValue, expectedValue);

        }


    }
}