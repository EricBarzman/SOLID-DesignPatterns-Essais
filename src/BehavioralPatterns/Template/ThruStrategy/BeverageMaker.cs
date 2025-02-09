namespace ConsoleApp1.src.BehavioralPatterns.Template.ThruStrategy
{
    public class BeverageMaker
    {
        private IBeverage _beverage;
        
        public BeverageMaker(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public void SetBeverage(IBeverage beverage) {
            _beverage = beverage;
        }

        public void MakeBeverage() {
            // Common operations
            BoilWater();
            PourWaterInCup();
            
            // Unique operations to each beverage
            _beverage.Prepare();
        }

        private void BoilWater() {
            System.Console.WriteLine("Boiling water");
        }
        private void PourWaterInCup() {
            System.Console.WriteLine("Pouring water in cup");   
        }
    }
}