namespace ConsoleApp1.src.CreationalPatterns.Factory.MVCFramework
{
    public interface ViewEngine
    {
        string Render(string fileName, Dictionary<string, object> data);
    }
}