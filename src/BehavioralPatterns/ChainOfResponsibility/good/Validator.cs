namespace ConsoleApp1.src.BehavioralPatterns.ChainOfResponsibility.good
{
    public class Validator : Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
            System.Console.WriteLine("Validating");
            var username = request.GetUsername();
            var password = request.GetPassword();

            // Trim white space
            request.ValidateUsername = username.Trim();
            request.ValidatePassword = password.Trim();

            // Si c'est vide, on renvoie true, ce qui STOPPE le processus. False le continuerait
            return request.ValidateUsername == "" || request.ValidatePassword == "";
        }
    }
}