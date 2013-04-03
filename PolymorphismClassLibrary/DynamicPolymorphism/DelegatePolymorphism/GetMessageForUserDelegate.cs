// ----------------------------------------------+
// This file containing the delegate to impliment 
// polymorphic nature.
// ----------------------------------------------+

namespace PolymorphismClassLibrary.DynamicPolymorphism.DelegatePolymorphism
{
    /// <summary>
    /// Delegate to get message for the user.
    /// </summary>
    /// <param name="userName">User name.</param>
    /// <returns>Result user name with message.</returns>
    public delegate string GetMessageForUserDelegate(string userName);
}