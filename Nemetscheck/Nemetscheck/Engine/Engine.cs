using Nemetscheck.Database;
using Nemetscheck.Engine;
using Nemetscheck.Helpers.Commands;
using Nemetscheck.Helpers.Commands.Contarcts;
using Nemetscheck.Helpers.ConsoleHelpers;
using Nemetscheck.Repository.Contarcts;
using System.Text;
namespace Nemecheck.Engines
{
    public class Engine : IEngine
    {
        private readonly IInMemoryDataBase database;
        private readonly IAnimalRepository repository;
        private readonly ICommandParser commandParser;
        private readonly ConsoleReader reader;
        private readonly ConsoleWriter writer;
        private string lastStatus = "Waiting for input. Enter to submit.";
        public Engine(IAnimalRepository repository, IInMemoryDataBase database, ConsoleReader reader, ConsoleWriter writer)
        {
            this.writer = writer;
            this.reader = reader;
            this.repository = repository;
            this.database = database;
            this.commandParser = new CommandParser(reader, writer);
        }
        public void Run()
        {
            Console.WriteLine(InitialMessage());
            RunMainMenu();
        }
        private void RunMainMenu()
        {
            string input = reader.Read();
            if (input.ToLower() == "exit")
            {
                Environment.Exit(0);
            }

            this.Parse(input);
            RunMainMenu();
        }

        private void Parse(string input)
        {
            try
            {
                Command command = this.commandParser.ParseCommand(input, database, repository);
                this.lastStatus = command.Execute();
                // reader.Read();
            }
            catch (Exception e)
            {
                while (e.InnerException != null)
                {
                    e = e.InnerException;
                }
                this.lastStatus = $"ERROR: {e.Message}";
            }
        }
        private string InitialMessage()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Please type some of the following commands:");
            sb.AppendLine("1.  CreateBear");
            sb.AppendLine("2.  CreateWolf");
            sb.AppendLine("3.  CreateRabit");
            sb.AppendLine("4.  Feed");
            sb.AppendLine("5.  Hunger");
            sb.AppendLine("6.  ShowEnergy");
            sb.AppendLine("7.  HowManyAlive");
            sb.AppendLine("########################################");
            sb.AppendLine();
            return sb.ToString();
        }
    }
}
