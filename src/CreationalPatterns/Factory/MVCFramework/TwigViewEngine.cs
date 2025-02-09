namespace ConsoleApp1.src.CreationalPatterns.Factory.MVCFramework
{
    public class TwigViewEngine : ViewEngine
    {
        public string Render(string fileName, Dictionary<string, object> data) {
            return "View rendered from " + fileName + " by Twig";
        }
    }
}