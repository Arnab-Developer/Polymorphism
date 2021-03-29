namespace PolymorphismDemo.Lib.DynamicPolymorphism.InterfacePolymorphism
{
    public class SqlServer : Database
    {
        public SqlServer()
        {
            Name = "Sql Server";
            CreaterName = "Microsoft";
            IsOpenSource = false;
        }
    }
}
