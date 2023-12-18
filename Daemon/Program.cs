using Daemon.Model;
namespace Ast.CleanDaemon.Daemon;

public static class Daemon
{

    private static void Main(string[] args)
    {
        Process currentDuty = null;
        if (0 == args.Length)
            DisplayHintMissingFile();
        else
        {
            currentDuty = new Process(args[0]);
            if (2 == args.Length)
                currentDuty.IsSimulation = "-s" == args[1].ToLower();
        }

        PrepareRun(currentDuty);
    }

    private static void PrepareRun(Process currentDuty)
    {
        try
        {
            string[] data = File.ReadAllLines(currentDuty.ProcessFile);
            foreach (var processPropertyLine in data)
            {
                string[] taskProoperties = processPropertyLine.Split('|');
                Run(taskProoperties, currentDuty);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Environment.Exit(0);
    }

    private static void Run(string[] taskProoperties, Process inProcess)
    {
        string path = taskProoperties[0];
        if (!int.TryParse(taskProoperties[1], out int month))
        {
            month = 6;
        }
        bool.TryParse(taskProoperties[2], out bool isSubdirectory);
        if (inProcess.IsSimulation)
            Delete(path, month, isSubdirectory, Console.WriteLine);
        else
            Delete(path, month, isSubdirectory, File.Delete);

    }

    private static void Delete(string path, int month, bool isSubdirectory, Action<string> inAction)
    {
        if (isSubdirectory)
        {
            string[] directories = Directory.GetDirectories(path);
            foreach (var d in directories)
            {

                Delete(d, month, isSubdirectory, inAction);
            }
        }
        string[] files = Directory.GetFiles(path);
        foreach (var item in files)
        {
            FileInfo fileInfo = new FileInfo(item);
            if (DateTime.Today.AddDays((-1) * month) >= fileInfo.CreationTime.Date)
            {
                inAction(item);
            }
        }
        return;
    }

    private static void DisplayHintMissingFile()
    {
        Console.WriteLine("Missing config File.\nCleanDaemon .\\filestodelete [-s]");
        Environment.Exit(-1);
        Console.ReadKey();
    }
}