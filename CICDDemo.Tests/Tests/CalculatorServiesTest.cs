using CICDDemo.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CICDDemo.Tests.Tests
{
    [TestFixture]
    public class CalculatorServiesTest
    {
        [Test]
        public void Add_TwoNumbers_ReturnsSum()
        {
            // Arrange
            var calculatorService = new CalculatorService();
            int a = 5;
            int b = 10;
            // Act 
            int result = calculatorService.Add(a, b);
            // Assert
            Assert.That(result, Is.EqualTo(15));
        }
    }
}
