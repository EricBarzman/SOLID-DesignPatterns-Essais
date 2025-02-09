using ConsoleApp1.src.StructuralPatterns.Adapter.Package;

namespace ConsoleApp1.src.StructuralPatterns.Adapter
{
    public class RainbowAdapter : Rainbow, Color
    {
        public void Apply(Video video)
        {
            Setup();
            Update(video);
        }
    }
}