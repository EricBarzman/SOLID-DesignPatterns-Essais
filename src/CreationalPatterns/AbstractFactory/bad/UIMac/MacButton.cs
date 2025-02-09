namespace ConsoleApp1.src.CreationalPatterns.AbstractFactory.bad.UIMac
{
    public class MacButton : IButton
    {
        public void Render()
        {
            System.Console.WriteLine("Mac: render button");
        }
    }
}