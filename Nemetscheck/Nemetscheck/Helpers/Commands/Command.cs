using Nemetscheck.Database;
using Nemetscheck.Repository.Contarcts;

namespace Nemetscheck.Helpers.Commands
{
    public abstract class Command
    {
        protected Command(List<string> parameters, IInMemoryDataBase database, IAnimalRepository repository)
        {
            this.Parameters = new List<string>(parameters);
            this.Factory = repository;
            this.Database = database;
        }

        public abstract string Execute();

        protected List<string> Parameters { get; }

        protected IInMemoryDataBase Database { get; }

        protected IAnimalRepository Factory { get; }

    }
}
