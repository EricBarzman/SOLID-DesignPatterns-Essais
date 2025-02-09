namespace ConsoleApp1.src.StructuralPatterns.Decorator.good
{
    public abstract class DataDecorator : Data
    {
        protected Data _data;

        public DataDecorator(Data data)
        {
            _data = data;
        }

        public abstract void Save(string data);
    }
}