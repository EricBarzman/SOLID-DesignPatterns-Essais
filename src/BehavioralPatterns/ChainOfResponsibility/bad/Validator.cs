namespace ConsoleApp1.src.BehavioralPatterns.ChainOfResponsibility
{
    public class Validator
    {
        public void Validate(HttpRequest request) {
            var username = request.GetUsername();
            var password = request.GetPassword();

            // Trim white space
            request.ValidateUsername = username.Trim();
            request.ValidatePassword = password.Trim();

            
        }
    }
}