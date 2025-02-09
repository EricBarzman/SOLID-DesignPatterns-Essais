namespace ConsoleApp1.src.StructuralPatterns.Bridge.Good
{
    public class AdvancedRemote : RemoteControl
    {
        public AdvancedRemote(IDevice device) : base(device) {}

        public void SetChannel(int channel) {
            System.Console.WriteLine("Setting channel: " + channel);
        }
    }
}