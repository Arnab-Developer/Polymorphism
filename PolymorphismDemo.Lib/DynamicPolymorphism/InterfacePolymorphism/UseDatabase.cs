namespace PolymorphismDemo.Lib.DynamicPolymorphism.InterfacePolymorphism
{
    public class UseDatabase
    {
        public string Use(IDatabase database)
        {
            return database.ToString();
        }
    }
}
