namespace ConsoleApp1.src.CreationalPatterns.Singleton
{
    public class Test
    {
        public static void Run()
        {
            var settings = AppSettings.getInstance();
            System.Console.WriteLine(settings.Get("app_name"));
        }
    }
}