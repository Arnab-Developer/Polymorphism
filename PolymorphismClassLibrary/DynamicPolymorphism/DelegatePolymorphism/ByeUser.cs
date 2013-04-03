// -------------------------------------------------+
// This file containing the class to implement bye 
// message to the user.
// -------------------------------------------------+

namespace PolymorphismClassLibrary.DynamicPolymorphism.DelegatePolymorphism
{
    /// <summary>
    /// Class to say user bye.
    /// </summary>
    public class ByeUser
    {
        /// <summary>
        /// Say bye to the user.
        /// </summary>
        /// <param name="userName">User name.</param>
        /// <returns>Bye user name.</returns>
        public string SayHello(string userName)
        {
            return string.Format("Bye {0}", userName);
        }
    }
}
