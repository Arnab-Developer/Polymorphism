using PolymorphismDemo.Lib.StaticPolymorphism;
using Xunit;

namespace PolymorphismDemo.Test.StaticPolymorphismTests
{
    public class IndexerOverloadingTest
    {
        [Fact]
        public void Can_IndexerOverloading_ReturnProperMessage()
        {
            IndexerOverloading indexerOverloading = new();

            indexerOverloading[0] = "Rahul";
            indexerOverloading[1] = "Mita";
            indexerOverloading[2] = "Sam";

            Assert.Equal("Rahul", indexerOverloading["Position1"]);
            Assert.Equal("Mita", indexerOverloading["Position2"]);
            Assert.Equal("Sam", indexerOverloading["Position3"]);
        }
    }
}
