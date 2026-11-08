using System.Security.Cryptography;
//Урок 3
//Задание 6
Console.WriteLine("Игра Угадай число");
Console.WriteLine("Вам нужно угадать число от 1 до 100");
int random = Random.Shared.Next(1, 101);
int first;
int second = 0;
Console.WriteLine("Введите число: ");
while (true)
{
    first = int.Parse(Console.ReadLine());
    second++;
    if (first == random)
    {
        Console.WriteLine("Вы угадали!");
        Console.WriteLine("Попыток израсходовано: " + second);
        break;
    }
    else if (first < random)
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Загаданное число больше");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");


    }
    else if (first > random)
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Загаданное число меньше");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");

    }
} 


//Задание 12


Console.WriteLine("Введите кол-во строк");
int line = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int column = int.Parse(Console.ReadLine());
Console.WriteLine("Введите символ, из которого нужно сделать прямоугольник: ");
string symbol = Console.ReadLine();

for (int i = 0; i < line; i++)
{
    for (int j = 0; j < column; j++)
    {
        Console.Write(symbol);
    }
    Console.WriteLine();
}