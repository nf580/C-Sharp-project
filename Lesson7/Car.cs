//Урок 7, задание 1
class Car
{
    public string Brand;
    public string Model;
    public int Year;
    public double Fuel;
    public double kilometers;

    public Car(string Brand, string Model, int Year, double Fuel, double kilometers)
    {
        this.Brand = Brand;
        this.Model = Model;
        this.Year = Year;
        this.Fuel = Fuel;
        this.kilometers = kilometers;
    }
    public void PrintInfo()
    {
        Console.WriteLine("Автомобиль: " + Brand +" " + Model);
        Console.WriteLine("Топливо: " + Fuel);
        Console.WriteLine("Год произвоства: " +  Year);
    }
    public bool Drive(double kilometers)
    {
        double ratio = kilometers / Fuel;
        if (ratio <= 10)
        {
            
            return true;
        }
        else if (ratio >10)
        {
            return false;
        }
        else
        {
            return false;
        }
    }
    public void Refuel(double liters)
    {
        Fuel = Fuel + liters;
    }
}
