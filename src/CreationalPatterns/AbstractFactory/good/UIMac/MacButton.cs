namespace ConsoleApp1.src.CreationalPatterns.AbstractFactory.good.UIMac
{
    public class MacButton : IButton
    {
        public void Render()
        {
            System.Console.WriteLine("Mac: render button");
        }
    }
}