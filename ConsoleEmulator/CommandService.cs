using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEmulator
{
    internal class CommandService(FileSystemService fileSystemService) : ICommandService
    {
        public void ExecuteCommand(string? command)
        {
            if (string.IsNullOrEmpty(command))
            {
                Console.WriteLine("Command not recognized");
                return;
            }

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
                case "cd":
                    fileSystemService.ChangeDirectory(commandParts[1]);
                    break;

                default:
                    Console.WriteLine("Command not recognized");
                    break;
            }
        }
    }
}
