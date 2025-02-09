namespace ConsoleApp1.src.BehavioralPatterns.ChainOfResponsibility.good
{
    public abstract class Handler
    {   
        private Handler _nextHandler;

        public Handler SetNext(Handler handler) {
            _nextHandler = handler;

            // Why returning an handler ? Because it facilitates the code afterwards
            // h1.SetNext(h2) will return h2. So we get:
            // h1.SetNext(h2).SetNext(h3).SetNext(h4) et.
            return handler;
        }

        // Fais-le, ou passe-le au suivant
        public void Handle(HttpRequest request) {
            if (DoHandle(request))
                return;

            if (_nextHandler != null)
                _nextHandler.Handle(request);
        }

        public abstract bool DoHandle(HttpRequest request);
    }
}