namespace ConsoleApp1.src.BehavioralPatterns.Mediator.WithObserver
{
    public class UIControl
    {
        private List<EventHandler> _eventHandlers = new List<EventHandler>();

        public void AddEventHandler(EventHandler eventhandler) {
            _eventHandlers.Add(eventhandler);
        }

        public void NotifyEventHandlers()
        {
            foreach (var handler in _eventHandlers)
                handler();
        }
    }
}