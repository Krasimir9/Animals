using Nemecheck.Engines;
using Nemetscheck.Database;
using Nemetscheck.Engine;
using Nemetscheck.Helpers.ConsoleHelpers;
using Nemetscheck.Repository;
using Nemetscheck.Repository.Contarcts;

class Program
{
    private static readonly IAnimalRepository repository = new AnimalRepository();
    private static readonly IInMemoryDataBase database = new InMemoryDataBase();
    private static readonly ConsoleReader reader = new ConsoleReader();
    private static readonly ConsoleWriter writer = new ConsoleWriter();
    private static readonly IEngine engine = new Engine(repository, database, reader, writer);

    static void Main()
    {
        engine.Run();
    }

}

