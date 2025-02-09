using ConsoleApp1.src.CreationalPatterns.AbstractFactory.good.UIMac;

namespace ConsoleApp1.src.CreationalPatterns.AbstractFactory.good
{
    public class MacUIComponentFactory : IUIComponentFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }
}