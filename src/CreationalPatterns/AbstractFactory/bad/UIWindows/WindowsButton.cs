namespace ConsoleApp1.src.CreationalPatterns.AbstractFactory.bad.UIWindows
{
    public class WindowsButton : IButton
    {
        public void Render()
        {
            System.Console.WriteLine("Windows: render button");
        }
    }
}