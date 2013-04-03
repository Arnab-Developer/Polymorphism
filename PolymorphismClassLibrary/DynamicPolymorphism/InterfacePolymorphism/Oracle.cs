// -------------------------------------------------------------+
// This file containing an implimentation of IDatabase interface.
// -------------------------------------------------------------+

namespace PolymorphismClassLibrary.DynamicPolymorphism.InterfacePolymorphism
{
    /// <summary>
    /// Class SqlServer and it is an implimantation 
    /// of IDatabase interface.
    /// </summary>
    public class Oracle : Database
    {
        /// <summary>
        /// Parameter less constructor.
        /// </summary>
        public Oracle()
        {
            this.Name = "Oracle";
            this.CreaterName = "Oracle";
            this.IsOpenSource = false;
        }
    }
}
