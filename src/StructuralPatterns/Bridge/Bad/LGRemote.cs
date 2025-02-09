namespace ConsoleApp1.src.StructuralPatterns.Bridge.Bad
{
    public class LGRemote : RemoteControl
    {
        public override void TurnOff()
        {
            System.Console.WriteLine("Turning LG radio off");
        }

        public override void TurnOn()
        {
            System.Console.WriteLine("Turning LG radio on");
        }

        public override void VolumeDown()
        {
            System.Console.WriteLine("Turning LG radio volume down");
        }

        public override void VolumeUp()
        {
            System.Console.WriteLine("Turning LG radio volume up");
        }
    }
}