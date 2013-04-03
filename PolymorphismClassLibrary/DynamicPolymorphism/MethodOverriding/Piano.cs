// -----------------------------------------------------+
// This file containing an standalone class which inherit 
// the abstract class Instrument.
// -----------------------------------------------------+

namespace PolymorphismClassLibrary.DynamicPolymorphism.MethodOverriding
{
    /// <summary>
    /// Class Piano. It is a special type of Instrument class.
    /// </summary>
    public class Piano : Instrument
    {
        /// <summary>
        /// Create a piano like sound.
        /// </summary>
        /// <returns>Piano like sound.</returns>
        public override string Play()
        {
            return "Piano like sound";
        }
    }
}
