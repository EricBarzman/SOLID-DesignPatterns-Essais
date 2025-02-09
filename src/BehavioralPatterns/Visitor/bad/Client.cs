namespace ConsoleApp1.src.BehavioralPatterns.Visitor.bad
{
    public abstract class Client
    {
        protected string _name;
        protected string _email;
        public Client(string name, string email)
        {
            _name = name;
            _email = email;
        }

        public abstract void SendEmail();
    }
}