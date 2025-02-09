namespace ConsoleApp1.src.StructuralPatterns.Bridge.Good
{
    public interface IDevice
    {
        public void TurnOn();
        public void TurnOff();
        public void SetChannel(int channel);   
    }
}