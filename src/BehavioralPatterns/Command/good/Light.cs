namespace ConsoleApp1.src.BehavioralPatterns.Command.good
{
    // Receiver
    public class Light
    {
        public void TurnOn() {
            System.Console.WriteLine("Light is turned on");
        }
        
        public void TurnOff() {
            System.Console.WriteLine("Light is turned off");
        }

        public void Dim() {
            System.Console.WriteLine("Light has been dimmed");
        }
    }
}