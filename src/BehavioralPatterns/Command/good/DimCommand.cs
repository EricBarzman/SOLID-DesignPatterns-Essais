namespace ConsoleApp1.src.BehavioralPatterns.Command.good
{
    public class DimCommand : ICommand
    {
        private Light _light;

        public DimCommand(Light light) {
            _light = light;
        }

        public void Execute()
        {
            _light.Dim();
        }
    }
}