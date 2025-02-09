using System.Transactions;

namespace ConsoleApp1.src.BehavioralPatterns.Observer
{
    public class DataSource : Subject
    {
        private List<int> _values = new List<int>();

        public List<int> Getvalues() {
            return _values;
        }

        public void SetValues(List<int> values) {
            _values = values;
            NotifyObservers();
        }
    }
}