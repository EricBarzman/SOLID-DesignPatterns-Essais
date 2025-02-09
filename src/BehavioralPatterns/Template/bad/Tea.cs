namespace ConsoleApp1.src.BehavioralPatterns.Template.bad
{
    public class Tea
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
            System.Console.WriteLine("Brewing tea for 3 minutes");   
        }

        private void AddCondiments() {
            if (CustomerWantsCondiments()) {
                System.Console.WriteLine("Adding lemon to the tea");
            }   
        }

        private bool CustomerWantsCondiments() {
            System.Console.WriteLine("Would you like lemon with your tea? (y/n)");
            string input = Console.ReadLine();
            return input.ToLower() == "y" ? true : false;
        }
    }
}