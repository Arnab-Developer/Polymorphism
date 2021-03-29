using PolymorphismDemo.Lib.StaticPolymorphism;
using Xunit;

namespace PolymorphismDemo.Test.StaticPolymorphismTests
{
    public class OperatorOverloadingTest
    {
        [Fact]
        public void Can_AdditionOperator_ReturnCorrectValue()
        {
            OperatorOverloading sourceOperatorOverloading1 = new(10, 20);
            OperatorOverloading sourceOperatorOverloading2 = new(20, 30);

            OperatorOverloading targetOperatorOverloading = sourceOperatorOverloading1 + sourceOperatorOverloading2;

            Assert.Equal(30, targetOperatorOverloading.X);
            Assert.Equal(50, targetOperatorOverloading.Y);
        }

        [Fact]
        public void Can_SubstrationOperatorTest_ReturnCorrectValue()
        {
            OperatorOverloading sourceOperatorOverloading1 = new(10, 20);
            OperatorOverloading sourceOperatorOverloading2 = new(20, 34);

            OperatorOverloading targetOperatorOverloading = sourceOperatorOverloading1 - sourceOperatorOverloading2;

            Assert.Equal(-10, targetOperatorOverloading.X);
            Assert.Equal(-14, targetOperatorOverloading.Y);
        }

        [Fact]
        public void Can_MultiplicationOperatorTest_ReturnCorrectValue()
        {
            OperatorOverloading sourceOperatorOverloading1 = new(10, 20);
            OperatorOverloading sourceOperatorOverloading2 = new(20, 30);

            OperatorOverloading targetOperatorOverloading = sourceOperatorOverloading1 * sourceOperatorOverloading2;

            Assert.Equal(200, targetOperatorOverloading.X);
            Assert.Equal(600, targetOperatorOverloading.Y);
        }

        [Fact]
        public void Can_DivitionOperatorTest_ReturnCorrectValue()
        {
            OperatorOverloading sourceOperatorOverloading1 = new(145, 20);
            OperatorOverloading sourceOperatorOverloading2 = new(45, 214);

            OperatorOverloading targetOperatorOverloading = sourceOperatorOverloading1 / sourceOperatorOverloading2;

            Assert.Equal(3.2222222222222223, targetOperatorOverloading.X);
            Assert.Equal(0.09345794392523364, targetOperatorOverloading.Y);
        }
    }
}
