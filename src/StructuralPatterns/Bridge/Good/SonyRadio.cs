namespace ConsoleApp1.src.StructuralPatterns.Bridge.Good
{
    public class SonyRadio : IDevice
    {
        public void SetChannel(int channel)
        {
            System.Console.WriteLine("Setting Sony channel: " + channel);
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Turning Sony radio off");
        }

        public void TurnOn()
        {
            System.Console.WriteLine("Turning Sony radio on");
        }
    }
}