namespace ConsoleApp1.src.BehavioralPatterns.Template.bad
{
    public class Coffee
    {
        public void MakeBeverage() {
            BoilWater();
            PourWaterInCup();
            Brew();
            AddCondiments();
        }
        private void BoilWater() {
            System.Console.WriteLine("Boiling water");
        }
        private void PourWaterInCup() {
            System.Console.WriteLine("Pouring water in cup");   
        }

        private void Brew() {
            System.Console.WriteLine("Brewing coffee 5 minutes");   
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