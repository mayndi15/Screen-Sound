Dictionary<string, List<int>> bands = new Dictionary<string, List<int>>();

ShowMenu();

void ShowMenu()
{
    ShowWelcome();

    Console.WriteLine("\nEnter 1 to register a band");
    Console.WriteLine("Enter 2 to show a bands");
    Console.WriteLine("Enter 3 to rate a band");
    Console.WriteLine("Enter 4 to display the average of a band");
    Console.WriteLine("Enter 0 to exit");

    Console.Write("\nEnter your option: ");
    string option = Console.ReadLine()!;
    int numOption = int.Parse(option);

    switch (numOption)
    {
        case 0:
            Console.WriteLine("Exit");
            break;
        case 1:
            Register();
            break;
        case 2:
            Show();
            break;
        case 3:
            Rate();
            break;
        case 4:
            Average();
            break;
        default:
            Console.WriteLine("Invalid");
            break;
    }
}
void ShowWelcome()
{
    string welcome = "Welcome to Screen Sound";

    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine("\n" + welcome);
}
void ShowTitle(string title)
{
    int titleSize = title.Length;
    string asct = string.Empty.PadLeft(titleSize, '*');
    Console.WriteLine(asct);
    Console.WriteLine(title);
    Console.WriteLine(asct + "\n");
}

void Register()
{
    Console.Clear();
    ShowTitle("Register a band");
    Console.Write("Name: ");
    string name = Console.ReadLine()!;
    bands.Add(name, new List<int>());

    Console.WriteLine($"\nSuccessfully registered: {name}");
    Thread.Sleep(2000);
    Console.Clear();
    ShowMenu();
}
void Show()
{
    Console.Clear();
    ShowTitle("Show the bands");
    foreach (var band in bands.Keys)
    {
        Console.WriteLine($"Band: {band}");
    }
    Console.ReadKey();
    Console.Clear();
    ShowMenu();
}
void Rate()
{
    Console.Clear();
    ShowTitle("Rate the band");
    Console.Write("Name: ");
    string name = Console.ReadLine()!;
    if (bands.ContainsKey(name))
    {
        Console.Write($"Rate: ");
        int rate = int.Parse(Console.ReadLine()!);
        bands[name].Add(rate);
        Console.WriteLine($"\nSuccessfully evaluated: {name}");
        Thread.Sleep(2000);
        Console.Clear();
        ShowMenu();
    }
    else
    {
        Console.WriteLine($"Band not exists: {name}");
        Console.ReadKey();
        Console.Clear();
        ShowMenu();
    }
}
void Average()
{
    Console.Clear();
    ShowTitle("Average the band");
    Console.Write("Name: ");
    string name = Console.ReadLine()!;
    if (bands.ContainsKey(name))
    {
        List<int> average = bands[name];
        Console.WriteLine($"Average: {average.Average()}");
        Console.ReadKey();
        Console.Clear();
        ShowMenu();
    }
    else
    {
        Console.WriteLine($"Band not exists: {name}");
        Console.ReadKey();
        Console.Clear();
        ShowMenu();
    }
}
