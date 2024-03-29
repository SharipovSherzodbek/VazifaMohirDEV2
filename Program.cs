using System; 
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to TASK2 from OOP2 \n\t So lets talk about Cars which you want!");

        Console.WriteLine("Enter your car model...");
        string carModel = Console.ReadLine();

        Console.WriteLine("Enter the year of the car you want to buy...");
        int carYear = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter how much money you have $... ");
        decimal carPrice = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter the maximum speed for the car you want to buy... km/h");
        decimal carSpeed = decimal.Parse(Console.ReadLine());

        Car car = new Car(carModel, carYear, carPrice, carSpeed);

        Console.WriteLine("Your choice is:");
        string carInfo = car.GetCarInfo();
        Console.WriteLine(carInfo);

        Console.WriteLine("  The price of your car will be cheaper every year !");

        car.PrintDepreciation();
        car.PrintDepreciation();
        car.PrintDepreciation();         
    }
}
