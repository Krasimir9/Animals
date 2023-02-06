namespace Nemetscheck.Animals
{
    public abstract class BaseAnimal
    {
        public string Species { get; }

        public int Energy { get; set; }

        public bool IsDead { get; set; }
    }
}
