using PolymorphismDemo.Lib.DynamicPolymorphism.InterfacePolymorphism;
using Xunit;

namespace PolymorphismDemo.Test.DynamicPolymorphismTests
{
    public class InterfacePolymorphismTest
    {
        [Fact]
        public void Can_SqlServer_ReturnProperMessage()
        {
            IDatabase database = new SqlServer();
            UseDatabase useDatabase = new();
            string message = useDatabase.Use(database);
            Assert.Equal("Database name: Sql Server\nCreated by: Microsoft\nOpen source: False", message);
        }

        [Fact]
        public void Can_Oracle_ReturnProperMessage()
        {
            IDatabase database = new Oracle();
            UseDatabase useDatabase = new();
            string message = useDatabase.Use(database);
            Assert.Equal("Database name: Oracle\nCreated by: Oracle\nOpen source: False", message);
        }

        [Fact]
        public void Can_MySql_ReturnProperMessage()
        {
            IDatabase database = new MySql();
            UseDatabase useDatabase = new();
            string message = useDatabase.Use(database);
            Assert.Equal("Database name: My Sql\nCreated by: My Sql\nOpen source: True", message);
        }
    }
}
