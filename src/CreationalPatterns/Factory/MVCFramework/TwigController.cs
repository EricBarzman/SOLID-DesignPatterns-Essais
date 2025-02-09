namespace ConsoleApp1.src.CreationalPatterns.Factory.MVCFramework
{
    public class TwigController : Controller
    {
        protected override ViewEngine CreateViewEngine()
        {
            return new TwigViewEngine();
        }
    }
}