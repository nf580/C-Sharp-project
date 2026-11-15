/*Проект 2, калькулятор
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

    
    object result = table.Compute(result, "");

    
    Console.WriteLine("Результат: " + result);
}
catch (Exception)
{
    Console.WriteLine("Ошибка: Некорректное математическое выражение (проверьте скобки или знаки).");
} */
