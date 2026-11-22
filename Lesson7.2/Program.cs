//Урок 7, задание 3 из домашки

Console.WriteLine("Что у вас за питомец?");
string type = Console.ReadLine();
Console.WriteLine("Как будут звать вашего питомца?");
string name = Console.ReadLine();
Console.WriteLine("Сколько лет вашему питомцу?");
double age = double.Parse(Console.ReadLine());

Pet pet1 = new Pet(name, type, age);
pet1.PrintInfo();
Console.WriteLine("=======================================================");
Console.WriteLine("Питомец создан, что вы хотите с ним сделать?");
while (true)
{
    Console.WriteLine("1 - покормить, 2 - поиграть, 3 - положить спать, 4 - закрыть программу");
    int choice = int.Parse(Console.ReadLine());
    if (choice < 1 || choice > 4)
    {
        Console.WriteLine("Ошибка, введите либо 1, либо 2, либо 3, либо 4!");
    }
    switch (choice)
    {
        case 1:
            pet1.Feed();
            break;
        case 2:
            pet1.Play();
            break;
        case 3:
            pet1.Sleep();
            break;
        case 4:
            return;
    }
    pet1.PassTime();
    Console.WriteLine("Прошёл час");
    pet1.PrintInfo();
    Console.WriteLine("=======================================================");
}
