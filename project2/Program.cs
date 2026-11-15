//ПРОЕКТ "АНАГРАММА"
/*Console.WriteLine("Привет, это игра Анаграмма! На экране появится перемешанное слово, твоя задача - отгадать первоначальное слово.");
while (true)
{
    Console.WriteLine("Из скольки букв должно быть слово? (от 3 до 5)");
    int quantity = int.Parse(Console.ReadLine());
    if (quantity < 3 || quantity > 5)
    {
        Console.WriteLine("Ошибка! Число должно быть от 3 до 5");
        return;
    }
    string[] letters = new string[] { "лес", "ель", "лоб", "бог", "рай", "код", "лот", "бок", "блин", "клуб", "блок", "нота", "коса", "клок", "герб", "мель", "ягода", "червь", "шкура", "масло", "запах", "видео", "банан", "архив" };
    int word = Random.Shared.Next(0, 8);
    int attemps = 0;


    switch (quantity)
    {
        case 3:
            break;
        case 4:
            word += 8;
            break;
        case 5:
            word += 16;
            break;
    }
    string scrambledword = letters[word];
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
            Console.WriteLine("Хотите сыграть ещё раз? Напишите да или нет");
            string answer = Console.ReadLine();
            if (answer == "да")
            {
                break;
            }
            else if (answer == "нет")
            {
                return;
            }
            else
            {
                Console.WriteLine("Ошибка, введите либо да, либо нет");
                return;
            }
        }
        else
        {
            Console.WriteLine("Неправильно, попробуйте ещё раз.");
        }
    }
} */