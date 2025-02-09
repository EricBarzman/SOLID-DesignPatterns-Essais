namespace ConsoleApp1.src.BehavioralPatterns.Template.ThruStrategy
{
    public class Coffee : IBeverage
    {
        public void Prepare() {
            Brew();
            AddCondiments();
        }
        private void Brew() {
            System.Console.WriteLine("Brewing coffee for 5 minutes");   
        }

        private void AddCondiments() {
            if (CustomerWantsCondiments()) {
                System.Console.WriteLine("Adding cream");
            }   
        }

        private bool CustomerWantsCondiments() {
            System.Console.WriteLine("Would you like cream with your coffee? (y/n)");
            string input = Console.ReadLine();
            return input.ToLower() == "y" ? true : false;
        }
    }
}