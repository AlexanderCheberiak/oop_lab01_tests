using Lab01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab01.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void SimpleExpression()
        {
            // Arrange
            var expression = "5 + 3";
            var cellValues = new Dictionary<string, double>();

            // Act
            var result = Calculator.Evaluate(expression, cellValues);

            // Assert
            Assert.AreEqual("8", result);
        }

        [TestMethod]
        public void CellReference()
        {
            // Arrange
            var expression = "A1 + 2";
            var cellValues = new Dictionary<string, double> { { "A1", 5 } };

            // Act
            var result = Calculator.Evaluate(expression, cellValues);

            // Assert
            Assert.AreEqual("7", result);
        }

        [TestMethod]
        public void DivisionByZero()
        {
            // Arrange
            var expression = "10 / 0";
            var cellValues = new Dictionary<string, double>();

            // Act
            var result = Calculator.Evaluate(expression, cellValues);

            // Assert
            Assert.AreEqual("Помилка: ділення на 0", result);
        }
    }
}
