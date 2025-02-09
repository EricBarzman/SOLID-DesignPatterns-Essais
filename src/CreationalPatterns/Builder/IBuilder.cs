namespace ConsoleApp1.src.CreationalPatterns.Builder
{
    public interface IBuilder
    {
        void Reset();
        IBuilder SetCarType(CarType type);

        IBuilder SetSeats(int seats);

        IBuilder SetIsConvertible(bool isConvertible);
        // etc etc etc
    }
}