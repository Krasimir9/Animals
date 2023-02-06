using Nemetscheck.Database;
using Nemetscheck.Helpers.Commands;
using Nemetscheck.Repository.Contarcts;

namespace Zoo.Core.Commands
{
    public class Hunger : Command
    {
        public Hunger(List<string> parameters, IInMemoryDataBase database, IAnimalRepository repository) 
            : base(parameters, database, repository)
        {
        }
        public override string Execute()
        {
            var random = new Random();
            var toDecreaseBearsHealth = random.Next(15, 35);
            var bears = this.Database.Bears.Where(x => x.IsDead == false).ToList();
            foreach (var bear in bears)
            {
                bear.Energy -= toDecreaseBearsHealth;
                if (bear.Energy < 65)
                {
                    bear.IsDead = true;
                }
            }
            var toDecreaseWolfsHealth = random.Next(15, 35);
            var wolfs = this.Database.Wolfs.Where(x => x.IsDead == false).ToList();
            foreach (var wolf in wolfs)
            {
                wolf.Energy -= toDecreaseWolfsHealth;
                if (wolf.Energy < 60)
                {
                    wolf.IsDead = true;
                }
            }
            var toDecreaseRabitsHealth = random.Next(15, 35);
            var rabits = this.Database.Rabits.Where(x => x.IsDead == false).ToList();
            foreach (var rabit in rabits)
            {
                rabit.Energy -= toDecreaseRabitsHealth;
                if (rabit.Energy < 40)
                {
                    rabit.IsDead = true;
                }
            }
            return "Most of the animals are starving. Feed them!";
        }
    }
}
