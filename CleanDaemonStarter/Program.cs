using System.Diagnostics;

namespace CleanDaemonStarter;

public static class Program
{    static void Main(string[] args)
    {
        if ("-gui".Equals(args[0].ToLower()))
        {
            Process.Start("CleanDaemonWinForm.exe");
        }
        else
        {
            string parameter = string.Join(" ", args);
            
            Process.Start("Daemon", parameter);
        }
        Environment.Exit(0);
    }
}
