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
            var giraffes = this.Database.Wolfs.Where(x => x.IsDead == false).ToList();
            foreach (var giraffe in giraffes)
            {
                giraffe.Energy -= toDecreaseWolfsHealth;
                if (giraffe.Energy < 60)
                {
                    giraffe.IsDead = true;
                }
            }
            var toDecreaseRabitsHealth = random.Next(15, 35);
            var monkeys = this.Database.Rabits.Where(x => x.IsDead == false).ToList();
            foreach (var monkey in monkeys)
            {
                monkey.Energy -= toDecreaseRabitsHealth;
                if (monkey.Energy < 40)
                {
                    monkey.IsDead = true;
                }
            }
            return "Most of the animals are starving. Feed them!";
        }
    }
}
