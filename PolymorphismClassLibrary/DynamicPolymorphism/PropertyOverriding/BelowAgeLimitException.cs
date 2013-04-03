// ---------------------------------------------------------+
// This file containing custom exception class for under age. 
// ---------------------------------------------------------+

using System;
using System.Runtime.Serialization;

namespace PolymorphismClassLibrary.DynamicPolymorphism.PropertyOverriding
{
    /// <summary>
    /// Custom exception class for under age.
    /// </summary>
    [Serializable]
    public class BelowAgeLimitException : ApplicationException
    {
        /// <summary>
        /// Parameter less constructor.
        /// </summary>
        public BelowAgeLimitException()
            :this("Student age must be greater or equal to 20")
        {
        }

        /// <summary>
        /// Parameterised constructor.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public BelowAgeLimitException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Parameterised constructor.
        /// </summary>
        /// <param name="message">Exception message.</param>
        /// <param name="inner">Inner exception.</param>
        public BelowAgeLimitException(string message, Exception inner)
            : base(message, inner)
        {
        }

        /// <summary>
        /// Parameterised constructor.
        /// </summary>
        /// <param name="info">Serialization information.</param>
        /// <param name="context">Streaming context.</param>
        protected BelowAgeLimitException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}

