namespace ConsoleApp1.src.BehavioralPatterns.Strategy.good
{
    public class CompressorWEBM : ICompressor
    {
        public void Compress()
        {
            System.Console.WriteLine("Compressing using WEBM");
        }
    }
}