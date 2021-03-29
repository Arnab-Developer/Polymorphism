using PolymorphismDemo.Lib.StaticPolymorphism;
using Xunit;

namespace PolymorphismDemo.Test.StaticPolymorphismTests
{
    public class MethodOverloadingTest
    {
        [Fact]
        public void Can_MethodOveloading_ReturnCorrectValue_ForIntArray()
        {
            MethodOverloading theMethodOverloading = new();
            Assert.Equal(199, theMethodOverloading.Addition(12, 22, 10, 34, 55, 33, 33));
        }

        [Fact]
        public void Can_MethodOveloading_ReturnCorrectValue_ForTwoInts()
        {
            MethodOverloading theMethodOverloading = new();
            Assert.Equal(34, theMethodOverloading.Addition(12, 22));
        }

        [Fact]
        public void Can_MethodOveloading_ReturnCorrectValue_ForThreeInts()
        {
            MethodOverloading theMethodOverloading = new();
            Assert.Equal(48, theMethodOverloading.Addition(12, 22, 14));
        }

        [Fact]
        public void Can_MethodOveloading_ReturnCorrectValue_ForTwoDoubles()
        {
            MethodOverloading theMethodOverloading = new();
            Assert.Equal(35.2, theMethodOverloading.Addition(12.4, 22.8));
        }

        [Fact]
        public void Can_MethodOveloading_ReturnCorrectValue_ForThreeDoubles()
        {
            MethodOverloading theMethodOverloading = new();
            Assert.Equal(49.699999999999996, theMethodOverloading.Addition(12.5, 22.8, 14.4));
        }

        [Fact]
        public void Can_MethodOveloading_ReturnCorrectValue_ForDoubleArray()
        {
            MethodOverloading theMethodOverloading = new();
            Assert.Equal(203.20000000000002, theMethodOverloading.Addition(12.4, 22.8, 10.5, 34.7, 55.9, 33.4, 33.5));
        }
    }
}
