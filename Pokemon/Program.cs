using Pokemon;

Console.WriteLine("Pokemon Battle Simulator");
Console.WriteLine("");
Console.WriteLine("Starting game...");
Charmander c = new Charmander();

string? name = "";
while (name != "quit")
{
    Console.Write("Enter new name for Charmander (type 'quit' to exit): ");
    name = Console.ReadLine();
    if (name.ToUpper() == "QUIT") break;
    if (name.Length > 0)
    {
        c.name = name;
        Console.WriteLine($"Name {c.name} stored.");
        for (int i = 0; i < 10; i++)
        {
            c.BattleCry();
        }
    }
}
// do not close the application until user presses a key
Console.WriteLine("... press a key to continue ...");
ConsoleKeyInfo x = Console.ReadKey();