// -------------------------------------------------+
// This file containing the class to implement hello 
// message to the user.
// -------------------------------------------------+

namespace PolymorphismClassLibrary.DynamicPolymorphism.DelegatePolymorphism
{
    /// <summary>
    /// Class to say user hello.
    /// </summary>
    public class HelloUser
    {
        /// <summary>
        /// Say hello to the user.
        /// </summary>
        /// <param name="userName">User name.</param>
        /// <returns>Hello user name.</returns>
        public string SayHello(string userName)
        {
            return string.Format("Hello {0}", userName);
        }
    }
}
