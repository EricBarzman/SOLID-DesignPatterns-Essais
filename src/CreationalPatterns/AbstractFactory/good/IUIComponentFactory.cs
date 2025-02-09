
namespace ConsoleApp1.src.CreationalPatterns.AbstractFactory.good
{
    public interface IUIComponentFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}