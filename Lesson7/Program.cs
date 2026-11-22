//Урок 7, задание 1
Console.WriteLine("Введите марку автомобиля: ");
string Brand = Console.ReadLine();
Console.WriteLine("Введите модель автомобиля: ");
string Model = Console.ReadLine();
Console.WriteLine("Введите год выпуска автомобиля: ");
int Year = int.Parse(Console.ReadLine());
Console.WriteLine("Введите, сколько топлива у автомобиля: ");
double Fuel = int.Parse(Console.ReadLine());
Console.WriteLine("Введите, сколько километров должен проехать автомобиль: ");
double kilometers = double.Parse(Console.ReadLine());
Console.WriteLine("Введите, на сколько заправить автомобиль: ");
int liters = int.Parse(Console.ReadLine());
Car car1 = new Car(Brand, Model, Year, Fuel, kilometers);
car1.Refuel(liters);
double remainder = Fuel - (kilometers / 10.0);
car1.PrintInfo();
if (car1.Drive(kilometers))
{
    Console.WriteLine("Автомобиль успешно доехал!!!");
    Console.WriteLine("Осталось топлива: " + remainder);
}
else
{
    Console.WriteLine("Недостаточно топлива для поездки.");
}






