using Nemecheck.Commands;
using Nemetscheck.Database;
using Nemetscheck.Helpers.Commands.Contarcts;
using Nemetscheck.Helpers.ConsoleHelpers;
using Nemetscheck.Repository.Contarcts;
using Zoo.Core.Commands;

namespace Nemetscheck.Helpers.Commands
{
    public class CommandParser : ICommandParser
    {
        private readonly ConsoleReader reader;
        private readonly ConsoleWriter writer;
        public CommandParser(ConsoleReader reader, ConsoleWriter writer)
        {
            this.writer = writer;
            this.reader = reader;
        }
        public Command ParseCommand(string command, IInMemoryDataBase database, IAnimalRepository factory)
        {
            List<string> parameters = new List<string>();

            switch (command)
            {
                // Create Commands
                case "CreateBear":

                    writer.WriteLine("Bear has been created!");
                    return new CreateBearCommand(parameters, database, factory);

                case "CreateWolf":

                    writer.WriteLine("Wolf has been created!");
                    return new CreateWolfCommand(parameters, database, factory);

                case "CreateRabir":

                    writer.WriteLine("Rabbit has been created!");
                    return new CreateRabbitCommand(parameters, database, factory);

                // Remove Commands
                case "Hunger":

                    writer.WriteLine("The animals are hungry.");
                    return new Hunger(parameters, database, factory);

                case "Feed":

                    var feed = new Feed(parameters, database, factory);
                    writer.WriteLine(feed.Execute());
                    return feed;

                case "ShowHealth":

                    writer.WriteLine("Which species health you would like to see?");
                    writer.WriteLine();
                    writer.WriteLine("For bears enter: Bears");
                    writer.WriteLine("For wolvs enter: Wolves");
                    writer.WriteLine("For monkeys enter: Rabits");
                    parameters.Add(reader.Read());
                    var show = new ShowHealth(parameters, database, factory);
                    writer.WriteLine(show.Execute());
                    return show;

                case "HowManyAlive":

                    var alive = new HowManyAlive(parameters, database, factory);
                    writer.WriteLine(alive.Execute());
                    return alive;

                default:
                    throw new InvalidOperationException("Command does not exist");
            }
        }
    }
}
