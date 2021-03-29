using System;
using System.Runtime.Serialization;

namespace PolymorphismDemo.Lib.DynamicPolymorphism.PropertyOverriding
{
    [Serializable]
    public class BelowAgeLimitException : ApplicationException
    {
        public BelowAgeLimitException()
            : this("Student age must be greater or equal to 20")
        {
        }

        public BelowAgeLimitException(string message)
            : base(message)
        {
        }

        public BelowAgeLimitException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected BelowAgeLimitException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}

