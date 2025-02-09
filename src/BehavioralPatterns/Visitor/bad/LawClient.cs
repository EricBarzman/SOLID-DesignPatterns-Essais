namespace ConsoleApp1.src.BehavioralPatterns.Visitor.bad
{
    public class LawClient : Client
    {
        public LawClient(string name, string email) : base(name, email)
        {
        }

        public override void SendEmail()
        {
            System.Console.WriteLine("Sending law marketing tips");
        }
    }
}