//Задание 1, урок 6
int BalanceA = 10000;
int BalanceB = 5000;
Console.WriteLine("Сколько вы хотите перевести с первого счёта на второй?");
int transfer = int.Parse(Console.ReadLine());
try
{
    if (transfer <= 0)
    {
        throw new Exception("Сумма перевода должна быть больше нуля!");
    }
    if (transfer > BalanceA)
    {
        throw new Exception("Недостаточно средств!");
    }
    BalanceA -= transfer;
    BalanceB += transfer;

    Console.WriteLine("Перевод выполнен!");
    Console.WriteLine($"Баланс отправителя: " + BalanceA);
    Console.WriteLine($"Баланс получателя: " + BalanceB);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Операция завершена.");
}

//Задание 2
string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
string file = Path.Combine(desktopPath, "data.txt");
try
{
    Console.WriteLine("Открываем файл....");
    string content = File.ReadAllText(file);
    Console.WriteLine("Содержимое файла: ");
    Console.WriteLine(content);
    Console.WriteLine("==============================================================");
}
catch (FileNotFoundException)
{
    Console.WriteLine("Файл не найден!");

}
finally
{
    Console.WriteLine("Работа с файлом завершена.");
}