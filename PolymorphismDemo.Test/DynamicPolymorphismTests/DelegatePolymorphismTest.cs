using PolymorphismDemo.Lib.DynamicPolymorphism.DelegatePolymorphism;
using Xunit;

namespace PolymorphismDemo.Test.DynamicPolymorphismTests
{
    public class DelegatePolymorphismTest
    {
        [Fact]
        public void Can_SayHello_ReturnProperMessage()
        {
            GetMessageForUserDelegate getMessageForUserDelegate;

            HelloUser helloUser = new();
            getMessageForUserDelegate = helloUser.SayHello;

            SendMessageToUser sendMessageToUser = new();
            string message = sendMessageToUser.Send(getMessageForUserDelegate, "Rahul");

            Assert.Equal("Hello Rahul", message);
        }

        [Fact]
        public void Can_SayBye_ReturnProperMessage()
        {
            GetMessageForUserDelegate getMessageForUserDelegate;

            ByeUser helloUser = new();
            getMessageForUserDelegate = helloUser.SayHello;

            SendMessageToUser sendMessageToUser = new();
            string message = sendMessageToUser.Send(getMessageForUserDelegate, "Rahul");

            Assert.Equal("Bye Rahul", message);
        }
    }
}
