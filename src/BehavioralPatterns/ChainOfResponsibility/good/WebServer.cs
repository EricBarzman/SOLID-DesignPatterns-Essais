namespace ConsoleApp1.src.BehavioralPatterns.ChainOfResponsibility.good
{
    public class WebServer
    {
        private Handler _handler;

        public WebServer(Handler handler)
        {
            _handler = handler;
        }

        public void Handle(HttpRequest request) {
            _handler.Handle(request);
        }
    }
}