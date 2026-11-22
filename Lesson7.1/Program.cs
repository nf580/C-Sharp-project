// Урок 7, задание 3

Player player1 = new Player("Boss", 5, 50,50);
Player player2 = new Player("Bruh", 7, 60,50);
player1.Attack();
player2.Attack();
player1.TakeDamage(45);
player1.Heal(30);
Console.WriteLine("Игрок 1");

player1.PrintInfo();
Console.WriteLine("Игрок 2");
player2.PrintInfo();



