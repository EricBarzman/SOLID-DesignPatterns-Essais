namespace ConsoleApp1.src.BehavioralPatterns.Observer
{
    public class Sheet2 : IObserver
    {
        private DataSource _datasource;
        private int _total;

        public Sheet2(DataSource dataSource) {
            _datasource = dataSource;
        }

        public void Update() {
            _total = CalculateTotal(_datasource.Getvalues());
        }

        public int CalculateTotal(List<int> values) {
            var sum = 0;
            foreach(var value in values)
                sum += value;
            
            System.Console.WriteLine("Total: " + sum);
            return sum;
        }

        public int GetTotal() {
            return _total;
        }
    }
}