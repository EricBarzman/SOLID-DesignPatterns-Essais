namespace ConsoleApp1.src.BehavioralPatterns.Visitor.good
{
    public class RetailClient : Client
    {
        public RetailClient(string name, string email) : base(name, email) {}

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitRetail(this);
        }
    }
}