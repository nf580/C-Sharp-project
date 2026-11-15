//Проект 2, калькулятор
using System.Data;

Console.WriteLine("Введите пример, используя +, -, *, /, (, )");
string example = Console.ReadLine();
string result = example.Replace(" ", "");
result = result.Replace("/", "*1.0/");
try
{
    DataTable table = new DataTable();

    
    object result2 = table.Compute(result, "");

    
    Console.WriteLine("Результат: " + result2);
}
catch (Exception)
{
    Console.WriteLine("Ошибка: Некорректное математическое выражение (проверьте скобки или знаки).");
} 
