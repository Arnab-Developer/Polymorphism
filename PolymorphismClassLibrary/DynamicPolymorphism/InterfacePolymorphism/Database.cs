// -------------------------------------------------------------+
// This file containing an implimentation of IDatabase interface.
// -------------------------------------------------------------+

namespace PolymorphismClassLibrary.DynamicPolymorphism.InterfacePolymorphism
{
    /// <summary>
    /// Class data base and it is an implimantation 
    /// of IDatabase interface.
    /// </summary>
    public abstract class Database : IDatabase
    {
        private string _name;
        /// <summary>
        /// Name of the data base.
        /// </summary>
        public virtual string Name
        {
            get { return this._name; }
            protected set { this._name = value; }
        }

        private string _createrName;
        /// <summary>
        /// Name of the company who creates the data base.
        /// </summary>
        public virtual string CreaterName
        {
            get { return this._createrName; }
            protected set { this._createrName = value; }
        }

        private bool _isOpenSource;
        /// <summary>
        /// The data base is open source or not.
        /// </summary>
        public bool IsOpenSource
        {
            get { return this._isOpenSource; }
            protected set { this._isOpenSource = value; }
        }

        /// <summary>
        /// Specific implimentation of the ToString() method of 
        /// the object class.
        /// </summary>
        /// <returns>Readable format of all the information.</returns>
        public override string ToString()
        {
            return string.Format("Database name: {0}\nCreated by: {1}\nOpen source: {2}",
                this.Name, this.CreaterName, this.IsOpenSource);
        }
    }
}
