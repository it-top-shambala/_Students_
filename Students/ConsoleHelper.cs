namespace Students;

public static class ConsoleHelper
{
    private static void PrintLine(string message, ConsoleColor color = ConsoleColor.White)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }
    private static void Print(string message, ConsoleColor color = ConsoleColor.White)
    {
        Console.ForegroundColor = color;
        Console.Write(message);
        Console.ResetColor();
    }

    public static void PrintInfo(string message)
    {
        PrintLine(message, ConsoleColor.Blue);
    }
    public static void PrintError(string message)
    {
        PrintLine(message, ConsoleColor.Red);
    }
    public static void PrintText(string message)
    {
        PrintLine(message, ConsoleColor.Green);
    }
    
    public static string Input(string message)
    {
        Print(message, ConsoleColor.Yellow);
        return Console.ReadLine();
    }
}