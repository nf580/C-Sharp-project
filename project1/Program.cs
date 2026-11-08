//ПРОЕКТ "АНАГРАММА"
/*Console.WriteLine("Привет, это игра Анаграмма! На экране появится перемешанное слово, твоя задача - отгадать первоначальное слово.");
Console.WriteLine("Из скольки букв должно быть слово? (от 3 до 5)");
int quantity = int.Parse(Console.ReadLine());
if (quantity < 3 || quantity > 5)
{
    Console.WriteLine("Ошибка! Число должно быть от 3 до 5");
    return;
}
string[] threeletters = new string[] { "лес", "ель", "лоб", "бог", "рай", "код", "лот", "бок" };
string[] fourletters = new string[] { "блин", "клуб", "блок", "нота", "коса", "клок", "герб", "мель" };
string[] fiveletters = new string[] { "ягода", "червь", "шкура", "масло", "запах", "видео", "банан", "архив" };
int word = Random.Shared.Next(0, 8);
int attemps = 0;

switch (quantity)
{
    case 3:

        string scrambledword = threeletters[word];
        string shuffledWord = new string(scrambledword.OrderBy(c => Random.Shared.Next()).ToArray());
        Console.WriteLine(shuffledWord);
        Console.WriteLine("Что это за слово? ");

        while (true)
        {
            string guessedword = Console.ReadLine();
            attemps += 1;
            if (guessedword == scrambledword)
            {
                Console.WriteLine("Вы угадали!");
                Console.WriteLine("Попыток: " + attemps);
                break;
            }
            else
            {
                Console.WriteLine("Неправильно, попробуйте ещё раз.");
            }
        }
        break;
    case 4:

        string fourlettersword = fourletters[word];
        string shuffledfourlettersWord = new string(fourlettersword.OrderBy(c => Random.Shared.Next()).ToArray());
        Console.WriteLine(shuffledfourlettersWord);
        Console.WriteLine("Что это за слово? ");

        while (true)
        {
            string guessedword = Console.ReadLine();
            attemps += 1;
            if (guessedword == fourlettersword)
            {
                Console.WriteLine("Вы угадали!");
                Console.WriteLine("Попыток: " + attemps);
                break;
            }
            else
            {
                Console.WriteLine("Неправильно, попробуйте ещё раз.");
            }
        }
        break;
    case 5:
        string fivelettersword = fiveletters[word];
        string shuffledfivelettersWord = new string(fivelettersword.OrderBy(c => Random.Shared.Next()).ToArray());
        Console.WriteLine(shuffledfivelettersWord);
        Console.WriteLine("Что это за слово? ");

        while (true)
        {
            string guessedword = Console.ReadLine();
            attemps += 1;
            if (guessedword == fivelettersword)
            {
                Console.WriteLine("Вы угадали!");
                Console.WriteLine("Попыток: " + attemps);
                break;
            }
            else
            {
                Console.WriteLine("Неправильно, попробуйте ещё раз.");
            }
        }
        break;
} */

//Проект 2, калькулятор
using System.Data;
using System.Linq.Expressions;
using System.Reflection.PortableExecutable;

Console.WriteLine("Введите пример, используя +, -, *, /, (, )");
string example = Console.ReadLine();
string result = example.Replace(" ", "");
result = result.Replace("/", "*1.0/");
try
{
    DataTable table = new DataTable();

    
    object resultat = table.Compute(result, "");

    
    Console.WriteLine("Результат: " + resultat);
}
catch (Exception)
{
    Console.WriteLine("Ошибка: Некорректное математическое выражение (проверьте скобки или знаки).");
}
