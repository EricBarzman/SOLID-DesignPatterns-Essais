namespace ConsoleApp1.src.StructuralPatterns.Decorator.bad
{
    public class CompressedData : CloudData
    {
        public CompressedData(string url) : base(url)
        {
        }

        public override void Save(string data)
        {
            var compressed = Compress(data);
            base.Save(compressed);
        }

        public string Compress(string data) {
            return data.Substring(0, 3);
        }
    }
}