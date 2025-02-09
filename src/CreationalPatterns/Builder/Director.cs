namespace ConsoleApp1.src.CreationalPatterns.Builder
{
    public class Director
    {
        public void ConstructSportsCar(IBuilder builder) {
            builder
                .SetCarType(CarType.Sports)
                .SetIsConvertible(true);
        }

        public void ConstructSUV(IBuilder builder) {
            builder
                .SetCarType(CarType.SUV)
                .SetIsConvertible(false);
        }
    }
}