using System.Diagnostics;

namespace CleanDaemonStarter;

public static class Program
{   
    /// <summary>
    /// Default start method, starts winform or daemon depending on the parameter
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        Process _process;
        if ("-gui".Equals(args[0].ToLower()))
        {
            _process = Process.Start("CleanDaemonWinForm.exe");
        }
        else
        {
            string parameter = string.Join(" ", args);

            _process = Process.Start("Daemon", parameter);
        }
        while (!_process.HasExited) { }
        Environment.Exit(0);
    }
}
