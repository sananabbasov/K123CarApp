using ConsoleUI.Models;

namespace ConsoleUI.Methods
{
    public class CarManager
    {
        public void Start(Car car, decimal km)
        {
            // 100 km ------ 10L
            // 200   km ------ x L | 2000 /  100 = 20

            decimal findFuelPerKm = km * car.FuelMillage / 100;
            if (car.Fuel >= findFuelPerKm)// 10 - 20
            {
                car.Millage += km;
                car.Fuel -= findFuelPerKm;
            }
            else{
                Console.WriteLine("Go to gas station");
            }

        }

        public void Statistics(Car car)
        {
            Console.WriteLine($"Car name: {car.CarName}");
            Console.WriteLine($"Fuel: {car.Fuel}");
            Console.WriteLine($"Total millage: {car.Millage}");
        }

        public void GetFuel(Car car, decimal litr)
        {
            if (car.MaxFuel >= car.Fuel + litr)
            {
                car.Fuel += litr;
            }
            else
            {
                Console.WriteLine("Over fuel");
            }

        }



    }
}