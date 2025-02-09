namespace ConsoleApp1.src.StructuralPatterns.Bridge.Good
{
    public class RemoteControl
    {
        private IDevice _device;

        public RemoteControl(IDevice device) {
            _device = device;
        }

        public void TurnOn() {
            _device.TurnOn();
        }

        public void TurnOff() {
            _device.TurnOff();
        }
    }
}