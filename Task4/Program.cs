using Task4;

Player p1 = new Player();
Player p2 = new Player("Hero", 5, 100);

Console.WriteLine($"Player 1: {p1.playerName}, {p1.level}, {p1.health}");
Console.WriteLine($"Player 2: {p2.playerName}, {p2.level}, {p2.health}");