// -------------------------------------------------------+
// This file containing a Student class which is for a demo
// of DynamicPolymorphism by property overriding.
// -------------------------------------------------------+

namespace PolymorphismClassLibrary.DynamicPolymorphism.PropertyOverriding
{
    /// <summary>
    /// Student class.
    /// </summary>
    public class Student : IStudent
    {
        /// <summary>
        /// Name of the student.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Age of the student.
        /// </summary>
        public virtual int Age { get; set; }

        /// <summary>
        /// Overriding ToString() method of object class.
        /// </summary>
        /// <returns>String representation of student object.</returns>
        public override string ToString()
        {
            return string.Format("Student name: {0}\nStudent age: {1}", this.Name, this.Age);
        }
    }
}
