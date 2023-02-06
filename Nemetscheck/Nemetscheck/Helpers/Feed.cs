using Nemetscheck.Database;
using Nemetscheck.Helpers.Commands;
using Nemetscheck.Repository.Contarcts;

namespace Zoo.Core.Commands
{
    public class Feed : Command
    {
        public Feed(List<string> parameters, IInMemoryDataBase database, IAnimalRepository repository)
            : base(parameters, database, repository)
        {
        }
        public override string Execute()
        {
            var animals = Database.Animals.Where(x => x.IsDead == false).ToList();
            animals = animals.OrderByDescending(x => x.Energy).ToList();
            int toFeed = (int)Math.Floor(animals.Count * 0.9);
            var animalsToFeed = animals.Take(toFeed).ToList();
            var random = new Random();
            var toIncreaseBearsHealth = random.Next(10, 25);
            foreach (var animal in animalsToFeed)
            {
                animal.Energy += toIncreaseBearsHealth;
                if (animal.Energy > 100)
                {
                    animal.Energy = 100;
                }
            }
            return "Animals have been fed!";
        }
    }
}
