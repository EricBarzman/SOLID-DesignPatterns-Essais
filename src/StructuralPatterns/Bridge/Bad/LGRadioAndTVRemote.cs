namespace ConsoleApp1.src.StructuralPatterns.Bridge.Bad
{
    public class LGRadioAndTVRemote : RadioAndTVRemote
    {
        public override void ControlRadio()
        {
            System.Console.WriteLine("Control LG radio");
        }

        public override void ControlTV()
        {
            System.Console.WriteLine("Control LG TV");
        }

        public override void SetChannel(int channel)
        {
            System.Console.WriteLine("Set channel: " + channel);
        }

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