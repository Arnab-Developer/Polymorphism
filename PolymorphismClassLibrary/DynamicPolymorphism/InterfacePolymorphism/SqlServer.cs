// -------------------------------------------------------------+
// This file containing an implimentation of IDatabase interface.
// -------------------------------------------------------------+

namespace PolymorphismClassLibrary.DynamicPolymorphism.InterfacePolymorphism
{
    /// <summary>
    /// Class SqlServer and it is an implimantation 
    /// of IDatabase interface.
    /// </summary>
    public class SqlServer : Database
    {
        /// <summary>
        /// Parameter less constructor.
        /// </summary>
        public SqlServer()
        {
            this.Name = "Sql Server";
            this.CreaterName = "Microsoft";
            this.IsOpenSource = false;
        }
    }
}
