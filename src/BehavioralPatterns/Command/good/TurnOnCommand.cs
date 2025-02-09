namespace ConsoleApp1.src.BehavioralPatterns.Command.good
{
    public class TurnOnCommand : ICommand
    {
        private Light _light;

        public TurnOnCommand(Light light) {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }
}