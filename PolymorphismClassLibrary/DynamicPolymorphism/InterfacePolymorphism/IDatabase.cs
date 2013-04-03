// -----------------------------------------------------------------+
// This file containing an interface for the data base functionality.
// -----------------------------------------------------------------+

namespace PolymorphismClassLibrary.DynamicPolymorphism.InterfacePolymorphism
{
    /// <summary>
    /// Interface for basic data base funtionality contract.
    /// </summary>
    public interface IDatabase
    {
        /// <summary>
        /// Name of the data base.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Name of the company who creates the data base.
        /// </summary>
        string CreaterName { get; }

        /// <summary>
        /// The data base is open source or not.
        /// </summary>
        bool IsOpenSource { get; }
    }
}
