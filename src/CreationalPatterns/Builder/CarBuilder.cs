
namespace ConsoleApp1.src.CreationalPatterns.Builder
{
    public class CarBuilder : IBuilder
    {
        private Car _car;

        public CarBuilder() {
            Reset();
        }

        public void Reset()
        {
            _car = new Car();
        }

        public IBuilder SetIsConvertible(bool isConvertible)
        {
            _car.isConvertible = isConvertible;
            return this;
        }

        public IBuilder SetCarType(CarType type)
        {
            _car.Type = type;
            return this;
        }

        public IBuilder SetSeats(int seats)
        {
            _car.Seats = seats;
            return this;
        }

        public Car GetCar() {
            return _car;
        }
    }
}