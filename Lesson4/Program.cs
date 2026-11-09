//Урок 4, задание 1
int first = Random.Shared.Next(1, 101);
int second = Random.Shared.Next(1, 101);
int third = Random.Shared.Next(1, 101);
int four = Random.Shared.Next(1, 101);
int five = Random.Shared.Next(1, 101);
int six = Random.Shared.Next(1, 101);
int seven = Random.Shared.Next(1, 101);
int eight = Random.Shared.Next(1, 101);
int nine = Random.Shared.Next(1, 101);
int ten = Random.Shared.Next(1, 101);
int[] randomNumbers = new int[10] { first, second, third, four, five, six, seven, eight, nine, ten };
Console.WriteLine(string.Join(", ", randomNumbers));
Console.WriteLine("Кол-во элементов: " + randomNumbers.Length);

//Урок 4, задание 15
//Создаём отсортированный массив из 1000 элементов
int[] randomID = new int[1000];
for (int i = 0; i < randomID.Length; i++)
{
    randomID[i] = Random.Shared.Next(1, 1001);
}
Array.Sort(randomID);
Console.WriteLine("Введите ID товара (от 1 до 1000)");
int ID = int.Parse(Console.ReadLine());
bool found = false;
//Обычный поиск
for (int i = 0; i < randomID.Length; i++)
{
    if (randomID[i] == ID)
    {
        Console.WriteLine("===========================");
        Console.WriteLine("Товар найден!");
        Console.WriteLine("Обычный поиск: ");
        Console.WriteLine("Проверено элементов: " + (i + 1));
        found = true;
        break;
    }

}

//Бинарный поиск
int left = 0;
int right = randomID.Length - 1;
int attempts = 0;
bool binaryFound = false;
while (left <= right)
{
    attempts = attempts + 1;
    int mid = (left + right) / 2;
    if (randomID[mid] == ID)
    {
        Console.WriteLine("Бинарный поиск: ");
        Console.WriteLine("Проверено элементов: " + attempts);
        binaryFound = true;
        break;
    }
    else if (randomID[mid] < ID)
    {
        left = mid + 1;
    }
    else if (randomID[mid] > ID)
    {
        right = mid - 1;
    }
}

if (!found)
{
    Console.WriteLine("Товар не найден");
}
if (!binaryFound)
{
    Console.WriteLine("Бинарный поиск: товар не найден");
}