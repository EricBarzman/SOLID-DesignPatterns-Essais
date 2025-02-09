namespace ConsoleApp1.src.BehavioralPatterns.Mediator.Regular
{
    public class Button : UIControl
    {
        private bool _isEnabled;
        public Button(DialogBox owner) : base(owner)
        {
        }

        public bool IsEnabled() {
            return _isEnabled;
        }

        public void SetIsEnabled(bool isEnabled) {
            _isEnabled = isEnabled;
            _owner.Changed(this);
        }
    }
}