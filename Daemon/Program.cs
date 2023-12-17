namespace Ast.CleanDaemon.Daemon;

public static class Daemon
{
    private static void Main(string[] args)
    {
        if (0 == args.Length)
        {
            DisplayHint();
            Console.ReadKey();
        }
        string file = args[0];
        Console.WriteLine(file);
    }

    private static void DisplayHint()
    {
        Console.WriteLine("Missing config File.\nCleanDaemon .\\filestodeletew");
        Environment.Exit(-1);
    }
}