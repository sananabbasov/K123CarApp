using ConsoleUI.Methods;
using ConsoleUI.Models;


// Attribute
// Reference primitive types
// LINQ
// S.O.L.I.D.


// 1. Start
// 2. Gas Station
// 3. Statistics
// 4. Developer Dahsboard
// 5. Exit


Car bmw = new()
{
    CarName = "X5",
    Fuel = 0,
    MaxFuel = 50,
    Millage = 18,
    FuelMillage = 10
};




Evvele:
Console.WriteLine("1. Start");
Console.WriteLine("2. Gas Station");
Console.WriteLine("3. Statistics");
Console.WriteLine("4. Developer Dahsboard");
Console.WriteLine("4. Exit");


int userInput = 0;
try
{
    userInput = Convert.ToInt32(Console.ReadLine());
}
catch (Exception e)
{
    ErrorManager.ErrorHandler(e.Message);
    Console.WriteLine("Something is wrong. Try again.");
    goto Evvele;
}


CarManager manager = new();


switch (userInput)
{
    case 1:
        try
        {
            Console.Clear();
            Console.Write("Write km: ");
            decimal userKm = Convert.ToDecimal(Console.ReadLine());
            manager.Start(bmw, userKm);
        }
        catch (Exception error)
        {
            ErrorManager.ErrorHandler(error.Message);
            Console.WriteLine("Something is wrong. Try again.");
            goto Evvele;
        }

        break;
    case 2:


        Console.Clear();
        break;
    case 3:
        Console.Clear();

        manager.Statistics(bmw);
        break;
    case 4:

        break;
    case 5:

        break;
    default:
        Console.WriteLine("Type different number");
        break;
}
goto Evvele;
