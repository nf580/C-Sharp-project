/*УРОК 1
Задание 1
Console.WriteLine("Hello world!");
Console.WriteLine("Никита");

Задание 2
string word = "Hello World!";
Console.WriteLine("Привет мир!");
Console.WriteLine(word);

Задание 3
string name = "Никита";
int age = 14;
double height = 170.2;
bool answer = true;
Console.WriteLine("Имя: " + name);
Console.WriteLine("Возраст: " + age);
Console.WriteLine("Рост: " + height);
Console.WriteLine("Нравится ли мне программировать: " + answer);

Задание 4
string name = "Никита";
char firstLetter = 'Н';
Console.WriteLine(name);
Console.WriteLine(firstLetter);
Если заменить переменную firstLetter на текст, выдадет ошибку

Задание 5
const int daysInWeek = 7;
int age = 14;
Console.WriteLine("Кол-во дней в неделе: " + daysInWeek);
Console.WriteLine("Возраст: " + age);
Если попробовать поменять значение daysInWeek, то выдадет ошибку

Задание 6
int a = 3;
int b = 6;
Console.WriteLine("Сумма чисел: " + (a + b));
Console.WriteLine("Разность чисел: " + (a - b));
Console.WriteLine("Произведение чисел: " + (a * b));
Console.WriteLine("Частное чисел: " + (a / b));

Задание 7
int a = 10;
int b = 20;
a += 10;
b -= 30;
Console.WriteLine(a);
Console.WriteLine(b);

Задание 8
double height = 3;
double width = 5.5;
Console.WriteLine("Площадь прямоугольника: " + (height * width));
Console.WriteLine("Периметр прямоугольника: " + (height + width) * 2);

Задание 9
int first = 350;
int second = 120;
int discount = 50;
Console.WriteLine("Стоимость товаров со скидкой: " + ((first + second) - discount));

Задание 10
int number = 42;
int a = 25;
int b = 5;
int c = 38;
number = number + a - b + c;
Console.WriteLine(number);

Задание 11
int a = 10;
int b = 5;
int c = 2;
int fifty = a * b;
Console.WriteLine(fifty);
int hundred = a * b * c;
Console.WriteLine(hundred);


Шифр ЦЕЗАРЯ
char[] letters = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', };
Console.WriteLine("Введите слово :");
string userWord = Console.ReadLine();
Console.WriteLine("На сколько символов нужно шифровать? ");
int colvo = int.Parse(Console.ReadLine());
int n = 0;
int l = userWord.Length;

while (n <= l)
{


char itog = letters[n + colvo];
Console.WriteLine(itog);
n = n + 1;

}  //НЕДОДЕЛАНО

class Program
{
    static void Main()
    {
        Урок 2

        Калькулятор, задание 8
        Console.WriteLine("Введите первое число: ");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int second = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите тип операции: *,/,+,-");
        string type = Console.ReadLine();

        int result = 0;
        bool error = true;
        switch (type)
        {
            case "+":
                result = first + second;
                break;
            case "-":
                result = first - second;
                break;
            case "*":
                result = first * second;
                break;
            case "/":
                if (second != 0)
                {
                    result = first / second;
                    break;
                }
                else
                {
                    error = false; Console.WriteLine("Ошибка, делить на 0 нельзя");
                    break;
                }
            default:
                Console.WriteLine("Ошибка, введите *, /, + или -");
                break;
        }
        if (error == true)
        {
            Console.WriteLine(result);
        }

        Задание 13
        Калькулятор доставки
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Пиццерия у дома~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        //Получение данных
        Console.WriteLine("Введите название товара: ");
        string name = Console.ReadLine();
        Console.WriteLine("Введите стоимость товара (в рублях): ");
        double price = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите вес товара (в килограммах): ");
        double weight = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите расстояние доставки (в метрах): ");
        double distance = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите способ доставки: 1 - Обычная, 2 - Экспресс, 3 - Самовывоз");
        int type = int.Parse(Console.ReadLine());
        int priceWeight = 0;
        string tip = "Обычная";
        //Обработка данных
        //Проверка ввода



        if (type > 3 && type < 1)
        {
            Console.WriteLine("Ошибка, вводите либо 1, либо 2, либо 3");
            return;
        }
        if (weight <= 1)
        {
            priceWeight = 100;
        }
        else if (weight <= 5)
        {
            priceWeight = 200;
        }
        else if (weight <= 10)
        {
            priceWeight = 350;
        }
        else if (weight > 10)
        {
            priceWeight = 500;
        }
        else if (price > 5000)
        {
            priceWeight = 0;
        }
        else if (weight <= 0)
        {
            Console.WriteLine("Ошибка, вес не может быть отрицательным");
        }

        //Стоимость
        switch (type)
        {

            case 2:
                priceWeight *= 2;
                break;
            case 3:
                priceWeight = 0;
                break;
        }
        switch (type)
        {
            case 1:
                tip = "Обычная";
                break;
            case 2:
                tip = "Экспресс";
                break;
            case 3:
                tip = "Самовывоз";
                break;
        }
        //Вывод данных
        Console.WriteLine("Товар: " + name);
        Console.WriteLine("Стоимость товара: " + price + " рублей");
        Console.WriteLine("Вес: " + weight + "кг");
        Console.WriteLine("Расстояние: " + distance + "м");
        Console.WriteLine("Способ доставки: " + tip);
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Стоимость доставки: " + priceWeight);
        Console.WriteLine("Итоговая стоимость: " + (price + priceWeight));


//Задание 15
Console.WriteLine("Введите своё имя: ");
string name = Console.ReadLine();
Console.WriteLine("Введите свой возраст: ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Введите начальный баланс: ");
double balance = double.Parse(Console.ReadLine());
Console.WriteLine("Введите тип счёта: 1 - дебетовый, 2 - накопительный, 3 - премиальный");
int type = int.Parse(Console.ReadLine());
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine("Выберите операцию: 1 - пополнить счёт, 2 - снять деньги, 3 - проверить баланс, 4 - получить информацию о счёте");
int operation = int.Parse(Console.ReadLine());
string typeOperation = "1";


switch (operation)
{
    case 1:
        Console.WriteLine("На какую сумму вы хотите пополнить счёт?");
        double replenishment = double.Parse(Console.ReadLine());
        if (replenishment <= 0)
        {
            Console.WriteLine("Ошибка, сумма не может быть равна нулю или отрицательной");
            return;
        }
        balance += replenishment;
        typeOperation = "пополнение";
        break;
    case 2:
        Console.WriteLine("Какую сумму вы хотите снять?");
        double removal = double.Parse(Console.ReadLine());
        if (removal <= 0)
        {
            Console.WriteLine("Ошибка, сумма снятия не может быть равна нулю или отрицательной");
            return;
        }
        if (removal > balance)
        {
            Console.WriteLine("Ошибка, сумма снятия больше вашего баланса, если вам не хватает денег, предлагаем вам оформить выгодный кредит всего под 200% годовых! Позвоните по номеру - 900");
            return;
        }
        if (age < 18 && removal > 5000)
        {
            Console.WriteLine("Ошибка, вы не можете снимать больше 5000 рублей, т.к вам меньше 18 лет");
            return;
        }
        balance -= removal;
        if (balance < 1000)
        {
            Console.WriteLine("На вашем счёте осталось менее 1000 рублей");
        }
        typeOperation = "Снятие";
        break;
    case 3:
        Console.WriteLine(balance);
        typeOperation = "проверка баланса";
        break;
    case 4:
        if (type == 3)
        {
            Console.WriteLine("Вам доступно премиальное обслуживание.");
        }
        else
        {
            Console.WriteLine("Ваш счёт: " + type);
        }
        typeOperation = "проверка типа счёта";
        break;
}
//Вывод

Console.WriteLine("========== БАНК ==========");
Console.WriteLine("");
Console.WriteLine("Клиент: " + name);
Console.WriteLine("Возраст: " + age);
Console.WriteLine("Тип счёта: " + type);
Console.WriteLine("Баланс: " + balance);
Console.WriteLine("");
Console.WriteLine("Результат операции: " + typeOperation);
Console.WriteLine("==========================");


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
else if (first<random)
{
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine("Загаданное число больше");
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");


}
else if (first>random)
{
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine("Загаданное число меньше");
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");

}
} 


//Задание 12
*/using System.Security.Cryptography;

Console.WriteLine("Введите кол-во строк");
int line = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int column = int.Parse(Console.ReadLine());
Console.WriteLine("Введите символ, из которого нужно сделать прямоугольник: ");
string symbol = Console.ReadLine();

for (int i = 0; i<line; i++)
{
for (int j = 0; j<column; j++)
{
Console.Write(symbol);
}
Console.WriteLine();
}
