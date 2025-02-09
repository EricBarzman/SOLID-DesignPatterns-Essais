using ConsoleApp1.src.CreationalPatterns.AbstractFactory.good.UIWindows;

namespace ConsoleApp1.src.CreationalPatterns.AbstractFactory.good
{
    public class WindowsUIComponentFactory : IUIComponentFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
    }
}