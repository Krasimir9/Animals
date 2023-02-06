using Nemetscheck.Animals;
using Nemetscheck.Database;
using Nemetscheck.Repository.Contarcts;

namespace Nemetscheck.Helpers.Commands
{
    public class CreateWolfCommand : Command
    {
        private readonly IAnimalRepository _repository;
        public CreateWolfCommand(List<string> parameters, IInMemoryDataBase database, IAnimalRepository repository) 
            : base(parameters, database, repository)
        {
            this._repository = repository;
        }
        public override string Execute()
        {
            Wolf wolf = this._repository.CreateWolf("Wolf", 100, false);
            this.Database.Wolfs.Add(wolf);
            this.Database.Animals.Add(wolf);
            return wolf.ToString();
        }
    }
}
