namespace ConsoleApp1.src.BehavioralPatterns.Mediator.WithObserver
{
    public class Button : UIControl
    {
        private bool _isEnabled;

        public bool IsEnabled() {
            return _isEnabled;
        }

        public void SetIsEnabled(bool isEnabled) {
            _isEnabled = isEnabled;
            NotifyEventHandlers();
        }
    }
}