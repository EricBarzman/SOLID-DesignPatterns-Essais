namespace ConsoleApp1.src.BehavioralPatterns.Template.good
{
    public class Tea : Beverage
    {
        protected override void Brew()
        {
            System.Console.WriteLine("Brewing tea for 3 minutes");
        }

        protected override void AddCondiments() {
            if (CustomerWantsCondiments())
            {
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