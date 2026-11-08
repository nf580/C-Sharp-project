
// УРОК 1
//Задание 1
Console.WriteLine("Hello world!");
Console.WriteLine("Никита");

//Задание 2
string word = "Hello World!";
Console.WriteLine("Привет мир!");
Console.WriteLine(word);

//Задание 3
string name = "Никита";
int age = 14;
double height = 170.2;
bool answer = true;
Console.WriteLine("Имя: " + name);
Console.WriteLine("Возраст: " + age);
Console.WriteLine("Рост: " + height);
Console.WriteLine("Нравится ли мне программировать: " + answer);

//Задание 4
string name = "Никита";
char firstLetter = 'Н';
Console.WriteLine(name);
Console.WriteLine(firstLetter);
//Если заменить переменную firstLetter на текст, выдадет ошибку

//Задание 5
const int daysInWeek = 7;
int age = 14;
Console.WriteLine("Кол-во дней в неделе: " + daysInWeek);
Console.WriteLine("Возраст: " + age);
//Если попробовать поменять значение daysInWeek, то выдадет ошибку

//Задание 6
int a = 3;
int b = 6;
Console.WriteLine("Сумма чисел: " + (a + b));
Console.WriteLine("Разность чисел: " + (a - b));
Console.WriteLine("Произведение чисел: " + (a * b));
Console.WriteLine("Частное чисел: " + (a / b));

//Задание 7
int a = 10;
int b = 20;
a += 10;
b -= 30;
Console.WriteLine(a);
Console.WriteLine(b);

//Задание 8
double height = 3;
double width = 5.5;
Console.WriteLine("Площадь прямоугольника: " + (height * width));
Console.WriteLine("Периметр прямоугольника: " + (height + width) * 2);

//Задание 9
int first = 350;
int second = 120;
int discount = 50;
Console.WriteLine("Стоимость товаров со скидкой: " + ((first + second) - discount));

//Задание 10
int number = 42;
int a = 25;
int b = 5;
int c = 38;
number = number + a - b + c;
Console.WriteLine(number);

//Задание 11
int a = 10;
int b = 5;
int c = 2;
int fifty = a * b;
Console.WriteLine(fifty);
int hundred = a * b * c;
Console.WriteLine(hundred);