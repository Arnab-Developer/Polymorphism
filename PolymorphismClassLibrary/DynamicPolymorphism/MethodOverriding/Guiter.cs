// -----------------------------------------------------+
// This file containing an standalone class which inherit 
// the abstract class Instrument.
// -----------------------------------------------------+

namespace PolymorphismClassLibrary.DynamicPolymorphism.MethodOverriding
{
    /// <summary>
    /// Class Guiter. It is a special type of Instrument class.
    /// </summary>
    public class Guiter : Instrument
    {
        /// <summary>
        /// Create a guiter like sound.
        /// </summary>
        /// <returns>Guiter like sound.</returns>
        public override string Play()
        {
            return "Guiter like sound";
        }
    }
}
