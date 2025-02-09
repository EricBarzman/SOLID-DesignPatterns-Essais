namespace ConsoleApp1.src.BehavioralPatterns.Strategy.good
{
    public class CompressorMOV : ICompressor
    {
        public void Compress()
        {
            System.Console.WriteLine("Compressing using MOV");
        }
    }
}