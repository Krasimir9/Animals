using Nemetscheck.Animals;
using Nemetscheck.Database;
using Nemetscheck.Repository.Contarcts;

namespace Nemetscheck.Helpers.Commands
{
    public class CreateRabbitCommand : Command
    {
        private readonly IAnimalRepository _repository;
        public CreateRabbitCommand(List<string> parameters, IInMemoryDataBase database, IAnimalRepository repository)
            : base(parameters, database, repository)
        {
            this._repository = repository;
        }
        public override string Execute()
        {
            Rabit rabit = this._repository.CreateRabit("Wolf", 100, false);
            this.Database.Rabits.Add(rabit);
            this.Database.Animals.Add(rabit);
            return rabit.ToString();
        }
    }
}
