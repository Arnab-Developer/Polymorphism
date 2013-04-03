// ------------------------------------------------+
// This file containing use data base functionality.
// ------------------------------------------------+

namespace PolymorphismClassLibrary.DynamicPolymorphism.InterfacePolymorphism
{
    /// <summary>
    /// Class UseDatabase.
    /// </summary>
    public class UseDatabase
    {
        /// <summary>
        /// Use data base information.
        /// </summary>
        /// <param name="database">Interface type data base.</param>
        /// <returns>String representation of data base information.</returns>
        public string Use(IDatabase database)
        {
            return database.ToString();
        }
    }
}
