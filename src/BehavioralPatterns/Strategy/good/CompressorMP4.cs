namespace ConsoleApp1.src.BehavioralPatterns.Strategy.good
{
    public class CompressorMP4 : ICompressor
    {
        public void Compress()
        {
            System.Console.WriteLine("Compressing using MP4");
        }
    }
}