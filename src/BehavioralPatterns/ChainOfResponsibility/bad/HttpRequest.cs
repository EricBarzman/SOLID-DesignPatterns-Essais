namespace ConsoleApp1.src.BehavioralPatterns.ChainOfResponsibility
{
    public class HttpRequest
    {
        private string _username;
        private string _password;
        public string ValidateUsername { get; set; }
        public string ValidatePassword { get; set; }

        public HttpRequest(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public string GetUsername() {
            return _username;
        }

        public string GetPassword() {
            return _password;
        }
    }
}