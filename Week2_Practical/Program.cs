public static class Program
{

    public static void PrintMenu()
    {
        Console.WriteLine("Please enter a valid option from below");
        Console.WriteLine("1. Hello in French?");
        Console.WriteLine("2. Hello in Spanish?");
        Console.WriteLine("3. Hello in German?");
        Console.WriteLine("4. Hello in Italian?");
        Console.WriteLine("0. Exit application");
    }

    public static int InputOption()
    {
        try
        {
            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }
        catch
        {
            Console.WriteLine("Invalid input. Please enter a valid option.");
            return -1;
        }
    }

    public static void GetMessage(int option)
    {
        switch (option)
        {
            case 1:
                Console.WriteLine("Bonjour");
                break;
            case 2:
                Console.WriteLine("Hola");
                break;
            case 3:
                Console.WriteLine("Hallo");
                break;
            case 4:
                Console.WriteLine("Ciao");
                break;
            case 0:
                Console.WriteLine("Exiting application...");
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }
    }
    public static void Main(string[] args)
    {
        PrintMenu();
        int option = InputOption();
        GetMessage(option);

    }
}