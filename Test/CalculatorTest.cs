using Library;

namespace Test
{
    [TestClass]
    public sealed class CalculatorTest
    {
        private Calculator _calc = null!;

        [TestInitialize]
        public void Setup()
        {
            _calc = new Calculator();
        }

        [TestMethod]
        public void Add_ReturnsCorrectSum()
        {
            var result = _calc.Addition(2, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Subtract_ReturnsCorrectValue()
        {
            var result = _calc.Subtraction(5, 3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Multiply_ReturnsCorrectValue()
        {
            var result = _calc.Multiplication(4, 3);
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void Divide_ReturnsCorrectValue()
        {
            var result = _calc.Division(10, 2);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ThrowsOnZero()
        {
            _calc.Division(10, 0);
        }

        [TestMethod]
        public void Divide_DecimalPart_CorrectValue()
        {
            var result = _calc.DivisionRest(9, 8);
            Assert.AreEqual(125, result);
        }
    }
}
