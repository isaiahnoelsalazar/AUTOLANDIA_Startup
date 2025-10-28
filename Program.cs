using CSSimpleFunctions;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Reflection;

namespace AUTOLANDIA_Startup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!Directory.Exists("resources"))
            {
                SimpleFileHandler.ProjectToLocation(Assembly.GetExecutingAssembly(), "AUTOLANDIA-Sales-and-Revenue-Report-Generation-System.zip");
                ZipFile.ExtractToDirectory("AUTOLANDIA-Sales-and-Revenue-Report-Generation-System.zip", "resources");
                File.Delete("AUTOLANDIA-Sales-and-Revenue-Report-Generation-System.zip");
            }
            ProcessStartInfo run0 = new ProcessStartInfo();
            run0.WorkingDirectory = "resources";
            run0.FileName = "resources\\AUTOLANDIA-Sales-and-Revenue-Report-Generation-System.exe";
            run0.UseShellExecute = false;
            run0.RedirectStandardOutput = true;
            run0.CreateNoWindow = true;
            Process.Start(run0);
        }
    }
}
