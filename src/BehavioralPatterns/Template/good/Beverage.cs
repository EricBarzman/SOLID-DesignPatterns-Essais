
namespace ConsoleApp1.src.BehavioralPatterns.Template.good
{
    public abstract class Beverage
    {
        public void Prepare() {
            BoilWater();
            PourIntoCup();
            Brew();
            AddCondiments();
        }

        private void BoilWater()
        {
            System.Console.WriteLine("Boiling water"); 
        }

        private void PourIntoCup()
        {
            System.Console.WriteLine("Pouring water into cup"); 
        }

        protected abstract void Brew();

        // Virtual means it can be overriden, but yet it is already implemented
        protected virtual void AddCondiments() {}
    }    
}