// ------------------------------------------------------+
// This file containing class to send message to the user.
// ------------------------------------------------------+

namespace PolymorphismClassLibrary.DynamicPolymorphism.DelegatePolymorphism
{
    /// <summary>
    /// Class to send message to the user.
    /// </summary>
    public class SendMessageToUser
    {
        /// <summary>
        /// Send message to user.
        /// </summary>
        /// <param name="getMessageForUserDelegate">Take input of type GetMessageForUserDelegate</param>
        /// <param name="userName">User name.</param>
        /// <returns>Result user name with message.</returns>
        public string Send(GetMessageForUserDelegate getMessageForUserDelegate, string userName)
        {
            string userNameWithMessage = string.Empty;
            if (getMessageForUserDelegate != null)
            {
                userNameWithMessage = getMessageForUserDelegate.Invoke(userName);
            }

            return userNameWithMessage;
        }
    }
}
