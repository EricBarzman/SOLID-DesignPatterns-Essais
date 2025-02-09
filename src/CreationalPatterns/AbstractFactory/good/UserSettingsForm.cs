
namespace ConsoleApp1.src.CreationalPatterns.AbstractFactory.good
{
    public class UserSettingsForm
    {
        public void Render(IUIComponentFactory uIComponentFactory)
        {
            uIComponentFactory.CreateButton().Render();
            uIComponentFactory.CreateCheckbox().Render();
        }
    }
}