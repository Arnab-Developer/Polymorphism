// ----------------------------------------------------+
// This file containing a class to get entry to college.
// ----------------------------------------------------+

namespace PolymorphismClassLibrary.DynamicPolymorphism.PropertyOverriding
{
    /// <summary>
    /// Class to get entry to college.
    /// </summary>
    public class EnterToCollege
    {
        /// <summary>
        /// Get entry to college.
        /// </summary>
        /// <param name="student">Student object.</param>
        /// <returns>String representation of student object.</returns>
        public string Enter(IStudent student)
        {
            student.Name = "Rahul";
            student.Age = 100;

            return student.ToString();
        }
    }
}
