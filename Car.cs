class Car
{
    private string CarModel { get; set; }
    private int CarYear { get; set; }
    private decimal CarPrice { get; set; }
    private decimal CarSpeed { get; set; }

    private int yearDifference;
    public Car(string carModel, int carYear, decimal carPrice, decimal carSpeed)
    {
        CarModel = carModel;
        CarYear = carYear;
        CarPrice = carPrice;
        CarSpeed = carSpeed;
    }
    public string GetCarInfo()
    {
        return $" Car model: {CarModel}\n Car year: {CarYear}\n Car price: ${CarPrice}\n Car Speed: {CarSpeed} km/h";
    }

    public void PrintDepreciation()
    {
        Console.WriteLine("\nEnter the year you want to find out...");
        int year = int.Parse(Console.ReadLine());

        decimal reducedPrice = CalculateDepreciation(year);

        Console.WriteLine($"The price of {CarModel} in {CarYear} were ${CarPrice} and in {year} will be {reducedPrice}$ ");
    }

    private decimal CalculateDepreciation(int year)
    {
        decimal depreciationPrice = CarPrice;
        yearDifference = year - CarYear;

        for (int i = 0; i < yearDifference; i++)
        {
            depreciationPrice *= 0.9m;
        }
        return depreciationPrice;
    }
}