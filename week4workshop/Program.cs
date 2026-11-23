using week4workshop;

// ===== Task 1: Class, Object & Fields =====
Student s1 = new Student();
s1.name = "Ram";
s1.age = 20;
s1.course = "Computing";

Student s2 = new Student();
s2.name = "Sita";
s2.age = 21;
s2.course = "Networking";

Console.WriteLine($"Student 1: {s1.name}, {s1.age}, {s1.course}");
Console.WriteLine($"Student 2: {s2.name}, {s2.age}, {s2.course}");
Console.WriteLine($"College: {Student.college}");

Console.WriteLine();

// ===== Task 3: Parameter Types =====
ParameterDemo demo = new ParameterDemo();

int num = 5;
demo.Increase(ref num);
Console.WriteLine("After Increase: " + num);

string name;
demo.GetFullName(out name);
Console.WriteLine("Full name: " + name);

Console.WriteLine("Sum: " + demo.SumAll(1, 2, 3, 4, 5));

Console.WriteLine();

// ===== Task 4: Constructors =====
Player p1 = new Player();
Player p2 = new Player("Hero", 5, 100);

Console.WriteLine($"Player 1: {p1.playerName}, {p1.level}, {p1.health}");
Console.WriteLine($"Player 2: {p2.playerName}, {p2.level}, {p2.health}");

Console.WriteLine();

// ===== Task 5: Enums and Records =====
Console.Write("Enter the day (e.g. Sunday): ");
string day = Console.ReadLine() ?? "";

DayType dayType;
if (day.ToLower() == "friday" || day.ToLower() == "saturday")
{
    dayType = DayType.Weekend;
}
else
{
    dayType = DayType.Weekday;
}
Console.WriteLine("It is: " + dayType);

Book book1 = new Book("C# Basics", "John Smith", 25.5);
Book book2 = book1 with { title = "Advanced C#", price = 40.0 };

Console.WriteLine(book1);

var (title, author, price) = book2;
Console.WriteLine($"{title}, {author}, {price}");

Console.WriteLine();

// ===== Task 6: Debugging =====
Console.Write("Enter marks: ");
int.TryParse(Console.ReadLine(), out int marks);

Console.Write("Enter total: ");
int.TryParse(Console.ReadLine(), out int total);

double percentage = marks / total * 100;
Console.WriteLine("Percentage: " + percentage);