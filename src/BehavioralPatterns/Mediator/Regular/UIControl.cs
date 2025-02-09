namespace ConsoleApp1.src.BehavioralPatterns.Mediator.Regular
{
    public class UIControl
    {
        protected DialogBox _owner;

        public UIControl(DialogBox owner)
        {
            _owner = owner;
        }
    }
}