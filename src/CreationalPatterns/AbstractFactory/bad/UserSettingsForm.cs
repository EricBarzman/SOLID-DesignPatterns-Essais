
using ConsoleApp1.src.CreationalPatterns.AbstractFactory.bad.UIMac;
using ConsoleApp1.src.CreationalPatterns.AbstractFactory.bad.UIWindows;

namespace ConsoleApp1.src.CreationalPatterns.AbstractFactory.bad
{
    public class UserSettingsForm
    {
        public void Render(OperatingSystemType os)
        {
            if (os == OperatingSystemType.Windows) {
                new WindowsButton().Render();
                new WindowsCheckbox().Render();
            }

            if (os == OperatingSystemType.Mac) {
                new MacButton().Render();
                new MacCheckbox().Render();
            }
        }
    }
}