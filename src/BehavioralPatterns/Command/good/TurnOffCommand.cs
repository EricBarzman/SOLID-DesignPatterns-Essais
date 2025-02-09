namespace ConsoleApp1.src.BehavioralPatterns.Command.good
{
    public class TurnOffCommand : ICommand
    {
        private Light _light;

        public TurnOffCommand(Light light) {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
    }
}