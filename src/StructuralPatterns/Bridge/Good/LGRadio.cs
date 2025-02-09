namespace ConsoleApp1.src.StructuralPatterns.Bridge.Good
{
    public class LGRadio : IDevice
    {
        public void SetChannel(int channel)
        {
            System.Console.WriteLine("Setting LG channel: " + channel);
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Turning LG radio off");
        }

        public void TurnOn()
        {
            System.Console.WriteLine("Turning LG radio on");
        }
    }
}