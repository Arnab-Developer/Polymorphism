namespace PolymorphismDemo.Lib.DynamicPolymorphism.InterfacePolymorphism
{
    public abstract class Database : IDatabase
    {
        private string _name;
        public virtual string Name
        {
            get { return _name; }
            protected set { _name = value; }
        }

        private string _createrName;
        public virtual string CreaterName
        {
            get { return _createrName; }
            protected set { _createrName = value; }
        }

        private bool _isOpenSource;
        public bool IsOpenSource
        {
            get { return _isOpenSource; }
            protected set { _isOpenSource = value; }
        }

        public Database()
        {
            _name = string.Empty;
            _createrName = string.Empty;
            _isOpenSource = false;
        }

        public override string ToString()
        {
            return string.Format("Database name: {0}\nCreated by: {1}\nOpen source: {2}",
                Name, CreaterName, IsOpenSource);
        }
    }
}
