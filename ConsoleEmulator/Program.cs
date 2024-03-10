namespace ConsoleEmulator
{
    internal static class Program
    {
        static void Main()
        {
            FileSystemService fileSystemService = new();
            ICommandService commandService = new CommandService(fileSystemService);

            Directory.SetCurrentDirectory(CurrentDirectory.Path);

            while (true)
            {
                Console.Write($"{CurrentDirectory.Path}> ");

                var command = Console.ReadLine();

                commandService.ExecuteCommand(command);
            }
        }
    }
}
