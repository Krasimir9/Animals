using Nemetscheck.Animals;
using Nemetscheck.Repository.Contarcts;

namespace Nemetscheck.Repository
{
    public class AnimalRepository : IAnimalRepository
    {

        public Bear CreateBear(string species, int currentEnergy, bool isDead)
        {
            return new Bear(species, currentEnergy, isDead);
        }

        public Rabit CreateRabit(string species, int currentEnergy, bool isDead)
        {
            return new Rabit(species, currentEnergy, isDead);
        }

        public Wolf CreateWolf(string species, int currentEnergy, bool isDead)
        {
            return new Wolf(species, currentEnergy, isDead);
        }
    }
}
