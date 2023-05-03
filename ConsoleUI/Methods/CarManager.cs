using ConsoleUI.Models;

namespace ConsoleUI.Methods
{
    public class CarManager
    {
        public void Start(Car car, decimal km)
        {
            car.Millage += km;
        }

        public void Statistics(Car car)
        {
            Console.WriteLine($"Car name: {car.CarName}");
            Console.WriteLine($"Fuel: {car.Fuel}");
            Console.WriteLine($"Total millage: {car.Millage}");
        }



    }
}