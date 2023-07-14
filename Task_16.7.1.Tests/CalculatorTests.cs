using NUnit.Framework;

namespace Task_16._7._1.Tests
{
        [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Additional_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Additional(5, 3) == 8);
        }

        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Subtraction(5, 3) == 2);
        }
        [Test]
        public void Miltiplication_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Miltiplication(5, 3) == 15);
        }
        [Test]
        public void Division_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(6, 3) == 2);
        }
    }
}
