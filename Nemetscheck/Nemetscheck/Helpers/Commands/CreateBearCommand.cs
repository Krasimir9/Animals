using Nemetscheck.Animals;
using Nemetscheck.Database;
using Nemetscheck.Helpers.Commands;
using Nemetscheck.Repository.Contarcts;

namespace Zoo.Core.Commands
{
    public class CreateBearCommand : Command
    {
        private readonly IAnimalRepository _repository;
        public CreateBearCommand(List<string> parameters, IInMemoryDataBase database, IAnimalRepository repository) 
            : base(parameters, database, repository)
        {
            this._repository = repository;
        }
        public override string Execute()
        {
            Bear bear = this._repository.CreateBear("Bear", 100, false);
            this.Database.Bears.Add(bear);
            this.Database.Animals.Add(bear);
            return bear.ToString();
        }
    }
}
