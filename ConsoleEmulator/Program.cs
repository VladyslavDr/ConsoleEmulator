namespace ConsoleEmulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Usage: ConsoleEmulator <command>");
                return;
            }

            FileSystemService fileSystemService = new();
            ConsoleCommandParser commandParser = new(fileSystemService);

            var input = string.Join(" ", args);
            commandParser.ParseCommand(input);
        }
    }
}
