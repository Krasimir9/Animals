using Nemetscheck.Database;
using Nemetscheck.Helpers.Commands;
using Nemetscheck.Repository.Contarcts;

namespace Zoo.Core.Commands
{
    public class HowManyAlive : Command
    {
        public HowManyAlive(List<string> parameters, IInMemoryDataBase database, IAnimalRepository repository) 
            : base(parameters, database, repository)
        {
        }
        public override string Execute()
        {
            var bears = Database.Bears.Where(x => x.IsDead == false).ToList();
            var wolves = Database.Wolfs.Where(x => x.IsDead == false).ToList();
            var rabits = Database.Rabits.Where(x => x.IsDead == false).ToList();
            return $"The number of all living animals is: {bears.Count + wolves.Count + rabits.Count}";
        }
    }
}
