namespace ConsoleApp1.src.BehavioralPatterns.ChainOfResponsibility.good
{
    public class Authenticator : Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
            System.Console.WriteLine("Authenticating");
            var username = request.GetUsername();
            var password = request.GetPassword();
            
            return !(username == "danny" & password == "123");
        }
    }
}