// ----------------------------------------------+
// This class containing an interface for student.
// ----------------------------------------------+

namespace PolymorphismClassLibrary.DynamicPolymorphism.PropertyOverriding
{
    /// <summary>
    /// Interface for student functionality.
    /// </summary>
    public interface IStudent
    {
        /// <summary>
        /// Name of the student.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Age of the student.
        /// </summary>
        int Age { get; set; }
    }
}
