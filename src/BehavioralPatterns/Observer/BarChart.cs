namespace ConsoleApp1.src.BehavioralPatterns.Observer
{
    public class BarChart: IObserver
    {
        private DataSource _datasource;

        public BarChart(DataSource dataSource)
        {
            _datasource = dataSource;
        }
        
        public void Update() {
            System.Console.WriteLine("Rendering bar chart with new values");
        }
    }   
}