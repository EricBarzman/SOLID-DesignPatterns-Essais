namespace ConsoleApp1.src.BehavioralPatterns.Command.bad
{
    // Invoker
    public class RemoteControl
    {
        private Light _light;
        
        public RemoteControl(Light light) {
            _light = light;
        }

        public void PressButton(bool turnOn) {
            if (turnOn)
                _light.TurnOn();
                
            else _light.TurnOff();
        }
    }
}