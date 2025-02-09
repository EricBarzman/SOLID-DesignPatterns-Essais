namespace ConsoleApp1.src.StructuralPatterns.Decorator.good
{
    public class EncryptionDecorator : DataDecorator
    {
        public EncryptionDecorator(Data data) : base(data)
        {
        }

        public override void Save(string data)
        {
            System.Console.WriteLine("Encrypting data");
            var encrypted = Encrypt(data);
            base._data.Save(encrypted);
        }

        public string Encrypt(string data) {
            
            string encryptedData = "";
            foreach (var letter in data)
            {
                encryptedData += letter.ToString() switch
                {
                    "a" or "e" or "i" or "o" or "u" => "vowel--",
                    "0" or "1" or "2" or "3" or "4" or "5" or "6" or "7" or "8" or "9" => "number--",
                    _ => "consonent--",
                };
            }

            return encryptedData;
        }
    }
}