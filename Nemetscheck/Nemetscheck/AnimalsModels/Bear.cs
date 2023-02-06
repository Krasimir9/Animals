namespace Nemetscheck.Animals
{
    public class Bear : BaseAnimal
    {
        public Bear(string species, int currentEnergy, bool isDead)
        {
            this.Species= species;
            this.CurrentEnergy= currentEnergy;
            this.IsDead= isDead;
        }

        private const int _maxEnergy = 30;
        
        public new string Species { get; set; }

        public new int CurrentEnergy { get; set; }

        public new bool IsDead { get; set; }
    }
}
