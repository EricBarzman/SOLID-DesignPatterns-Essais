namespace ConsoleApp1.src.StructuralPatterns.Decorator.bad
{
    public class EncryptedData : CloudData
    {
        public EncryptedData(string url) : base(url)
        {
        }

        public override void Save(string data)
        {
            var encrypted = Encrypt(data);
            base.Save(encrypted);
        }

        public string Encrypt(string data) {
            return "sdf$£$lqjlkj$^";
        }
    }
}