using Nemetscheck.Animals;

namespace Nemetscheck.Repository.Contarcts
{
    public interface IAnimalRepository
    {
        public Bear CreateBear(string species, int currentEnergy, bool isDead);

        public Wolf CreateWolf(string species, int currentEnergy, bool isDead);

        public Rabit CreateRabit(string species, int currentEnergy, bool isDead);
    }
}
