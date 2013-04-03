// ---------------------------------------------------------+
// This file containing demo of compilation time polymorphism 
// through operator overloading.
// ---------------------------------------------------------+

namespace PolymorphismClassLibrary.StaticPolymorphism
{
    /// <summary>
    /// Class describing operator overloading.
    /// </summary>
    public class OperatorOverloading
    {
        /// <summary>
        /// X property.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Y property.
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Parameter less constructor.
        /// </summary>
        public OperatorOverloading()
        {
        }

        /// <summary>
        /// Parameterised constructor.
        /// </summary>
        /// <param name="x">First parameter.</param>
        /// <param name="y">Second parameter.</param>
        public OperatorOverloading(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Overloading + operator.
        /// </summary>
        /// <param name="obj1">First object.</param>
        /// <param name="obj2">Second object.</param>
        /// <returns>Resulting object.</returns>
        public static OperatorOverloading operator +(OperatorOverloading obj1, OperatorOverloading obj2)
        {
            OperatorOverloading theOperatorOverloading = new OperatorOverloading()
            {
                X = obj1.X + obj2.X,
                Y = obj1.Y + obj2.Y
            };
            return theOperatorOverloading;
        }

        /// <summary>
        /// Overloading - operator.
        /// </summary>
        /// <param name="obj1">First object.</param>
        /// <param name="obj2">Second object.</param>
        /// <returns>Resulting object.</returns>
        public static OperatorOverloading operator -(OperatorOverloading obj1, OperatorOverloading obj2)
        {
            OperatorOverloading theOperatorOverloading = new OperatorOverloading()
            {
                X = obj1.X - obj2.X,
                Y = obj1.Y - obj2.Y
            };
            return theOperatorOverloading;
        }

        /// <summary>
        /// Overloading * operator.
        /// </summary>
        /// <param name="obj1">First object.</param>
        /// <param name="obj2">Second object.</param>
        /// <returns>Resulting object.</returns>
        public static OperatorOverloading operator *(OperatorOverloading obj1, OperatorOverloading obj2)
        {
            OperatorOverloading theOperatorOverloading = new OperatorOverloading()
            {
                X = obj1.X * obj2.X,
                Y = obj1.Y * obj2.Y
            };
            return theOperatorOverloading;
        }

        /// <summary>
        /// Overloading / operator.
        /// </summary>
        /// <param name="obj1">First object.</param>
        /// <param name="obj2">Second object.</param>
        /// <returns>Resulting object.</returns>
        public static OperatorOverloading operator /(OperatorOverloading obj1, OperatorOverloading obj2)
        {
            OperatorOverloading theOperatorOverloading = new OperatorOverloading()
            {
                X = obj1.X / obj2.X,
                Y = obj1.Y / obj2.Y
            };
            return theOperatorOverloading;
        }
    }
}
