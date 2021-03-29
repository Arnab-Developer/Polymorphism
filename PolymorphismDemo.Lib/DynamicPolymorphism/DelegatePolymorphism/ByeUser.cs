namespace PolymorphismDemo.Lib.DynamicPolymorphism.DelegatePolymorphism
{
    public class ByeUser
    {
        public string SayHello(string userName)
        {
            return string.Format("Bye {0}", userName);
        }
    }
}
