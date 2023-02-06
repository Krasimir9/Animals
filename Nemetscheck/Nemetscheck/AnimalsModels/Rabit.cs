
namespace Nemetscheck.Animals
{
    public class Rabit : BaseAnimal
    {
        public Rabit(string species, int currentEnergy, bool isDead)
        {
            this.Species = species;
            this.CurrentEnergy = currentEnergy;
            this.IsDead = isDead;
        }

        private const int _maxEnergy = 10;

        public new string Species { get; set; }

        public new int CurrentEnergy { get; set; }

        public new bool IsDead { get; set; }
    }
}
