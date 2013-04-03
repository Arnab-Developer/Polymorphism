// -------------------------------------------------------------+
// This file containing an implimentation of IDatabase interface.
// -------------------------------------------------------------+

namespace PolymorphismClassLibrary.DynamicPolymorphism.InterfacePolymorphism
{
    /// <summary>
    /// Class my sql and it is an implimantation 
    /// of IDatabase interface.
    /// </summary>
    public class MySql : Database
    {
        /// <summary>
        /// Parameter less constructor.
        /// </summary>
        public MySql()
        {
            this.Name = "My Sql";
            this.CreaterName = "My Sql";
            this.IsOpenSource = true;
        }
    }
}
