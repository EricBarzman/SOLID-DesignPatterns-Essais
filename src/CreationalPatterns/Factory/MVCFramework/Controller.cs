namespace ConsoleApp1.src.CreationalPatterns.Factory.MVCFramework
{
    public class Controller
    {

        public void Render(string fileName, Dictionary<string, object> data) {
            var viewEngine = CreateViewEngine();
            var html = viewEngine.Render(fileName, data);
            System.Console.WriteLine(html);
        }

        protected virtual ViewEngine CreateViewEngine() {
            return new BladeViewEngine();
        }
    }
}