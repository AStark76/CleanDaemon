using Daemon.Model;
namespace Ast.CleanDaemon.Daemon;

public class Daemon
{
    Process currentDuty;
    private static void Main(string[] args)
    {
        
        if (0 == args.Length)
        {
            DisplayHintMissingFile();
        }
        currentDuty = new Process(args[0]);
        if ("-s" == args[1].ToLower()) currentDuty.IsSimulation = true;
        Run(currentDuty);
    }

    private static void Run(Process currentDuty)
    {
        try
        {
            string[] data = File.ReadAllLines(currentDuty.ProcessFile);
            foreach (var processPropertyLine in data)
            {
                string[] taskProoperties = processPropertyLine.Split('|');

            }
        }
        catch(Exception ex)
        {

        }
    }

    private static void DisplayHintMissingFile()
    {
        Console.WriteLine("Missing config File.\nCleanDaemon .\\filestodelete [-s]");
        Environment.Exit(-1);
        Console.ReadKey();
    }
}