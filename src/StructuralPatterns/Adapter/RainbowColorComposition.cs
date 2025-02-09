using ConsoleApp1.src.StructuralPatterns.Adapter.Package;

namespace ConsoleApp1.src.StructuralPatterns.Adapter
{
    public class RainbowColorComposition : Color
    {
        private Rainbow _rainbow;

        public RainbowColorComposition(Rainbow rainbow) {
            _rainbow = rainbow;
        }

        public void Apply(Video video) {
            _rainbow.Setup();
            _rainbow.Update(video);
        }
    }
}