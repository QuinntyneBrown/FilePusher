using FilePusher.Config;
using System;
using System.IO;

namespace FilePusher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leora IO File System Watcher. Press \'q\' to quit.");
            
            System.IO.FileSystemWatcher watcher = new System.IO.FileSystemWatcher();
            watcher.Path = AppConfiguration.Config.ProjectFolderPath;
            watcher.EnableRaisingEvents = true;
            watcher.IncludeSubdirectories = true;
            watcher.Changed += OnChanged;

            string input;

            do
            {
                input = Console.ReadLine();

            } while (Console.Read() != 'q');
        }

        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            Console.WriteLine("Changed");
        }
    }
}
