namespace ConsoleApp1.src.CreationalPatterns.AbstractFactory.good.UIMac
{
    public class MacCheckbox : ICheckbox
    {
        public void Render()
        {
            System.Console.WriteLine("Mac: render checkbox");
        }
    }
}