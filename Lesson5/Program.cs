//Задание 1, урок 5
void PrintHello()
{
    Console.WriteLine("Привет! Добро пожаловать в программу.");
}
PrintHello();

//Задание 6

int number = 5;
Console.WriteLine(number);
void AddTen(ref int number)
{
    number = number + 10;
}
AddTen(ref number);
Console.WriteLine(number);

//Задание 7
void GetStatistics(int a, int b, int c, out int min, out int max, out int sum, out double average)
{
    min = Math.Min(a, Math.Min(b, c));
    max = Math.Max(a, Math.Max(b, c));
    sum = a + b + c;
    average = (a + b + c) / 3;
}
Console.WriteLine("Введите первое число: ");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int second = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int third = int.Parse(Console.ReadLine());

GetStatistics(first, second, third, out int min, out int max, out int sum, out double average);
Console.WriteLine("Минимальное число: " + min);
Console.WriteLine("Максимальное число: " + max);
Console.WriteLine("Сумма чисел: " + sum);
Console.WriteLine("Среднее арифметическое чисел: " + average);

//Задание 10
bool TryCreateOrder(double balance, double productPrice, int quantity, out double totalPrice, out double remainingBalance)
{
    if (quantity <= 0)
    {

        totalPrice = 0;
        remainingBalance = balance;
        return false;
    }
    totalPrice = productPrice * quantity;
    if (totalPrice > balance)
    {

        remainingBalance = balance;
        return false;
    }
    else
    {
        remainingBalance = balance - totalPrice;
    }
    return true;

}
Console.WriteLine("Введите ваш баланс: ");
double balance = double.Parse(Console.ReadLine());
Console.WriteLine("Введите цену товара: ");
double productPrice = double.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во товара: ");
int quantity = int.Parse(Console.ReadLine());


if (TryCreateOrder(balance, productPrice, quantity, out double totalPrice, out double remainingBalance))
{
    Console.WriteLine("========================================");
    Console.WriteLine("Баланс: " + balance);
    Console.WriteLine("Цена товара: " + productPrice);
    Console.WriteLine("Количество: " + quantity);
    Console.WriteLine();
    Console.WriteLine("Заказ создан!");
    Console.WriteLine();
    Console.WriteLine("Стоимость заказа: " + totalPrice);
    Console.WriteLine("Остаток: " + remainingBalance);
    Console.WriteLine("========================================");
}
else
{
    Console.WriteLine("========================================");
    Console.WriteLine("Баланс: " + balance);
    Console.WriteLine("Цена товара: " + productPrice);
    Console.WriteLine("Количество: " + quantity);
    Console.WriteLine();
    Console.WriteLine("Не удалось сделать заказ.");
    Console.WriteLine("Недостаточно средств.");
}