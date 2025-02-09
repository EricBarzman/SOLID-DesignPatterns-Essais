
namespace ConsoleApp1.src.BehavioralPatterns.Strategy
{
    public class VideoStorage
    {
        private Compressors _compressor;
        private Overlays _overlay;

        public VideoStorage(Compressors compressor, Overlays overlay = Overlays.None)
        {
            _compressor = compressor;
            _overlay = overlay;
        }

        public void SetCompressor(Compressors compressor)
        {
            _compressor = compressor;
        }

        public void SetOverlay(Overlays overlay)
        {
            _overlay = overlay;
        }

        public void Store(string fileName)
        {
            // Compression logic

            if (_compressor == Compressors.MOV)
            {
                System.Console.WriteLine("Compressing using MOV");
            }

            else if (_compressor == Compressors.MP4)
            {
                System.Console.WriteLine("Compressing using MP4");
            }

            else if (_compressor == Compressors.WEBM)
            {
                System.Console.WriteLine("Compressing using WEBM");
            }

            // Overlay logic
            if (_overlay == Overlays.None)
            {
                System.Console.WriteLine("none");
            }

            else if (_overlay == Overlays.BlackAndWhite)
            {
                System.Console.WriteLine("black & white");
            }

            else if (_overlay == Overlays.Blur)
            {
                System.Console.WriteLine("blur");
            }

            System.Console.WriteLine("Storing video to " + fileName + "." + _compressor);
        }
    }
}