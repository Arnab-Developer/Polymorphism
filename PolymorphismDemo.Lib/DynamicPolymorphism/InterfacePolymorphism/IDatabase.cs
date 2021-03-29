namespace PolymorphismDemo.Lib.DynamicPolymorphism.InterfacePolymorphism
{
    public interface IDatabase
    {
        string Name { get; }

        string CreaterName { get; }

        bool IsOpenSource { get; }
    }
}
