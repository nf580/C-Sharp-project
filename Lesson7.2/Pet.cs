//Урок 7, задание 3 из домашки

class Pet
{
    public string Name;
    public string Type;
    public double Age;
    public double Hunger = 50;
    public double Energy = 100;
    public double Happyness = 50;


    public Pet(string name, string type, double age)
    {
        Name = name;
        Type = type;
        Age = age;
    }

    public void Feed()
    {
        Hunger -= 20;
        Happyness += 10;
    }

    public void Play()
    {
        if (Energy > 0)
        {
            if (Hunger < 100)
            {
                Energy -= 20;
                Happyness += 20;
                Hunger += 10;
            }
            else
            {
                Console.WriteLine("Питомец не хочет играть, его голод равен 100");
            }

        }
        else
        {
            Console.WriteLine("Питомец не может играть, его энергия равна нулю");
        }

    }

    public void Sleep()
    {
        Energy += 30;
        Hunger += 10;
    }

    public void PassTime()
    {
        Hunger += 5;
        Energy -= 5;
        Happyness -= 5;
    }
    public void PrintInfo()
    {
        Console.WriteLine("Имя питомца: " + Name);
        Console.WriteLine("Тип питомца: " + Type);
        Console.WriteLine("Возраст питомца: " + Age);
        if (Hunger < 0)
        {
            Hunger = 0;
        }
        if (Hunger > 100)
        {
            Hunger = 100;
        }
        Console.WriteLine("Голод питомца: " + Hunger);
        if (Energy < 0)
        {
            Energy = 0;
        }
        if (Energy > 100)
        {
            Energy = 100;
        }
        Console.WriteLine("Энергия питомца: " + Energy);
        if (Happyness < 0)
        {
            Happyness = 0;
        }
        if (Happyness > 100)
        {
            Happyness = 100;
        }
        Console.WriteLine("Настроение питомца: " + Happyness);
        if (Happyness <= 0)
        {
            Console.WriteLine("Питомец грустит!");
        }
    }
}