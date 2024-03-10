using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEmulator
{
    internal class ConsoleCommandParser(FileSystemService fileSystemService)
    {
        private readonly FileSystemService _fileSystemService = fileSystemService;

        public void ParseCommand(string command)
        {
        }
    }
}
