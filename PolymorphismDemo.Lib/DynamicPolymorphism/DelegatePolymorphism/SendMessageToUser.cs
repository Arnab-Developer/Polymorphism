namespace PolymorphismDemo.Lib.DynamicPolymorphism.DelegatePolymorphism
{
    public class SendMessageToUser
    {
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
