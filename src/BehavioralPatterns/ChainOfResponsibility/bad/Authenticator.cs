namespace ConsoleApp1.src.BehavioralPatterns.ChainOfResponsibility
{
    public class Authenticator
    {
        public bool Authenticate(HttpRequest request) {
            var username = request.GetUsername();
            var password = request.GetPassword();
            
            return username == "Danny" & password == "123";
        }
    }
}