// Урок 7, задание 3

class Player
{
    public string Name;
    public int Level;
    public double Health;
    public double Damage;

    public Player(string name, int level, double health, double damage)
    {
        Name = name;
        Level = level;
        Health = health;
        Damage = damage;
    }

    public void Attack()
    {
        Console.WriteLine(Name + " атакует!");
        Console.WriteLine("Урон: " + Damage);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        
        if (Health < 0)
        {
            Health = 0;
        }
    }

    public void Heal(int health)
    {
        Health += health;
    }

    public void PrintInfo()
    {
        Console.WriteLine("==================================");
        Console.WriteLine("Имя: " + Name);
        Console.WriteLine("Уровень: " + Level);
        Console.WriteLine("Урон: " + Damage);
        Console.WriteLine("ХП: " + Health);
        Console.WriteLine("==================================");
    }
}



