namespace ConsoleApp1.src.CreationalPatterns.AbstractFactory.good.UIWindows
{
    public class WindowsCheckbox : ICheckbox
    {
        public void Render()
        {
            System.Console.WriteLine("Windows: render checkbox");
        }
    }
}