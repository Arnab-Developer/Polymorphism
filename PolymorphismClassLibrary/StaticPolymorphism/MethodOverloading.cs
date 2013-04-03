// ---------------------------------------------------+
// This file containing the demo of compilation time 
// polymorphism through method overloading.
// ---------------------------------------------------+

namespace PolymorphismClassLibrary.StaticPolymorphism
{
    /// <summary>
    /// Class describing method overloading.
    /// </summary>
    public class MethodOverloading
    {
        /// <summary>
        /// int addition.
        /// </summary>
        /// <param name="x">First input.</param>
        /// <param name="y">Second input.</param>
        /// <returns>Addition result.</returns>
        public int Addition(int x, int y)
        {
            return (x + y);
        }

        /// <summary>
        /// int addition.
        /// </summary>
        /// <param name="x">First input.</param>
        /// <param name="y">Second input.</param>
        /// <param name="z">Third input.</param>
        /// <returns>Addition result.</returns>
        public int Addition(int x, int y, int z)
        {
            return (x + y + z);
        }

        /// <summary>
        /// int addition.
        /// </summary>
        /// <param name="values">Param type parameter.</param>
        /// <returns>Addition result.</returns>
        public int Addition(params int[] values)
        {
            int sum = 0;
            foreach (int v in values)
            {
                sum += v;
            }

            return sum;
        }

        /// <summary>
        /// double addition.
        /// </summary>
        /// <param name="x">First input.</param>
        /// <param name="y">Second input.</param>
        /// <returns>Addition result.</returns>
        public double Addition(double x, double y)
        {
            return (x + y);
        }

        /// <summary>
        /// double addition.
        /// </summary>
        /// <param name="x">First input.</param>
        /// <param name="y">Second input.</param>
        /// <param name="z">Third input.</param>
        /// <returns>Addition result.</returns>
        public double Addition(double x, double y, double z)
        {
            return (x + y + z);
        }

        /// <summary>
        /// double addition.
        /// </summary>
        /// <param name="values">Param type parameter.</param>
        /// <returns>Addition result.</returns>
        public double Addition(params double[] values)
        {
            int sum = 0;
            foreach (int v in values)
            {
                sum += v;
            }

            return sum;
        }
    }
}
