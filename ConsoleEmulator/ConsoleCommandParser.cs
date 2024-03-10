using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEmulator
{
    internal class ConsoleCommandParser(FileSystemService fileSystemService)
    {
        public void ParseCommand(string command)
        {
            var commandParts = command.Split(' ');

            switch (commandParts[0])
            {
                case "ls":
                    switch (commandParts.Length)
                    {
                        case 1:
                            fileSystemService.ListDirectoryContents();
                            break;
                        case > 1:
                            fileSystemService.ListDirectoryContents(commandParts[1]);
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Command not recognized");
                    break;
            }
        }
    }
}
