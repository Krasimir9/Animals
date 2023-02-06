using Nemetscheck.Database;
using Nemetscheck.Repository.Contarcts;

namespace Nemetscheck.Helpers.Commands.Contarcts
{
    public interface ICommandParser
    {
        Command ParseCommand(string command, IInMemoryDataBase database, IAnimalRepository repository);
    }
}
