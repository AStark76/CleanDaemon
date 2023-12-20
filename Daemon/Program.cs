using Daemon.Model;
namespace Ast.CleanDaemon.Daemon;

public static class Daemon
{
    /// <summary>
    /// Default start method
    /// </summary>
    /// <param name="args"></param>
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

    /// <summary>
    /// Reads the task file.
    /// </summary>
    /// <param name="currentDuty"></param>
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

    /// <summary>
    /// Reads all the task properties and converts then, after all it starts the process.
    /// </summary>
    /// <param name="taskProoperties"></param>
    /// <param name="inProcess"></param>
    private static void Run(string[] taskProoperties, Process inProcess)
    {
        string path = taskProoperties[0];
        if (!int.TryParse(taskProoperties[1], out int month))
        {
            month = 6;
        }
        bool.TryParse(taskProoperties[2], out bool isSubdirectory);
        bool.TryParse(taskProoperties[2], out bool isDeleteEmtpyFolder);
        if (inProcess.IsSimulation)
            Process(path, month, isSubdirectory, isDeleteEmtpyFolder, Console.WriteLine);
        else
            Process(path, month, isSubdirectory, isDeleteEmtpyFolder, File.Delete);

    }

    /// <summary>
    /// Does the work and removes the files.
    /// </summary>
    /// <param name="path"></param>
    /// <param name="month"></param>
    /// <param name="isSubdirectory"></param>
    /// <param name="isDeleteEmtpyFolder"></param>
    /// <param name="inAction"></param>
    private static void Process(string path, int month, bool isSubdirectory, bool isDeleteEmtpyFolder, Action<string> inAction)
    {
        if (isSubdirectory)
        {
            string[] directories = Directory.GetDirectories(path);
            foreach (var d in directories)
            {

                Process(d, month, isSubdirectory, isDeleteEmtpyFolder, inAction);
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
        if(isDeleteEmtpyFolder) DeleteFolder(path, isDeleteEmtpyFolder);
        return;
    }


    /// <summary>
    /// Deletes empty directories if the user wants so.
    /// </summary>
    /// <param name="path"></param>
    /// <param name="isDeleteEmtpyFolder"></param>
    private static void DeleteFolder(string path, bool isDeleteEmtpyFolder)
    {
        if (0 == Directory.GetFiles(path).Length)
        {
            try
            {
                Directory.Delete(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    /// <summary>
    /// Displays a hint how to use 
    /// </summary>
    private static void DisplayHintMissingFile()
    {
        Console.WriteLine("Missing config File.\nDaemon .\\filestodelete [-s]");
        Environment.Exit(-1);
        Console.ReadKey();
    }
}