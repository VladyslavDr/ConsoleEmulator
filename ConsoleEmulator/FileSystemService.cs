using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEmulator
{
    internal class FileSystemService
    {
        public void ListDirectoryContents()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var directories = Directory.GetDirectories(currentDirectory);
            var files = Directory.GetFiles(currentDirectory);

            Console.WriteLine($"Current directory: {currentDirectory}");
            Console.WriteLine();

            Console.WriteLine("Directories:");
            foreach (var directory in directories)
            {
                Console.WriteLine(Path.GetFileName(directory));
            }

            Console.WriteLine();

            Console.WriteLine("Files:");
            foreach (var file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
            }
        }

        public void ListDirectoryContents(string path)
        {
            if (!Directory.Exists(path))
            {
                Console.WriteLine("Directory does not exist.");
                return;
            }

            var directories = Directory.GetDirectories(path);
            var files = Directory.GetFiles(path);

            Console.WriteLine($"Current directory: {path}");
            Console.WriteLine();

            Console.WriteLine("Directories:");
            foreach (var directory in directories)
            {
                Console.WriteLine(Path.GetFileName(directory));
            }

            Console.WriteLine();

            Console.WriteLine("Files:");
            foreach (var file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
            }
        }
        public void ChangeDirectory(string directoryName)
        {
        }

        public void CreateDirectory(string directoryName)
        {
        }

        public void RemoveFileOrDirectory(string path)
        {
        }

        // Add methods for copying, moving, reading file contents, searching files and directories, etc.
    }
}
